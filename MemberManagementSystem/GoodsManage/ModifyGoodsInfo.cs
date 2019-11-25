using MemberManagementSystem.Init;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 编辑商品信息
/// </summary>

namespace MemberManagementSystem.GoodsManage
{
    public partial class ModifyGoodsInfo : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public TreeNode selectedGoodsTypeNode;
        public ListViewItem selectedSupplierItem;
        public bool is_by_num;

        int id;
        string goods_name;

        //构造函数接收传入的ListView子项类型
        public ModifyGoodsInfo(ListViewItem.ListViewSubItemCollection listViewSubItem)
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            //设置各商品信息为传入的商品信息
            id = int.Parse(listViewSubItem[0].Text);
            goods_name = listViewSubItem[1].Text;
            goods_name_txb.Text = listViewSubItem[1].Text;
            select_goods_type_btn.Text = listViewSubItem[2].Text;
            stock_num_txb.Text = listViewSubItem[3].Text;
            sell_price_txb.Text = listViewSubItem[5].Text;
            purchase_price_txb.Text = listViewSubItem[6].Text;
            select_supplier_btn.Text = listViewSubItem[8].Text;
        }

        //FindParentNode递归方法
        public void FindParentNode(TreeNode treeNode)
        {
            if (treeNode == null)
            {
                return;
            }

            if (treeNode.Parent == null)
            {
                if (treeNode.Index == 0)
                {
                    is_by_num = true;
                    return;
                }
                else if (treeNode.Index == 1)
                {
                    is_by_num = false;
                    return;
                }
            }
            else
            {
                FindParentNode(treeNode.Parent);
            }
        }

        //选择商品分类按钮点击事件
        private void select_goods_type_btn_Click(object sender, EventArgs e)
        {
            SetGoodsType setGoodsType = new SetGoodsType(true);
            setGoodsType.isModifyingGoods = true;
            setGoodsType.ShowDialog(this);

            if (selectedGoodsTypeNode != null)
            {
                select_goods_type_btn.Text = selectedGoodsTypeNode.Text;
            }

            FindParentNode(selectedGoodsTypeNode);
            is_by_num_cbx.Checked = is_by_num;
            if (is_by_num_cbx.Checked)
            {
                stock_num_txb.Text = "-1";
                stock_num_txb.Enabled = false;
            }
            if (stock_num_txb.Text == "-1" && !is_by_num_cbx.Checked)
            {
                stock_num_txb.Text = "0";
            }

            is_by_num_cbx.Enabled = false;
        }

        //选择供应商按钮点击事件
        private void select_supplier_btn_Click(object sender, EventArgs e)
        {
            SupplierManage supplierManage = new SupplierManage(true);
            supplierManage.isModifyingGoods = true;
            supplierManage.ShowDialog(this);

            if (selectedSupplierItem != null)
            {
                select_supplier_btn.Text = selectedSupplierItem.SubItems[1].Text;
            }
        }

        //确定按钮点击事件
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //确保必填项都不为空
            if (goods_name_txb.Text == "" || select_goods_type_btn.Text == LoadForm.TextList[98] || sell_price_txb.Text == "" || purchase_price_txb.Text == "")
            {
                MessageBox.Show("有必填项为空！");
                return;
            }

            //确保填写的商品名称不重复
            if (goods_name_txb.Text != goods_name)
            {
                cmd.CommandText = "select count(*) from goods where binary name = '" + goods_name_txb.Text + "'";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    MessageBox.Show("填写的商品已存在！");
                    return;
                }
                cmd.Dispose();
            }

            if (stock_num_txb.Text == "")
            {
                stock_num_txb.Text = "0";
            }

            int supplier_id = 0;
            string sql = "";
            if (select_supplier_btn.Text != LoadForm.TextList[98])
            {
                sql = "select id from supplier where name = '" + select_supplier_btn.Text + "'";
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplier_id = int.Parse(reader[0].ToString());
                }
                cmd.Dispose();
                reader.Close();
            }

            //更新数据库goods表
            sql = "update goods set name = '" + goods_name_txb.Text + "',type = '" + select_goods_type_btn.Text + "',stock_num = '" + stock_num_txb.Text + "',sell_price = '" + sell_price_txb.Text + "',purchase_price = '" + purchase_price_txb.Text + "',supplier_id = '" + supplier_id + "' where id = '" + id + "'";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteScalar();

            MessageBox.Show(LoadForm.TextList[80]);

            //调用父窗口的查询方法，刷新商品列表
            sql = "SELECT g.id, g.`name`, g.type, g.stock_num, g.sold_num, g.sell_price, g.purchase_price, g.stock_time, s.`name` as sName FROM goods as g, supplier as s WHERE g.supplier_id = s.id";
            GoodsList goodsList = (GoodsList)this.Owner;
            goodsList.goods_list_ltv.Items.Clear();
            goodsList.SelectGoods(sql);
            goodsList.Show();
            this.Dispose();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //弹出确认删除对话框
            MessageBoxButtons messbutton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show(LoadForm.TextList[81], LoadForm.TextList[63], messbutton);
            if (dr == DialogResult.OK)
            {
                string sql = ("delete from goods where id = '" + id + "'");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                MessageBox.Show(LoadForm.TextList[82]);

                //设置goods表自增的主键id从0开始(实际值为当前最大值加1)
                sql = ("alter table goods auto_increment = 0");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                //调用父窗口的查询方法，刷新商品列表
                sql = "SELECT g.id, g.`name`, g.type, g.stock_num, g.sold_num, g.sell_price, g.purchase_price, g.stock_time, s.`name` as sName FROM goods as g, supplier as s WHERE g.supplier_id = s.id";
                GoodsList goodsList = (GoodsList)this.Owner;
                goodsList.goods_list_ltv.Items.Clear();
                goodsList.SelectGoods(sql);
                goodsList.Show();
                this.Dispose();
            }
        }
    }
}

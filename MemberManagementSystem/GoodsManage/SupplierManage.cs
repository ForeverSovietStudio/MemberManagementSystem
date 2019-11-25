using MemberManagementSystem.Init;
using MemberManagementSystem.Other;
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
/// 供应商管理
/// </summary>

namespace MemberManagementSystem.GoodsManage
{
    public partial class SupplierManage : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public bool isSelectingSupplier;
        public bool isModifyingGoods;

        //构造函数接收传入的是否正在选择供应商bool值
        public SupplierManage(bool isSelectingSupplier)
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            //如果正在选择供应商，设置新增供应商分区不可用
            create_supplier_gpb.Enabled = !isSelectingSupplier;
            this.isSelectingSupplier = isSelectingSupplier;

            SelectSupplier("select * from supplier");
        }

        //供应商列表双击事件
        private void supplier_list_ltv_DoubleClick(object sender, EventArgs e)
        {
            if (isSelectingSupplier)
            {
                if (!isModifyingGoods)
                {
                    CreateGoods createGoods = (CreateGoods)this.Owner;
                    createGoods.selectedSupplierItem = supplier_list_ltv.SelectedItems[0];
                    createGoods.Show();
                    this.Dispose();
                }
                else
                {
                    ModifyGoodsInfo modifyGoodsInfo = (ModifyGoodsInfo)this.Owner;
                    modifyGoodsInfo.selectedSupplierItem = supplier_list_ltv.SelectedItems[0];
                    modifyGoodsInfo.Show();
                    this.Dispose();
                }
            }
            else
            {
                ModifySupplierInfo modifySupplierInfo = new ModifySupplierInfo(supplier_list_ltv.SelectedItems[0].SubItems);
                modifySupplierInfo.ShowDialog(this);
            }
        }

        //查询供应商方法
        public void SelectSupplier(string sql)
        {
            supplier_list_ltv.Items.Clear();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == "0")
                {
                    continue;
                }
                //向供应商列表添加数据
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader[0].ToString();
                for (int i = 1; i < 7; i++)
                {
                    listViewItem.SubItems.Add(reader[i].ToString());
                }
                supplier_list_ltv.Items.Add(listViewItem);
            }
            cmd.Dispose();
            reader.Close();
        }

        //清空条件按钮点击事件
        private void clear_btn_Click(object sender, EventArgs e)
        {
            by_name_txb.Text = "";
            by_tel_txb.Text = "";
            by_goods_name_txb.Text = "";
            string sql = "select * from supplier";
            SelectSupplier(sql);
        }

        //查询按钮点击事件
        private void select_btn_Click(object sender, EventArgs e)
        {
            string sql = "select * from supplier ";

            //按姓名模糊查询，联系方式模糊查询，供应商名称精确查询
            if (by_name_txb.Text != "")
            {
                sql += "where name like '%" + by_name_txb.Text + "%'";
            }
            else
            {
                sql += "where name like '%%'";
            }
            if (by_tel_txb.Text != "")
            {
                sql += "and tel like '%" + by_tel_txb.Text + "%'";
            }
            if (by_goods_name_txb.Text != "")
            {
                int supplier_id = 0;
                string sql_1 = "select supplier_id from goods where name = '" + by_goods_name_txb.Text + "'";
                cmd = new MySqlCommand(sql_1, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplier_id = int.Parse(reader[0].ToString());
                }
                cmd.Dispose();
                reader.Close();

                sql += "and id = '" + supplier_id + "'";
            }

            //刷新ListView，显示查询结果
            SelectSupplier(sql);
        }

        //创建按钮点击事件
        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_txb.Text == "" || tel_txb.Text == "" || address_txb.Text == "")
            {
                MessageBox.Show("有必填项为空！");
                return;
            }

            cmd.CommandText = "select count(*) from supplier where binary name = '" + name_txb.Text + "'";

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
            {
                MessageBox.Show("填写的供应商已存在！");
                return;
            }
            cmd.Dispose();

            if (remarks_txb.Text == "")
            {
                remarks_txb.Text = "无";
            }

            string sql = "insert into supplier (id,name,tel,address,create_time,remarks) values ('0','" + name_txb.Text + "','" + tel_txb.Text + "','" + address_txb.Text + "','" + DateTime.Now + "','" + remarks_txb.Text + "')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("创建成功！");
            sql = "select * from supplier";
            SelectSupplier(sql);
        }

        //取消按钮点击事件
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //限制联系方式(查询供应商时)文本输入，不允许负数
        private void by_tel_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //限制联系方式(新增供应商时)文本输入，不允许负数
        private void tel_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //点击供应商列表头
        private void supplier_list_ltv_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //调用排序方法
            ListViewItemComparer.SortItem(sender,e);
        }

    }
}

﻿using MemberManagementSystem.Init;
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
/// 新增商品
/// </summary>

namespace MemberManagementSystem.GoodsManage
{
    public partial class CreateGoods : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public TreeNode selectedGoodsTypeNode;
        public ListViewItem selectedSupplierItem;
        public bool is_by_num;

        public CreateGoods()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }

        //寻找根节点递归方法，传入初始节点参数
        public void FindParentNode(TreeNode treeNode)
        {
            //如果传入节点为空，则结束
            if (treeNode == null)
            {
                return;
            }

            //如果传入节点的父节点为空，即已找到根节点
            if (treeNode.Parent == null)
            {
                //如果根节点索引为0，则为计次消费商品，否则为非计次消费商品
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
            //如果传入节点的父节点不为空，将传入节点的父节点作为新的节点传入该方法，开始递归
            else
            {
                FindParentNode(treeNode.Parent);
            }
        }

        //选择商品分类按钮点击事件
        private void select_goods_type_btn_Click(object sender, EventArgs e)
        {
            //打开商品分类窗口，设置商品分类窗口的是否正在选择商品分类属性为真
            SetGoodsType setGoodsType = new SetGoodsType(true);
            setGoodsType.ShowDialog(this);

            //如果选择的分类不为空，将该按钮的文本修改为选择的商品分类
            if (selectedGoodsTypeNode != null)
            {
                select_goods_type_btn.Text = selectedGoodsTypeNode.Text;
            }

            //调用FindParentNode方法，传入当前选择的分类节点
            FindParentNode(selectedGoodsTypeNode);
            //设置是否为计次商品的复选框值为is_by_num
            is_by_num_cbx.Checked = is_by_num;
            //如果是计次商品，设置库存数量为-1且不允许更改
            if (is_by_num_cbx.Checked)
            {
                stock_num_txb.Text = "-1";
                stock_num_txb.Enabled = false;
            }
            //如果是非计次商品，允许修改库存数量
            else
            {
                stock_num_txb.Text = "";
                stock_num_txb.Enabled = true;
            }

            //禁用是否为计次商品的复选框
            is_by_num_cbx.Enabled = false;
        }

        //选择供应商按钮点击事件
        private void select_supplier_btn_Click(object sender, EventArgs e)
        {
            //打开供应商管理窗口，设置供应商管理窗口是否正在选择供应商属性为真
            SupplierManage supplierManage = new SupplierManage(true);
            supplierManage.ShowDialog(this);

            //如果选择的供应商不为空，将该按钮的文本修改为选择的供应商名称
            if (selectedSupplierItem != null)
            {
                select_supplier_btn.Text = selectedSupplierItem.SubItems[1].Text;
            }
        }

        //确认按钮点击事件
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //确保必填项都不为空
            if (goods_name_txb.Text == "" || select_goods_type_btn.Text == LoadForm.TextList[98] || sell_price_txb.Text == "" || purchase_price_txb.Text == "")
            {
                MessageBox.Show("有必填项为空！");
                return;
            }

            //确保填写的商品名称不重复
            cmd.CommandText = "select count(*) from goods where binary name = '" + goods_name_txb.Text + "'";

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
            {
                MessageBox.Show("填写的商品已存在！");
                return;
            }
            cmd.Dispose();

            //如果未填写库存数量，将库存数量设置为0
            if (stock_num_txb.Text == "")
            {
                stock_num_txb.Text = "0";
            }

            //根据选择的供应商名称获取供应商id，若未选择则为0
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

            //向数据库goods表插入相关数据
            sql = "insert into goods (id,name,type,stock_num,sold_num,sell_price,purchase_price,stock_time,supplier_id) values ('0','" + goods_name_txb.Text + "','" + select_goods_type_btn.Text + "','" + stock_num_txb.Text + "','0','" + sell_price_txb.Text + "','" + purchase_price_txb.Text + "','" + DateTime.Now + "','" + supplier_id + "')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("创建成功！");
            this.Dispose();
        }

        //取消按钮点击事件
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //更改是否为计次商品复选框值事件
        private void is_by_num_cbx_CheckedChanged(object sender, EventArgs e)
        {
            stock_num_txb.Enabled = !is_by_num_cbx.Checked;
        }

        //限制库存数量文本输入，不允许负数
        private void stock_num_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //限制销售价格文本输入，不允许负数
        private void sell_price_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 0);
        }

        //限制采购价格文本输入，不允许负数
        private void purchase_price_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 0);
        }
    }
}

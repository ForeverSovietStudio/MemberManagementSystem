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
/// 编辑供应商信息
/// </summary>

namespace MemberManagementSystem.GoodsManage
{
    public partial class ModifySupplierInfo : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        int id;

        //构造函数接收传入的ListView子项类型
        public ModifySupplierInfo(ListViewItem.ListViewSubItemCollection listViewSubItem)
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            //设置各供应商信息为传入的供应商信息
            id = int.Parse(listViewSubItem[0].Text);
            name_txb.Text = listViewSubItem[1].Text;
            tel_txb.Text = listViewSubItem[2].Text;
            address_txb.Text = listViewSubItem[3].Text;
            remarks_txb.Text = listViewSubItem[6].Text;
        }

        //删除按钮点击事件
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //弹出确认删除对话框
            MessageBoxButtons messbutton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show(LoadForm.TextList[81], LoadForm.TextList[63], messbutton);
            if (dr == DialogResult.OK)
            {
                string sql = ("delete from supplier where id = '" + id + "'");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                MessageBox.Show(LoadForm.TextList[82]);

                //设置supplier表自增的主键id从0开始(实际值为当前最大值加1)
                sql = ("alter table supplier auto_increment = 0");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                //调用父窗口的查询方法，刷新供应商列表
                sql = "select * from supplier ";
                SupplierManage supplierManage = (SupplierManage)this.Owner;
                supplierManage.supplier_list_ltv.Items.Clear();
                supplierManage.SelectSupplier(sql);
                supplierManage.Show();
                this.Dispose();
            }
        }

        //确定按钮点击事件
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //设置备注的默认值并确保必填项不为空
            if (remarks_txb.Text == "")
            {
                remarks_txb.Text = LoadForm.TextList[56];
            }

            if (name_txb.Text == "" || tel_txb.Text == "" || address_txb.Text == "")
            {
                MessageBox.Show(LoadForm.TextList[57]);
                return;
            }

            //更新数据库suppier表
            string sql = "update supplier set name = '" + name_txb.Text + "',tel = '" + tel_txb.Text + "',address = '" + address_txb.Text + "',remarks = '" + remarks_txb.Text + "' where id = '" + id + "'";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteScalar();

            MessageBox.Show(LoadForm.TextList[80]);

            //调用父窗口的查询方法，刷新供应商列表
            sql = "select * from supplier ";
            SupplierManage supplierManage = (SupplierManage)this.Owner;
            supplierManage.supplier_list_ltv.Items.Clear();
            supplierManage.SelectSupplier(sql);
            supplierManage.Show();
            this.Dispose();
        }

        //取消按钮点击事件
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //限制联系方式文本输入，不允许负数
        private void tel_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }
    }
}

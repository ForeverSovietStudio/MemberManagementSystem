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
/// 会员充值
/// </summary>

namespace MemberManagementSystem.UserManage
{
    public partial class UserCharge : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        //构造函数接收传入的ListView子项类型
        public UserCharge(ListViewItem.ListViewSubItemCollection listViewSubItem)
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            //通过接收的ListView子项显示当前选中的会员信息(不可编辑)
            id_txb.Text = listViewSubItem[0].Text.ToString();
            name_txb.Text = listViewSubItem[1].Text.ToString();
            tel_txb.Text = listViewSubItem[3].Text.ToString();
            balance_txb.Text = listViewSubItem[5].Text.ToString();
            total_num_txb.Text = listViewSubItem[6].Text.ToString();
        }

        //充值按钮点击事件
        private void charge_btn_Click(object sender, EventArgs e)
        {
            //按输入的充值金额，充值消费次数更新数据库user表
            string sql = "update user set ";

            if (charge_balance_txb.Text != "" && charge_num_txb.Text != "")
            {
                sql += "balance = balance + '" + Double.Parse(charge_balance_txb.Text) + "',total_num = total_num + '" + charge_num_txb.Text + "'";
            }
            else if (charge_balance_txb.Text != "")
            {
                sql += "balance = balance + '" + Double.Parse(charge_balance_txb.Text) + "' ";
            }
            else if (charge_num_txb.Text != "")
            {
                sql += "total_num = total_num + '" + charge_num_txb.Text + "' ";
            }
            else
            {
                MessageBox.Show("请至少填入一种充值类型！");
                return;
            }

            sql += " where id = '" + int.Parse(id_txb.Text.ToString()) + "'";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteScalar();
            MessageBox.Show("充值成功！");

            //调用父窗口的查询方法，刷新会员列表
            sql = "select * from user";
            UserList userList = (UserList)this.Owner;
            userList.user_list_ltv.Items.Clear();
            userList.SelectUser(sql);
            userList.Show();
            this.Dispose();

        }

        //取消按钮点击事件
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //限制充值金额控件输入，不允许负数
        private void charge_balance_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //限制充值消费次数控件输入，不允许负数
        private void charge_num_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 0);
        }
    }
}

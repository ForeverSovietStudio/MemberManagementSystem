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
/// 编辑会员等级
/// </summary>

namespace MemberManagementSystem.UserManage
{
    public partial class ModifyUserRank : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        string id;
        string rank_name;
        string first_rank_name;

        //构造函数接收传入的ListView子项类型
        public ModifyUserRank(ListViewItem.ListViewSubItemCollection listViewSubItem,string first_rank_name)
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            id = listViewSubItem[0].Tag.ToString();  //设置当前选中会员等级的id
            this.first_rank_name = first_rank_name;  //设置传入的第一个等级的名称
            rank_name = listViewSubItem[0].Text;
            rank_name_txb.Text = listViewSubItem[0].Text;
            discount_rate_txb.Text = listViewSubItem[1].Text;
        }

        //确定按钮点击事件
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //确保所有必填项不为空
            if (rank_name_txb.Text == "" || discount_rate_txb.Text == "")
            {
                MessageBox.Show(LoadForm.TextList[57]);
                return;
            }

            //如果修改了等级名称，则判断名称是否重复
            if (rank_name_txb.Text != rank_name)
            {
                cmd.CommandText = "select count(*) from user_rank where binary name = '" + rank_name_txb.Text + "'";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    MessageBox.Show("该等级已存在！");

                    cmd.Dispose();
                    return;
                }
            }

            //确保输入的折扣比例小于等于1
            if (double.Parse(discount_rate_txb.Text) > 1)
            {
                MessageBox.Show("折扣比例需小于等于1！");
                return;
            }
            //更新user_rank表的等级名称和折扣比例
            string sql = ("update user_rank set name = '" + rank_name_txb.Text + "',discount_rate = '" + discount_rate_txb.Text + "' where name = '" + rank_name + "'");
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteScalar();

            //更新user表，修改所有会员等级已被修改的会员的会员等级
            sql = ("update user set user_rank = '" + rank_name_txb.Text + "' where user_rank = '" + rank_name + "'");
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteScalar();

            MessageBox.Show(LoadForm.TextList[80]);

            //调用父窗口的查询方法，刷新会员等级列表
            sql = "select * from user_rank ";
            SetRank setRank = (SetRank)this.Owner;
            setRank.SelectRank(sql);
            setRank.Show();
            this.Dispose();
        }

        //删除按钮点击事件
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //如果选中的是第一个等级，则禁止删除
            if (id == "0")
            {
                MessageBox.Show("第一个等级不能被删除！");
                return;
            }

            //弹出确认删除对话框
            MessageBoxButtons messbutton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show(LoadForm.TextList[81], LoadForm.TextList[63], messbutton);
            if (dr == DialogResult.OK)
            {
                //删除选中的会员等级
                string sql = ("delete from user_rank where name = '" + rank_name + "'");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                //更新数据库user表，将所有会员等级等于已被删除的等级的会员的会员等级设置为第一个等级
                sql = ("update user set user_rank = '" + first_rank_name + "' where user_rank = '" + rank_name + "'");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                MessageBox.Show(LoadForm.TextList[82]);

                //设置user_rank表自增的主键id从0开始(实际值为当前最大值加1)
                sql = ("alter table user_rank auto_increment = 0");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                //调用父窗口的查询方法，刷新会员等级列表
                sql = "select * from user_rank ";
                SetRank setRank = (SetRank)this.Owner;
                setRank.SelectRank(sql);
                setRank.Show();
                this.Dispose();
            }
        }
    }
}

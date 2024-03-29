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
/// 编辑会员信息
/// </summary>

namespace MemberManagementSystem.UserManage
{
    public partial class ModifyUserInfo : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        int id;

        //构造函数接收传入的ListView子项类型
        public ModifyUserInfo(ListViewItem.ListViewSubItemCollection listViewSubItem)
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];

            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            //查询并设置会员等级选项
            string sql = "select name from user_rank order by discount_rate desc";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string data = reader[0].ToString();
                user_rank_cbb.Items.Add(data);
            }
            cmd.Dispose();
            reader.Close();

            //查询并设置会员状态选项
            sql = "select name from user_status";
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string data = reader[0].ToString();
                user_status_cbb.Items.Add(data);
            }
            cmd.Dispose();
            reader.Close();

            //通过接收的ListView子项显示当前选中的会员信息
            id = int.Parse(listViewSubItem[0].Text);
            name_txb.Text = listViewSubItem[1].Text;
            sex_cbb.Text = listViewSubItem[2].Text;
            tel_txb.Text = listViewSubItem[3].Text;
            user_rank_cbb.Text = listViewSubItem[8].Text;
            user_status_cbb.Text = listViewSubItem[9].Text;
            expired_time_dtp.Value = Convert.ToDateTime(listViewSubItem[12].Text.ToString());
            remarks_txb.Text = listViewSubItem[13].Text;
        }

        //确定按钮点击事件
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //设置备注的默认值并确保必填项不为空
            if (remarks_txb.Text == "")
            {
                remarks_txb.Text = LoadForm.TextList[56];
            }

            if (name_txb.Text == "" || tel_txb.Text == "")
            {
                MessageBox.Show(LoadForm.TextList[57]);
                return;
            }

            //更新数据库user表
            string sql = "update user set name = '" + name_txb.Text + "',sex = '" + sex_cbb.Text + "',tel = '" + tel_txb.Text + "',user_rank = '" + user_rank_cbb.Text + "',user_status = '" + user_status_cbb.Text + "',expired_time = '" + expired_time_dtp.Value + "',remarks = '" + remarks_txb.Text + "' where id = '" + id +"'";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteScalar();

            MessageBox.Show(LoadForm.TextList[80]);

            //调用父窗口的查询方法，刷新会员列表
            sql = "select * from user ";
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

        //限制联系方式控件输入，不允许负数
        private void tel_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //删除会员按钮点击事件
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //弹出确认删除对话框
            MessageBoxButtons messbutton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show(LoadForm.TextList[81], LoadForm.TextList[63], messbutton);
            if (dr == DialogResult.OK)
            {
                string sql = ("delete from user where id = '" + id + "'");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                MessageBox.Show(LoadForm.TextList[82]);

                //设置user表自增的主键id从0开始(实际值为当前最大值加1)
                sql = ("alter table user auto_increment = 0");
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                //调用父窗口的查询方法，刷新会员列表
                sql = "select * from user ";
                UserList userList = (UserList)this.Owner;
                userList.user_list_ltv.Items.Clear();
                userList.SelectUser(sql);
                userList.Show();
                this.Dispose();
            }
        }
    }
}

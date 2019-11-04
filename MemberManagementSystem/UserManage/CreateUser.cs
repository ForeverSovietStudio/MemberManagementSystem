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

namespace MemberManagementSystem.UserManage
{
    public partial class CreateUser : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public CreateUser()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[24];

            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            string name = name_txb.Text;
            string sex = sex_cbb.Text;
            string tel = tel_txb.Text;
            double balance = double.Parse(balance_txb.Text);
            int total_num = int.Parse(total_num_txb.Text);
            string user_level = user_level_cbb.Text;
            DateTime register_time = DateTime.Now;
            DateTime expired_time = expired_time_dtp.Value;
            string remarks = remarks_txb.Text;
            if (remarks == "")
            {
                remarks = "无";
            }

            string sql = ("insert into user (name,sex,tel,total_charge_num,balance,total_num,charge_num,user_level,user_status,register_time,expired_time,remarks) values ('" + name + "','" + sex + "','" + tel + "','" + "0','" + balance + "','" + total_num + "','" + "0','" + user_level + "','" + "1','" + register_time + "','" + expired_time + "','" + remarks + "')");
            cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();

            MessageBox.Show("添加成功！");
            this.Dispose();
        }

        private void tel_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        private void balance_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 1);
        }

        private void total_num_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 0);
        }
    }
}

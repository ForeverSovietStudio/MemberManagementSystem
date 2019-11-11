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
/// 创建会员
/// </summary>

namespace MemberManagementSystem.UserManage
{
    public partial class CreateUser : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public CreateUser()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];

            LoadForm.LoadText(this);

            //查询数据库会员等级表
            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            string sql = "select name from user_rank";
            cmd = new MySqlCommand(sql,conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string data = reader[0].ToString();
                user_rank_cbb.Items.Add(data);
            }
            cmd.Dispose();
            reader.Close();

            //设置会员等级和过期时间的默认值
            user_rank_cbb.Text = user_rank_cbb.Items[0].ToString();
            expired_time_dtp.Value = DateTime.Now.AddYears(10);
        }

        //创建按钮点击事件
        private void create_btn_Click(object sender, EventArgs e)
        {
            //设置卡上余额和可消费次数的默认值
            if (balance_txb.Text == "")
            {
                balance_txb.Text = "0";
            }
            if (total_num_txb.Text == "")
            {
                total_num_txb.Text = "10";
            }
            
            string name = name_txb.Text;
            string sex = sex_cbb.Text;
            string tel = tel_txb.Text;
            double balance = double.Parse(balance_txb.Text);
            int total_num = int.Parse(total_num_txb.Text);
            string user_rank = user_rank_cbb.Text;
            DateTime register_time = DateTime.Now;
            DateTime expired_time = expired_time_dtp.Value;
            string remarks = remarks_txb.Text;

            //设置是否填写备注及判断必填项是否为空
            if (remarks == "" || remarks_txb.Enabled == false)
            {
                remarks = LoadForm.TextList[56];
            }
            if (name == "" || sex == "" || tel == "")
            {
                MessageBox.Show(LoadForm.TextList[57]);
                return;
            }
            //判断过期时间是否晚于当前时间
            if (DateTime.Compare(DateTime.Now,expired_time) >= 0)
            {
                MessageBox.Show(LoadForm.TextList[58]);
                return;
            }

            //卡上余额，可消费次数及会员等级的默认值
            if (balance_txb.Text == "")
            {
                balance_txb.Text = "0";
                balance = 0;
            }
            if (total_num_txb.Text == "")
            {
                total_num_txb.Text = "10";
                total_num = 10;
            }
            if (user_rank_cbb.Text == "")
            {
                user_rank_cbb.Text = user_rank_cbb.Items[0].ToString();
                user_rank = user_rank_cbb.Items[0].ToString();
            }

            //按填写的信息向数据库用户表插入数据
            string sql = ("insert into user (name,sex,tel,total_consume_balance,balance,total_num,total_consume_num,user_rank,user_status,register_time,expired_time,remarks) values ('" + name + "','" + sex + "','" + tel + "','" + "0','" + balance + "','" + total_num + "','" + "0','" + user_rank + "','" + LoadForm.TextList[60] + "','" + register_time + "','" + expired_time + "','" + remarks + "')");
            cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();

            MessageBox.Show(LoadForm.TextList[59]);
            this.Dispose();
        }

        //联系方式限制输入，不允许负数
        private void tel_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //卡上余额限制输入，允许负数
        private void balance_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 1);
        }

        //可消费次数限制输入，不允许负数
        private void total_num_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 0);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //若不设置备注，则禁用备注输入框
        private void is_set_remarks_ckb_CheckedChanged(object sender, EventArgs e)
        {
            remarks_txb.Enabled = !remarks_txb.Enabled;
        }
    }
}

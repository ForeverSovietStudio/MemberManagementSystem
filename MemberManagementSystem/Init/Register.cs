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
/// 注册窗口
/// </summary>

namespace MemberManagementSystem.Init
{
    public partial class Register : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public Register()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoadForm.LoadText(this);
        }

        //返回按钮点击事件
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //注册按钮点击事件
        private void register_btn_Click(object sender, EventArgs e)
        {
            //用户名不能重复
            if (account_txb.Text != "" && (password_txb.Text == password_confirm_txb.Text && password_txb.Text != ""))
            {
                cmd.CommandText = "select count(*) from admin where binary username = '" + username_txb.Text + "'";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    MessageBox.Show(LoadForm.TextList[11]);

                    cmd.Dispose();

                    return;
                }

                string sql = ("insert into admin (username,account,password) values ('" + username_txb.Text + "','" + account_txb.Text + "','" + password_confirm_txb.Text + "')");
                cmd = new MySqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show(LoadForm.TextList[12]);
                }
                else
                {
                    MessageBox.Show(LoadForm.TextList[13]);
                }

                cmd.Dispose();
                this.Dispose();
            }
            else if (username_txb.Text == "" || account_txb.Text == "")
            {
                MessageBox.Show(LoadForm.TextList[14]);
            }
            else if (password_txb.Text == "" || password_confirm_txb.Text == "")
            {
                MessageBox.Show(LoadForm.TextList[15]);
            }
            else
            {
                MessageBox.Show(LoadForm.TextList[16]);
            }
        }
    }
}

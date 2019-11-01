using MemberManagementSystem.Init;
using MemberManagementSystem.Main;
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
/// 登录窗口
/// </summary>

namespace MemberManagementSystem
{
    public partial class LoginForm : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public LoginForm()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
        }

        //加载文本内容
        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadForm.LoadText(this);
        }

        //登录按钮点击事件
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txb.Text != "" && password_txb.Text != "")
            {
                //查询数据库admin表
                cmd = new MySqlCommand();
                cmd.CommandText = string.Format("select count(*) from admin where binary username= '" + username_txb.Text + "' and binary password= '" + password_txb.Text + "' ");

                conn = Program.ConDataBase();
                cmd.Connection = conn;

                //判断用户名和密码是否正确
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    MessageBox.Show(LoadForm.TextList[5]);
                }
                else
                {
                    MessageBox.Show(LoadForm.TextList[6]);

                    cmd.Dispose();
                    conn.Close();

                    MainSurface mainSurface = new MainSurface();
                    mainSurface.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(LoadForm.TextList[7]);
            }
        }

        //点击关闭按钮时，结束整个程序
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}

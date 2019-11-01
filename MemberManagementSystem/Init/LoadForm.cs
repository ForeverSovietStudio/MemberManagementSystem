using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///  加载窗口
/// </summary>

namespace MemberManagementSystem.Init
{
    public partial class LoadForm : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        //存储程序所有文本内容的列表
        public static List<string> TextList;

        public LoadForm()
        {
            InitializeComponent();

            TextList = new List<string>();

            //查询数据库text表，将string字段的内容存储在TextList中
            cmd = new MySqlCommand();
            cmd.CommandText = string.Format("SELECT string FROM text");
            conn = Program.ConDataBase();
            cmd.Connection = conn;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TextList.Add(reader[0].ToString());
            }

            cmd.Dispose();
            reader.Close();
            
            timer1.Enabled = true;
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            
        }

        //计时器，一定时间后使加载界面隐藏
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Visible = false;
            timer1.Stop();
            timer1.Dispose();
        }

        //递归遍历所有tag值不为空的控件
        private static void LoadControl(Control control)
        {
            try
            {
                if (control.Tag != null)
                {
                    control.Text = LoadForm.TextList[int.Parse(control.Tag.ToString())];
                }

                foreach (Control c in control.Controls)
                {
                    LoadControl(c);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(control.Name);
            }
            
        }

        //读取文本内容静态方法，所有需要加载文本内容的窗口都在初始化时调用该方法
        public static void LoadText(Form form)
        {
            foreach (Control control in form.Controls)
            {
                LoadControl(control);
            }
        }

    }
}

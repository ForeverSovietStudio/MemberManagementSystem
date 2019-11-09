using MemberManagementSystem.Init;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberManagementSystem.UserManage
{
    public partial class ImportInfo : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        string file = "";

        public ImportInfo()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }

        public static DataSet ReadExcel(string filepath)
        {
            try
            {
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";
                OleDbConnection oleConn = new OleDbConnection(strConn);
                oleConn.Open();
                string sql = "select * from [Sheet1$]";
                OleDbDataAdapter oleDaExcel = new OleDbDataAdapter(sql, oleConn);
                DataSet oleDsExcel = new DataSet();
                oleDaExcel.Fill(oleDsExcel, "table1");
                oleConn.Close();
                return oleDsExcel;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        private void select_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "Excel工作表(*xls*)|*.xls*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;//返回文件的完整路径                
            }

            selected_file_txb.Text = file;
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            if (file == "")
            {
                return;
            }
            
            try
            {
                DataSet ds = ReadExcel(file);
                List<string> list = (from DataRow row in ds.Tables["table1"].Rows select String.Format("insert into user(id,name,sex,tel,total_consume_balance,balance,total_num,total_consume_num,user_rank,user_status,register_time,last_consume_time,expired_time,remarks) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", 0, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9].ToString() == "" ? DateTime.Now : row[9], row[10].ToString() == "" ? DateTime.MinValue : row[10], row[11].ToString() == "" ? DateTime.Now.AddYears(10) : row[11], row[12].ToString() == "" ? "无" : row[12])).ToList();

                foreach (string item in list)
                {
                    MySqlCommand cmd = new MySqlCommand(item, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

                MessageBox.Show("导入成功！");
                file = "";
                selected_file_txb.Text = "";
            }
            catch
            {
                MessageBox.Show("导入失败，请检查文件内容！");
            }
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clear_file_btn_Click(object sender, EventArgs e)
        {
            file = "";
            selected_file_txb.Text = "";
        }
    }
}

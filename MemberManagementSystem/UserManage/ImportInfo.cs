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

        public ImportInfo()
        {
            InitializeComponent();

            //this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
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

    }
}

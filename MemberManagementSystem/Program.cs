using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemberManagementSystem.Init;
using MySql.Data.MySqlClient;

namespace MemberManagementSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadForm());
        }

        //连接数据库静态方法，所有数据库操作都调用该方法的返回值
        public static MySqlConnection ConDataBase()
        {
            String connetStr = "server=121.196.208.198;port=3306;user=kurui;password=kurui;database=membermanagementsystem;SslMode = none;characterset=utf8";

            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();

                return conn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;

        }

    }
}

using MemberManagementSystem.Init;
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
/// 高级查询
/// </summary>

namespace MemberManagementSystem.UserManage
{
    public partial class AdvancedSelect : Form
    {
        public AdvancedSelect()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            //设置按时间查询的默认值
            time_cbb.Text = time_cbb.Items[0].ToString();
        }

        //取消按钮点击事件
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //查询按钮点击事件
        private void select_btn_Click(object sender, EventArgs e)
        {
            string sql = "select * from user ";
            switch (time_cbb.SelectedIndex)
            {
                //按注册时间查询
                case 0:
                    sql += "where register_time between '" + time1_dtp.Value.ToString() + "' and '" + time2_dtp.Value.ToString() + "'";
                    break;
                //按过期时间查询
                case 1:
                    sql += "where expired_time between '" + time1_dtp.Value.ToString() + "' and '" + time2_dtp.Value.ToString() + "'";
                    break;
            }

            //调用父窗口的方法，根据查询结果刷新会员列表
            UserList userList = (UserList)this.Owner;
            userList.user_list_ltv.Items.Clear();
            userList.SelectUser(sql);
            userList.Show();
            this.Dispose();
        }

        //时间选择变化事件
        private void time_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (time_cbb.SelectedIndex)
            {
                //设置默认注册时间查询范围为去年到现在
                case 0:
                    time1_dtp.Value = DateTime.Now.AddYears(-1);
                    time2_dtp.Value = DateTime.Now;
                    break;
                //设置默认过期时间查询范围为9年后到10年后
                case 1:
                    time1_dtp.Value = DateTime.Now.AddYears(9);
                    time2_dtp.Value = DateTime.Now.AddYears(10);
                    break;
            }
        }

    }
}

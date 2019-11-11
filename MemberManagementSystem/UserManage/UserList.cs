using MemberManagementSystem.Init;
using MemberManagementSystem.Other;
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
/// 会员信息
/// </summary>

namespace MemberManagementSystem.UserManage
{
    public partial class UserList : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public UserList()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            //显示所有会员
            SelectUser("select * from user");

            //设置性别默认值
            by_sex_cbb.SelectedIndex = 2;

            //设置TreeView中会员等级节点
            string sql = "select name from user_rank";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                by_type_tvw.Nodes[0].Nodes.Add(reader[0].ToString());
            }
            cmd.Dispose();
            reader.Close();

            //设置TreeView中会员状态节点
            sql = "select name from user_status";
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                by_type_tvw.Nodes[1].Nodes.Add(reader[0].ToString());
            }
            cmd.Dispose();
            reader.Close();

            by_type_tvw.ExpandAll();
        }

        //查询方法，将查询结果以ListView的形式显示
        public void SelectUser(string sql)
        {
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //向会员列表添加数据
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader[0].ToString();
                for (int i = 1; i < 14; i++)
                {
                    listViewItem.SubItems.Add(reader[i].ToString());
                }
                user_list_ltv.Items.Add(listViewItem);
            }
            cmd.Dispose();
            reader.Close();
        }

        //限制按联系方式控件输入，不允许负数
        private void by_tel_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //查询按钮点击事件
        private void select_btn_Click(object sender, EventArgs e)
        {
            string sql = "select * from user ";

            //按姓名模糊查询，性别精确查询，联系方式模糊查询
            if (by_name_txb.Text != "")
            {
                sql += "where name like '%" + by_name_txb.Text + "%'";
            }
            else
            {
                sql += "where name like '%%'";
            }
            if (by_sex_cbb.Text != " ")
            {
                sql += "and sex = '" + by_sex_cbb.Text + "'";
            }
            if (by_tel_txb.Text != "")
            {
                sql += "and tel like '%" + by_tel_txb.Text + "%'";
            }

            //刷新ListView，显示查询结果
            user_list_ltv.Items.Clear();
            SelectUser(sql);
        }

        //清空条件按钮点击事件
        private void clear_btn_Click(object sender, EventArgs e)
        {
            //清空并刷新ListView
            string sql = "select * from user ";
            by_name_txb.Text = "";
            by_sex_cbb.Text = " ";
            by_tel_txb.Text = "";
            user_list_ltv.Items.Clear();
            SelectUser(sql);
        }

        //高级查询按钮点击事件
        private void advanced_select_btn_Click(object sender, EventArgs e)
        {
            AdvancedSelect advancedSelect = new AdvancedSelect();
            advancedSelect.ShowDialog(this);
        }

        //点击列表头，调用排序方法
        private void user_list_ltv_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer.SortItem(sender,e);
        }

        //双击某一条数据点击事件，弹出编辑会员信息窗口
        private void user_list_ltv_DoubleClick(object sender, EventArgs e)
        {
            //向编辑会员信息的类的构造函数传入当前选中的ListView的子项
            ModifyUserInfo modifyUserInfo = new ModifyUserInfo(user_list_ltv.SelectedItems[0].SubItems);
            modifyUserInfo.ShowDialog(this);
        }

        //选中TreeView节点后事件
        private void by_type_tvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string sql = "select * from user ";

            //判断选中的节点是否为子节点，若是则按子节点的条件查询，否则查询全部
            if (e.Node.Nodes.Count == 0)
            {
                if (e.Node.Parent == by_type_tvw.Nodes[0])
                {
                    sql += "where user_rank = '" + e.Node.Text + "'";
                }
                else if (e.Node.Parent == by_type_tvw.Nodes[1])
                {
                    sql += "where user_status = '" + e.Node.Text + "'";
                }
                
            }
            user_list_ltv.Items.Clear();
            SelectUser(sql);
        }

        //充值按钮点击事件
        private void charge_btn_Click(object sender, EventArgs e)
        {
            //若选中了某条数据，则弹出充值窗口
            if (user_list_ltv.SelectedItems.Count != 0)
            {
                //向会员充值的类的构造函数传入当前选中的ListView的子项
                UserCharge userCharge = new UserCharge(user_list_ltv.SelectedItems[0].SubItems);
                userCharge.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(LoadForm.TextList[89]);
                return;
            }
            
        }
    }
}

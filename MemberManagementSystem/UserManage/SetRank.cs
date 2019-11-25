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
/// 等级设置
/// </summary>

namespace MemberManagementSystem.UserManage
{
    public partial class SetRank : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        string first_rank_name;

        public SetRank()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            SelectRank("select * from user_rank");
        }

        //查询方法，将查询结果以ListView的形式显示
        public void SelectRank(string sql)
        {
            user_rank_ltv.Items.Clear();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //获取第一个等级的名称
                if (reader[0].ToString() == "0")
                {
                    first_rank_name = reader[1].ToString();
                }

                //向等级列表添加数据
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader[1].ToString();
                listViewItem.SubItems.Add(reader[2].ToString());
                user_rank_ltv.Items.Add(listViewItem);

                //遍历刚添加的一条数据的所有子项，设置其Tag为在数据库中的id值
                foreach (ListViewItem.ListViewSubItem subItem in listViewItem.SubItems)
                {
                    subItem.Tag = reader[0].ToString();
                }
            }
            cmd.Dispose();
            reader.Close();
        }

        //新增按钮点击事件
        private void create_btn_Click(object sender, EventArgs e)
        {
            //确保所有必填项不为空
            if (rank_name_txb.Text == "" || discount_rate_txb.Text == "")
            {
                MessageBox.Show(LoadForm.TextList[57]);
                return;
            }

            //确保新增的等级名不重复
            cmd.CommandText = "select count(*) from user_rank where binary name = '" + rank_name_txb.Text + "'";

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
            {
                MessageBox.Show("该等级已存在！");

                cmd.Dispose();
                return;
            }

            //确保输入的折扣比例小于等于1
            if (int.Parse(discount_rate_txb.Text) > 1)
            {
                MessageBox.Show("折扣比例需小于等于1！");
                return;
            }

            //向数据库user_rank表插入新增的会员等级
            string sql = ("insert into user_rank(id,name,discount_rate) values (" + "'0','" + rank_name_txb.Text + "','" + discount_rate_txb.Text + "')");
            cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                MessageBox.Show("添加成功！");
                user_rank_ltv.Items.Clear();
                SelectRank("select * from user_rank");
            }
            else
            {
                MessageBox.Show("添加失败，请重试！");
            }

            cmd.Dispose();
        }

        //清空按钮点击事件
        private void clear_btn_Click(object sender, EventArgs e)
        {
            rank_name_txb.Text = "";
            discount_rate_txb.Text = "";
        }

        //限制折扣比例控件输入，不允许负数
        private void discount_rate_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,0);
        }

        //点击列表头，调用排序方法
        private void user_rank_ltv_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer.SortItem(sender, e);
        }

        //双击某一条数据点击事件，弹出编辑会员等级信息窗口
        private void user_rank_ltv_DoubleClick(object sender, EventArgs e)
        {
            //向编辑会员等级信息的类的构造函数传入当前选中的ListView的子项
            ModifyUserRank modifyUserRank = new ModifyUserRank(user_rank_ltv.SelectedItems[0].SubItems,first_rank_name);
            modifyUserRank.ShowDialog(this);
        }
    }
}

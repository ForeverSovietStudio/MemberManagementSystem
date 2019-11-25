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
/// 商品列表
/// </summary>

namespace MemberManagementSystem.GoodsManage
{
    public partial class GoodsList : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public GoodsList()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            SelectGoods("SELECT g.id, g.`name`, g.type, g.stock_num, g.sold_num, g.sell_price, g.purchase_price, g.stock_time, s.`name` as sName FROM goods as g, supplier as s WHERE g.supplier_id = s.id");

            //调用AddNodes方法，传入默认根节点，初始化商品分类树
            AddNodes(by_type_tvw.Nodes[0], 1);
            AddNodes(by_type_tvw.Nodes[1], 2);
            by_type_tvw.ExpandAll();
        }

        //查询商品方法，传入sql语句
        public void SelectGoods(string sql)
        {
            //事先清空商品列表
            goods_list_ltv.Items.Clear();

            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //向商品列表添加数据
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader[0].ToString();
                for (int i = 1; i < 9; i++)
                {
                    listViewItem.SubItems.Add(reader[i].ToString());
                }
                goods_list_ltv.Items.Add(listViewItem);
            }
            cmd.Dispose();
            reader.Close();

        }

        //AddNodes递归方法，传入节点和pid值，向商品分类树添加节点
        public void AddNodes(TreeNode node, int pid)
        {
            //定义TreeNode类型的列表和int类型的id，存储当前节点的所有子节点及其id
            List<TreeNode> treeNodes = new List<TreeNode>();
            List<int> ids = new List<int>();

            //根据传入的pid(商品分类的父分类)从商品分类列表查询商品id和商品名称
            string sql = "select id,name from goods_type where pid ='" + pid + "'";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //向ids列表添加每个查询结果(子商品分类)的id
                ids.Add(int.Parse(reader[0].ToString()));
                //向treeNode列表添加每个查询结果的同时，向该层节点添加每个查询结果(子商品分类)
                treeNodes.Add(node.Nodes.Add(reader[1].ToString()));
            }
            cmd.Dispose();
            reader.Close();

            //遍历每一个ids里的id
            int j = 0;
            foreach (int i in ids)
            {
                //对每个结果传入treeNode列表里存储的每一个该层节点的子节点，及该层的商品分类id(作为下次递归的父分类id)，开始递归
                AddNodes(treeNodes[j], i);
                j++;
            }

            //当没有查询结果时，递归自然结束，此时已完成该层所有子节点的添加
        }

        //清空条件按钮点击事件
        private void clear_btn_Click(object sender, EventArgs e)
        {
            //刷新商品列表
            string sql = "SELECT g.id, g.`name`, g.type, g.stock_num, g.sold_num, g.sell_price, g.purchase_price, g.stock_time, s.`name` as sName FROM goods as g, supplier as s WHERE g.supplier_id = s.id";
            by_goods_name_txb.Text = "";
            by_supplier_name_txb.Text = "";
            SelectGoods(sql);
        }

        //查询按钮点击事件
        private void select_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT g.id, g.`name`, g.type, g.stock_num, g.sold_num, g.sell_price, g.purchase_price, g.stock_time, s.`name` as sName FROM goods as g, supplier as s WHERE g.supplier_id = s.id ";

            //按商品名称模糊查询，供应商名称模糊查询
            if (by_goods_name_txb.Text != "")
            {
                sql += "and g.`name` like '%" + by_goods_name_txb.Text + "%'";
            }
            else
            {
                sql += "and g.`name` like '%%'";
            }
            if (by_supplier_name_txb.Text != "")
            {
                sql += "and s.`name` like '%" + by_supplier_name_txb.Text + "%'";
            }

            //刷新商品列表，显示查询结果
            goods_list_ltv.Items.Clear();
            SelectGoods(sql);
        }

        //高级查询按钮点击事件
        private void advanced_select_btn_Click(object sender, EventArgs e)
        {
            //打开高级查询窗口
            AdvancedGoodsSelect advancedGoodsSelect = new AdvancedGoodsSelect();
            advancedGoodsSelect.ShowDialog(this);
        }

        //更改商品分类树选择节点事件
        private void by_type_tvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string sql = "SELECT g.id, g.`name`, g.type, g.stock_num, g.sold_num, g.sell_price, g.purchase_price, g.stock_time, s.`name` as sName FROM goods as g, supplier as s WHERE g.supplier_id = s.id ";
            //如果选择的节点是计次商品根节点，添加查询语句条件：库存数量为-1，即所有的计次商品
            if (by_type_tvw.SelectedNode == by_type_tvw.Nodes[0])
            {
                sql += "and g.stock_num = '-1'";
            }
            //如果选择的节点是非计次商品根节点，添加查询语句条件：库存数量不为-1，即所有的非计次商品
            else if (by_type_tvw.SelectedNode == by_type_tvw.Nodes[1])
            {
                sql += "and g.stock_num != '-1'";
            }
            //否则，调用FindChildType方法，传入选择的商品分类节点及当前的sql语句，得到最终的sql语句
            else
            {
                sql += "and (";
                sql = FindChildType(by_type_tvw.SelectedNode, sql);
                sql += ")";
            }

            //传入最终的sql语句，开始查询
            SelectGoods(sql);
        }

        //查找子节点递归方法，传入当前节点及当前的sql语句
        public string FindChildType(TreeNode treeNode,string sql)
        {
            //如果传入的节点不为当前选择的节点，添加查询语句条件：或者商品分类为当前节点的名称
            if (treeNode != by_type_tvw.SelectedNode)
            {
                sql += " or type = '" + treeNode.Text + "'";
            }
            //如果传入的节点等于当前选择的节点，添加查询语句条件：商品分类为当前节点的名称
            else
            {
                sql += "type = '" + treeNode.Text + "'";
            }
            
            //如果传入节点的子节点数量为0，结束运行，返回当前的sql语句
            if (treeNode.Nodes.Count == 0)
            {
                return sql;
            }

            //遍历传入节点的每个子节点，传入每个子节点和当前的sql语句，开始递归
            foreach (TreeNode node in treeNode.Nodes)
            {
                //修改当前的sql语句为每次递归后返回的新的sql语句
                sql = FindChildType(node,sql);
            }

            //结束本次运行，返回当前的sql语句
            return sql;
        }

        //双击商品列表事件
        private void goods_list_ltv_DoubleClick(object sender, EventArgs e)
        {
            //打开编辑商品信息窗口，传入当前选择的商品
            ModifyGoodsInfo modifyGoodsInfo = new ModifyGoodsInfo(goods_list_ltv.SelectedItems[0].SubItems);
            modifyGoodsInfo.ShowDialog(this);
        }

        //点击商品列表头事件
        private void goods_list_ltv_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //调用排序方法
            ListViewItemComparer.SortItem(sender,e);
        }
    }
}

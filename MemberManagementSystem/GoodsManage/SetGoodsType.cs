using MemberManagementSystem.Init;
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
/// 商品分类设置
/// </summary>

namespace MemberManagementSystem.GoodsManage
{
    public partial class SetGoodsType : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public bool isSelectingType;
        public bool isModifyingGoods = false;
        bool isModifyNode = false;
        bool isCreateNode = false;

        //构造函数接收传入的是否正在选择商品分类bool值
        public SetGoodsType(bool isSelectingType)
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            //如果正在选择商品分类，设置编辑商品分类分区不可用
            modify_goods_type_gpb.Enabled = !isSelectingType;
            this.isSelectingType = isSelectingType;

            ////调用AddNodes方法，传入默认根节点，初始化商品分类树
            AddNodes(goods_type_tvw.Nodes[0],1);
            AddNodes(goods_type_tvw.Nodes[1],2);
            goods_type_tvw.ExpandAll();
        }

        //AddNodes递归方法，传入节点和pid值，向商品分类树添加节点
        public void AddNodes(TreeNode node,int pid)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            List<int> ids = new List<int>();

            string sql = "select id,name from goods_type where pid ='" + pid + "'";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ids.Add(int.Parse(reader[0].ToString()));
                treeNodes.Add(node.Nodes.Add(reader[1].ToString()));
            }
            cmd.Dispose();
            reader.Close();

            int j = 0;
            foreach (int i in ids)
            {
                AddNodes(treeNodes[j],i);
                j++;
            }
        }

        //查找子节点递归方法，传入当前节点及当前的sql语句
        public string FindChildType(TreeNode treeNode, string sql)
        {
            if (treeNode != goods_type_tvw.SelectedNode)
            {
                sql += " or type = '" + treeNode.Text + "'";
            }
            else
            {
                sql += "type = '" + treeNode.Text + "'";
            }

            if (treeNode.Nodes.Count == 0)
            {
                return sql;
            }

            foreach (TreeNode node in treeNode.Nodes)
            {
                sql = FindChildType(node, sql);
            }

            return sql;
        }

        //商品分类树节点双击事件
        private void goods_type_tvw_DoubleClick(object sender, EventArgs e)
        {
            //如果正在选择商品分类
            if (isSelectingType)
            {
                //如果不是在编辑商品信息
                if (!isModifyingGoods)
                {
                    //设置新增商品窗口的已选择节点为当前选择的节点，打开新增商品窗口，关闭本窗口
                    CreateGoods createGoods = (CreateGoods)this.Owner;
                    createGoods.selectedGoodsTypeNode = goods_type_tvw.SelectedNode;
                    createGoods.Show();
                    this.Dispose();
                }
                //如果是在编辑商品信息
                else
                {
                    //设置编辑商品信息窗口的已选择节点为当前选择的节点，打开编辑商品信息窗口，关闭本窗口
                    ModifyGoodsInfo modifyGoodsInfo = (ModifyGoodsInfo)this.Owner;
                    modifyGoodsInfo.selectedGoodsTypeNode = goods_type_tvw.SelectedNode;
                    modifyGoodsInfo.Show();
                    this.Dispose();
                }
            }

        }

        //添加子节点按钮点击事件
        private void create_child_type_btn_Click(object sender, EventArgs e)
        {
            //确保商品分类已选择
            if (goods_type_tvw.SelectedNode == null)
            {
                MessageBox.Show("请先选择一个分类！");
                return;
            }

            //向当前选择的节点添加一个子节点，默认名称为新增分类，并修改当前选择的节点为新增的节点
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "新增分类";
            goods_type_tvw.SelectedNode.Nodes.Add(treeNode);
            goods_type_tvw.SelectedNode = treeNode;

            //设置是否正在创建节点为真
            isCreateNode = true;
        }

        //删除分类按钮点击事件
        private void delete_type_btn_Click(object sender, EventArgs e)
        {
            //设置根节点不能被删除
            if (goods_type_tvw.SelectedNode == goods_type_tvw.Nodes[0] || goods_type_tvw.SelectedNode == goods_type_tvw.Nodes[1])
            {
                MessageBox.Show("该分类不能被删除！");
                return;
            }

            //弹出确认删除对话框
            MessageBoxButtons messbutton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("将删除分类及其所有子分类，" + LoadForm.TextList[81], LoadForm.TextList[63], messbutton);
            if (dr == DialogResult.OK)
            {
                //如果不是正在创建节点
                if (!isCreateNode)
                {
                    //根据选择节点的名称向数据库查询id
                    int id = 0;
                    string sql = ("select id from goods_type where name = '" + goods_type_tvw.SelectedNode.Text + "'");
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = int.Parse(reader[0].ToString());
                    }
                    cmd.Dispose();
                    reader.Close();

                    //调用FindChindType方法，传入当前选择的节点和当前的sql语句，修改所有分类等于要被删除分类的已有商品的分类为计次商品或者非计次商品
                    sql = ("update goods set type = if(stock_num = -1,'计次商品','非计次商品') where (");
                    sql = FindChildType(goods_type_tvw.SelectedNode, sql);
                    sql += ")";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteScalar();
                    sql = ("delete from goods_type where pid = '" + id + "'");
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteScalar();
                    sql = ("delete from goods_type where id = '" + id + "'");
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteScalar();

                    MessageBox.Show(LoadForm.TextList[82]);

                    //设置goods_type表自增的主键id从0开始(实际值为当前最大值加1)
                    sql = ("alter table goods_type auto_increment = 0");
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteScalar();
                }
                //如果是在创建节点，修改是否正在创建节点为假
                else
                {
                    isCreateNode = false;
                }
                //从商品分类树中移除当前选择的节点
                goods_type_tvw.SelectedNode.Remove();
            }
        }

        //确定按钮点击事件
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            int pid = 0;

            //如果填写的父分类名称不为计次商品或者非计次商品
            if (parent_type_tbx.Text != goods_type_tvw.Nodes[0].Text && parent_type_tbx.Text != goods_type_tvw.Nodes[1].Text)
            {
                //确保填写的父分类存在
                cmd.CommandText = "select count(*) from goods_type where binary name = '" + parent_type_tbx.Text + "'";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    MessageBox.Show("填写的父分类不存在！");
                    cmd.Dispose();
                    return;
                }
            }
            //否则
            else
            {
                //如果填写的父分类名称是计次商品，设置pid为1
                if (parent_type_tbx.Text == goods_type_tvw.Nodes[0].Text)
                {
                    pid = 1;
                }
                //如果填写的父分类名称是非计次商品，设置pid为2
                if (parent_type_tbx.Text == goods_type_tvw.Nodes[1].Text)
                {
                    pid = 2;
                }
            }

            //确保分类名称不为空
            if (type_name_txb.Text == "")
            {
                MessageBox.Show("分类名称不能为空！");
                return;
            }

            //根据填写的父分类名称查询父分类id
            string sql = "select id from goods_type where name = '" + parent_type_tbx.Text + "'";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //设置pid为查询出的父分类id
                pid = int.Parse(reader[0].ToString());
            }
            cmd.Dispose();
            reader.Close();

            //如果正在修改节点信息
            if (isModifyNode)
            {
                //根据当前选择的节点查询选择的商品分类的id
                int id = 0;
                sql = "select id from goods_type where name = '" + goods_type_tvw.SelectedNode.Text + "'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                cmd.Dispose();
                reader.Close();

                //根据得到的父分类id，填写的分类名称和当前选择分类的id，更新数据库goods_type表，修改分类信息
                sql = "update goods_type set pid = '" + pid + "',name = '" + type_name_txb.Text + "' where id = '" + id + "'";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();

                MessageBox.Show("修改成功！");
                isModifyNode = false;
            }

            //如果正在创建节点
            if (isCreateNode)
            {
                //确保创建的节点不重复
                cmd.CommandText = "select count(*) from goods_type where binary name = '" + type_name_txb.Text + "'";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    MessageBox.Show("该分类已存在！");
                    cmd.Dispose();
                    return;
                }
                
                //根据获得的pid，填写的分类名称向数据库goods_type表插入数据，完成分类创建
                sql = "insert into goods_type (id,pid,name) values ('0','" + pid + "','" + type_name_txb.Text + "')";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("创建成功！");
                isCreateNode = false;
            }

            //刷新商品分类树
            goods_type_tvw.Nodes[0].Nodes.Clear();
            goods_type_tvw.Nodes[1].Nodes.Clear();
            AddNodes(goods_type_tvw.Nodes[0], 1);
            AddNodes(goods_type_tvw.Nodes[1], 2);
            goods_type_tvw.ExpandAll();
            //如果当前选择的节点是根节点，设置父分类名称为无、分类名称为当前选择的分类名称，且禁止修改
            if (goods_type_tvw.SelectedNode.Parent == null)
            {
                parent_type_tbx.Text = "无";
                type_name_txb.Text = goods_type_tvw.SelectedNode.Text;
                parent_type_tbx.Enabled = false;
                type_name_txb.Enabled = false;
            }
            return;
        }

        //更改商品分类树选择节点事件
        private void goods_type_tvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //如果当前选择的节点是根节点，设置父分类名称为无、分类名称为当前选择的分类名称，且禁止修改
            if (goods_type_tvw.SelectedNode.Parent == null)
            {
                parent_type_tbx.Text = "无";
                type_name_txb.Text = goods_type_tvw.SelectedNode.Text;
                parent_type_tbx.Enabled = false;
                type_name_txb.Enabled = false;
            }
            //否则，允许修改父分类名称、分类名称并分别设置其内容为选择节点的父分类名称、选择节点的分类名称
            else
            {
                parent_type_tbx.Enabled = true;
                type_name_txb.Enabled = true;
                parent_type_tbx.Text = goods_type_tvw.SelectedNode.Parent.Text;
                type_name_txb.Text = goods_type_tvw.SelectedNode.Text;
            }
        }

        //即将选择商品分类树某个节点之前事件
        private void goods_type_tvw_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //如果未选择节点或选择的为根节点，结束运行
            if (goods_type_tvw.SelectedNode == null || goods_type_tvw.SelectedNode.Parent == null)
            {
                return;
            }

            //如果正在编辑节点信息或正在创建节点，则禁止选择节点
            if (isModifyNode || isCreateNode)
            {
                MessageBox.Show("当前更改尚未保存！");
                e.Cancel = true;
                return;
            }
        }

        //父商品分类文本内容改变事件
        private void parent_type_tbx_TextChanged(object sender, EventArgs e)
        {
            //如果正在创建节点或选择的为根节点，结束运行
            if (isCreateNode)
            {
                return;
            }

            if (goods_type_tvw.SelectedNode.Parent == null)
            {
                return;
            }

            //如果当前选择节点的名称和父商品分类文本的内容不一致，则设置正在编辑节点为真
            if (goods_type_tvw.SelectedNode.Parent.Text != parent_type_tbx.Text)
            {
                isModifyNode = true;
            }
            //否则设置其为假
            else
            {
                isModifyNode = false;
            }
        }

        //商品分类文本内容改变事件
        private void type_name_txb_TextChanged(object sender, EventArgs e)
        {
            //如果选节点为空或正在创建节点，结束运行
            if (goods_type_tvw.SelectedNode == null || isCreateNode)
            {
                return;
            }

            //如果当前选择节点的名称和商品分类文本的内容不一致，则设置正在编辑节点为真
            if (goods_type_tvw.SelectedNode.Text != type_name_txb.Text)
            {
                isModifyNode = true;
            }
            else
            {
                isModifyNode = false;
            }
        }
    }
}

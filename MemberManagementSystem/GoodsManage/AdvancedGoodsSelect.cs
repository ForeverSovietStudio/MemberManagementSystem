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

namespace MemberManagementSystem.GoodsManage
{
    public partial class AdvancedGoodsSelect : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public AdvancedGoodsSelect()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);

            conn = Program.ConDataBase();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            by_condition_cbb.Text = by_condition_cbb.Items[0].ToString();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT g.id, g.`name`, g.type, g.stock_num, g.sold_num, g.sell_price, g.purchase_price, g.stock_time, s.`name` as sName FROM goods as g, supplier as s WHERE g.supplier_id = s.id ";

            switch (by_condition_cbb.SelectedIndex)
            {
                case 0:
                    sql += "and g.stock_num between '" + condition_1_txb.Text + "' and '" + condition_2_txb.Text + "'";
                    break;
                case 1:
                    sql += "and g.sold_num between '" + condition_1_txb.Text + "' and '" + condition_2_txb.Text + "'";
                    break;
            }

            GoodsList goodsList = (GoodsList)this.Owner;
            goodsList.goods_list_ltv.Items.Clear();
            goodsList.SelectGoods(sql);
            goodsList.Show();
            this.Dispose();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void condition_1_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender,e,1);
        }

        private void condition_2_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadForm.LimitInput(sender, e, 1);
        }
    }
}

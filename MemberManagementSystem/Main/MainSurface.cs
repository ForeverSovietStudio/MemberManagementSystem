using MemberManagementSystem.GoodsManage;
using MemberManagementSystem.Init;
using MemberManagementSystem.UserConsume;
using MemberManagementSystem.UserManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberManagementSystem.Main
{
    public partial class MainSurface : Form
    {
        public MainSurface()
        {
            InitializeComponent();

            LoadForm.LoadText(this);
        }

        private void user_manage_btn_Click(object sender, EventArgs e)
        {
            user_manage_pan.BringToFront();
        }

        private void goods_manage_btn_Click(object sender, EventArgs e)
        {
            goods_manage_pan.BringToFront();
        }

        private void user_consume_btn_Click(object sender, EventArgs e)
        {
            user_consume_pan.BringToFront();
        }

        private void stat_report_btn_Click(object sender, EventArgs e)
        {
            stat_report_pan.BringToFront();
        }

        private void sys_settings_btn_Click(object sender, EventArgs e)
        {
            sys_settings_pan.BringToFront();
        }

        private void create_user_btn_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }

        private void user_list_btn_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.Show();
        }

        private void user_charge_btn_Click(object sender, EventArgs e)
        {
            UserCharge userCharge = new UserCharge();
            userCharge.Show();
        }

        private void user_charge_count_btn_Click(object sender, EventArgs e)
        {
            UserChargeCount userChargeCount = new UserChargeCount();
            userChargeCount.Show();
        }

        private void import_info_btn_Click(object sender, EventArgs e)
        {
            ImportInfo importInfo = new ImportInfo();
            importInfo.Show();
        }

        private void bat_create_card_btn_Click(object sender, EventArgs e)
        {
            BatCreateCard batCreateCard = new BatCreateCard();
            batCreateCard.Show();
        }

        private void set_rank_Click(object sender, EventArgs e)
        {
            SetRank setRank = new SetRank();
            setRank.Show();
        }

        private void create_goods_btn_Click(object sender, EventArgs e)
        {
            CreateGoods createGoods = new CreateGoods();
            createGoods.Show();
        }

        private void goods_list_btn_Click(object sender, EventArgs e)
        {
            GoodsList goodsList = new GoodsList();
            goodsList.Show();
        }

        private void package_list_btn_Click(object sender, EventArgs e)
        {
            PackageList packageList = new PackageList();
            packageList.Show();
        }

        private void view_stock_btn_Click(object sender, EventArgs e)
        {
            ViewStock viewStock = new ViewStock();
            viewStock.Show();
        }

        private void purchase_return_btn_Click(object sender, EventArgs e)
        {
            PurchaseReturn purchaseReturn = new PurchaseReturn();
            purchaseReturn.Show();
        }

        private void set_goods_type_btn_Click(object sender, EventArgs e)
        {
            SetGoodsType setGoodsType = new SetGoodsType();
            setGoodsType.Show();
        }

        private void supplier_manage_btn_Click(object sender, EventArgs e)
        {
            SupplierManage supplierManage = new SupplierManage();
            supplierManage.Show();
        }

        private void bat_import_goods_btn_Click(object sender, EventArgs e)
        {
            BatImportGoods batImportGoods = new BatImportGoods();
            batImportGoods.Show();
        }

        private void consume_goods_btn_Click(object sender, EventArgs e)
        {
            ConsumeGoods consumeGoods = new ConsumeGoods();
            consumeGoods.Show();
        }

        private void consume_count_btn_Click(object sender, EventArgs e)
        {
            ConsumeCount consumeCount = new ConsumeCount();
            consumeCount.Show();
        }

        private void fast_consume_btn_Click(object sender, EventArgs e)
        {
            FastConsume fastConsume = new FastConsume();
            fastConsume.Show();
        }

        private void consume_history_btn_Click(object sender, EventArgs e)
        {
            ConsumeHistory consumeHistory = new ConsumeHistory();
            consumeHistory.Show();
        }

        private void consume_return_btn_Click(object sender, EventArgs e)
        {
            ConsumeReturn consumeReturn = new ConsumeReturn();
            consumeReturn.Show();
        }
    }
}

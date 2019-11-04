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
            createUser.ShowDialog();
        }

        private void user_list_btn_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.ShowDialog();
        }

        private void user_charge_btn_Click(object sender, EventArgs e)
        {
            UserCharge userCharge = new UserCharge();
            userCharge.ShowDialog();
        }

        private void user_charge_count_btn_Click(object sender, EventArgs e)
        {
            UserChargeCount userChargeCount = new UserChargeCount();
            userChargeCount.ShowDialog();
        }

        private void import_info_btn_Click(object sender, EventArgs e)
        {
            ImportInfo importInfo = new ImportInfo();
            importInfo.ShowDialog();
        }

        private void bat_create_card_btn_Click(object sender, EventArgs e)
        {
            BatCreateCard batCreateCard = new BatCreateCard();
            batCreateCard.ShowDialog();
        }

        private void set_rank_Click(object sender, EventArgs e)
        {
            SetRank setRank = new SetRank();
            setRank.ShowDialog();
        }

        private void create_goods_btn_Click(object sender, EventArgs e)
        {
            CreateGoods createGoods = new CreateGoods();
            createGoods.ShowDialog();
        }

        private void goods_list_btn_Click(object sender, EventArgs e)
        {
            GoodsList goodsList = new GoodsList();
            goodsList.ShowDialog();
        }

        private void package_list_btn_Click(object sender, EventArgs e)
        {
            PackageList packageList = new PackageList();
            packageList.ShowDialog();
        }

        private void view_stock_btn_Click(object sender, EventArgs e)
        {
            ViewStock viewStock = new ViewStock();
            viewStock.ShowDialog();
        }

        private void purchase_return_btn_Click(object sender, EventArgs e)
        {
            PurchaseReturn purchaseReturn = new PurchaseReturn();
            purchaseReturn.ShowDialog();
        }

        private void set_goods_type_btn_Click(object sender, EventArgs e)
        {
            SetGoodsType setGoodsType = new SetGoodsType();
            setGoodsType.ShowDialog();
        }

        private void supplier_manage_btn_Click(object sender, EventArgs e)
        {
            SupplierManage supplierManage = new SupplierManage();
            supplierManage.ShowDialog();
        }

        private void bat_import_goods_btn_Click(object sender, EventArgs e)
        {
            BatImportGoods batImportGoods = new BatImportGoods();
            batImportGoods.ShowDialog();
        }

        private void consume_goods_btn_Click(object sender, EventArgs e)
        {
            ConsumeGoods consumeGoods = new ConsumeGoods();
            consumeGoods.ShowDialog();
        }

        private void consume_count_btn_Click(object sender, EventArgs e)
        {
            ConsumeCount consumeCount = new ConsumeCount();
            consumeCount.ShowDialog();
        }

        private void fast_consume_btn_Click(object sender, EventArgs e)
        {
            FastConsume fastConsume = new FastConsume();
            fastConsume.ShowDialog();
        }

        private void consume_history_btn_Click(object sender, EventArgs e)
        {
            ConsumeHistory consumeHistory = new ConsumeHistory();
            consumeHistory.ShowDialog();
        }

        private void consume_return_btn_Click(object sender, EventArgs e)
        {
            ConsumeReturn consumeReturn = new ConsumeReturn();
            consumeReturn.ShowDialog();
        }
    }
}

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

/// <summary>
/// 主界面
/// </summary>

namespace MemberManagementSystem.Main
{
    public partial class MainSurface : Form
    {
        public MainSurface()
        {
            InitializeComponent();

            this.Text = LoadForm.TextList[int.Parse(this.Tag.ToString())];
            LoadForm.LoadText(this);
        }

        //会员管理按钮
        private void user_manage_btn_Click(object sender, EventArgs e)
        {
            user_manage_pan.BringToFront();
        }

        //商品管理按钮
        private void goods_manage_btn_Click(object sender, EventArgs e)
        {
            goods_manage_pan.BringToFront();
        }

        //会员消费按钮
        private void user_consume_btn_Click(object sender, EventArgs e)
        {
            user_consume_pan.BringToFront();
        }

        //统计报表按钮
        private void stat_report_btn_Click(object sender, EventArgs e)
        {
            stat_report_pan.BringToFront();
        }

        //系统设置按钮
        private void sys_settings_btn_Click(object sender, EventArgs e)
        {
            sys_settings_pan.BringToFront();
        }

        //办理会员功能
        private void create_user_btn_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        //会员列表功能
        private void user_list_btn_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.ShowDialog();
        }

        //资料导入功能
        private void import_info_btn_Click(object sender, EventArgs e)
        {
            ImportInfo importInfo = new ImportInfo();
            importInfo.ShowDialog();
        }

        //批量开卡功能
        private void bat_create_card_btn_Click(object sender, EventArgs e)
        {
            BatCreateCard batCreateCard = new BatCreateCard();
            batCreateCard.ShowDialog();
        }

        //等级设置功能
        private void set_rank_Click(object sender, EventArgs e)
        {
            SetRank setRank = new SetRank();
            setRank.ShowDialog();
        }

        //新增商品功能
        private void create_goods_btn_Click(object sender, EventArgs e)
        {
            CreateGoods createGoods = new CreateGoods();
            createGoods.ShowDialog();
        }

        //商品列表功能
        private void goods_list_btn_Click(object sender, EventArgs e)
        {
            GoodsList goodsList = new GoodsList();
            goodsList.ShowDialog();
        }

        //套餐列表功能
        private void package_list_btn_Click(object sender, EventArgs e)
        {
            PackageList packageList = new PackageList();
            packageList.ShowDialog();
        }

        //库存盘点功能
        private void view_stock_btn_Click(object sender, EventArgs e)
        {
            ViewStock viewStock = new ViewStock();
            viewStock.ShowDialog();
        }

        //进货退货功能
        private void purchase_return_btn_Click(object sender, EventArgs e)
        {
            PurchaseReturn purchaseReturn = new PurchaseReturn();
            purchaseReturn.ShowDialog();
        }

        //商品分类设置功能
        private void set_goods_type_btn_Click(object sender, EventArgs e)
        {
            SetGoodsType setGoodsType = new SetGoodsType(false);
            setGoodsType.ShowDialog();
        }

        //供应商管理功能
        private void supplier_manage_btn_Click(object sender, EventArgs e)
        {
            SupplierManage supplierManage = new SupplierManage(false);
            supplierManage.ShowDialog();
        }

        //商品批量导入功能
        private void bat_import_goods_btn_Click(object sender, EventArgs e)
        {
            BatImportGoods batImportGoods = new BatImportGoods();
            batImportGoods.ShowDialog();
        }

        //商品消费功能
        private void consume_goods_btn_Click(object sender, EventArgs e)
        {
            ConsumeGoods consumeGoods = new ConsumeGoods();
            consumeGoods.ShowDialog();
        }

        //计次消费功能
        private void consume_count_btn_Click(object sender, EventArgs e)
        {
            ConsumeCount consumeCount = new ConsumeCount();
            consumeCount.ShowDialog();
        }

        //快速消费功能
        private void fast_consume_btn_Click(object sender, EventArgs e)
        {
            FastConsume fastConsume = new FastConsume();
            fastConsume.ShowDialog();
        }

        //消费历史功能
        private void consume_history_btn_Click(object sender, EventArgs e)
        {
            ConsumeHistory consumeHistory = new ConsumeHistory();
            consumeHistory.ShowDialog();
        }

        //消费退货功能
        private void consume_return_btn_Click(object sender, EventArgs e)
        {
            ConsumeReturn consumeReturn = new ConsumeReturn();
            consumeReturn.ShowDialog();
        }
    }
}

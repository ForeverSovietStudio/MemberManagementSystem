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
            //user_manage_pan.BringToFront();
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
    }
}

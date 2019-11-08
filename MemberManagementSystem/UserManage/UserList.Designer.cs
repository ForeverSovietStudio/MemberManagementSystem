namespace MemberManagementSystem.UserManage
{
    partial class UserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("会员等级");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("会员状态");
            this.user_list_ltv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_charge_balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_charge_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.register_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_charge_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expired_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.by_sex_cbb = new System.Windows.Forms.ComboBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.advanced_select_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.by_tel_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.by_name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.charge_btn = new System.Windows.Forms.Button();
            this.by_type_tvw = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_list_ltv
            // 
            this.user_list_ltv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_list_ltv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.sex,
            this.tel,
            this.total_charge_balance,
            this.balance,
            this.total_num,
            this.total_charge_num,
            this.user_rank,
            this.user_status,
            this.register_time,
            this.last_charge_time,
            this.expired_time,
            this.remarks});
            this.user_list_ltv.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_list_ltv.FullRowSelect = true;
            this.user_list_ltv.GridLines = true;
            this.user_list_ltv.HideSelection = false;
            this.user_list_ltv.Location = new System.Drawing.Point(225, 81);
            this.user_list_ltv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_list_ltv.Name = "user_list_ltv";
            this.user_list_ltv.Size = new System.Drawing.Size(851, 600);
            this.user_list_ltv.TabIndex = 0;
            this.user_list_ltv.UseCompatibleStateImageBehavior = false;
            this.user_list_ltv.View = System.Windows.Forms.View.Details;
            this.user_list_ltv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.user_list_ltv_ColumnClick);
            this.user_list_ltv.DoubleClick += new System.EventHandler(this.user_list_ltv_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "姓名";
            this.name.Width = 100;
            // 
            // sex
            // 
            this.sex.Text = "性别";
            // 
            // tel
            // 
            this.tel.Text = "联系方式";
            this.tel.Width = 200;
            // 
            // total_charge_balance
            // 
            this.total_charge_balance.Text = "总消费金额";
            this.total_charge_balance.Width = 140;
            // 
            // balance
            // 
            this.balance.Text = "账户余额";
            this.balance.Width = 115;
            // 
            // total_num
            // 
            this.total_num.Text = "剩余可消费次数";
            this.total_num.Width = 180;
            // 
            // total_charge_num
            // 
            this.total_charge_num.Text = "已消费次数";
            this.total_charge_num.Width = 160;
            // 
            // user_rank
            // 
            this.user_rank.Text = "用户等级";
            this.user_rank.Width = 120;
            // 
            // user_status
            // 
            this.user_status.Text = "用户状态";
            this.user_status.Width = 120;
            // 
            // register_time
            // 
            this.register_time.Text = "注册时间";
            this.register_time.Width = 120;
            // 
            // last_charge_time
            // 
            this.last_charge_time.Text = "上次消费时间";
            this.last_charge_time.Width = 120;
            // 
            // expired_time
            // 
            this.expired_time.Text = "账户过期时间";
            this.expired_time.Width = 120;
            // 
            // remarks
            // 
            this.remarks.Text = "备注";
            this.remarks.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.by_sex_cbb);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.advanced_select_btn);
            this.groupBox1.Controls.Add(this.select_btn);
            this.groupBox1.Controls.Add(this.by_tel_txb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.by_name_txb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1063, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "67";
            // 
            // by_sex_cbb
            // 
            this.by_sex_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.by_sex_cbb.FormattingEnabled = true;
            this.by_sex_cbb.Items.AddRange(new object[] {
            "男",
            "女",
            " "});
            this.by_sex_cbb.Location = new System.Drawing.Point(299, 22);
            this.by_sex_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_sex_cbb.Name = "by_sex_cbb";
            this.by_sex_cbb.Size = new System.Drawing.Size(69, 28);
            this.by_sex_cbb.TabIndex = 20;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(799, 23);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(113, 30);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Tag = "72";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Tag = "69";
            this.label3.Text = "lbl";
            // 
            // advanced_select_btn
            // 
            this.advanced_select_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advanced_select_btn.Location = new System.Drawing.Point(938, 23);
            this.advanced_select_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advanced_select_btn.Name = "advanced_select_btn";
            this.advanced_select_btn.Size = new System.Drawing.Size(120, 30);
            this.advanced_select_btn.TabIndex = 5;
            this.advanced_select_btn.Tag = "73";
            this.advanced_select_btn.UseVisualStyleBackColor = true;
            this.advanced_select_btn.Click += new System.EventHandler(this.advanced_select_btn_Click);
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(705, 23);
            this.select_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(89, 30);
            this.select_btn.TabIndex = 4;
            this.select_btn.Tag = "71";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // by_tel_txb
            // 
            this.by_tel_txb.Location = new System.Drawing.Point(504, 22);
            this.by_tel_txb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_tel_txb.Name = "by_tel_txb";
            this.by_tel_txb.Size = new System.Drawing.Size(196, 30);
            this.by_tel_txb.TabIndex = 3;
            this.by_tel_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.by_tel_txb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Tag = "70";
            this.label2.Text = "lbl";
            // 
            // by_name_txb
            // 
            this.by_name_txb.Location = new System.Drawing.Point(105, 22);
            this.by_name_txb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_name_txb.Name = "by_name_txb";
            this.by_name_txb.Size = new System.Drawing.Size(100, 30);
            this.by_name_txb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "68";
            this.label1.Text = "lbl";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.charge_btn);
            this.groupBox2.Controls.Add(this.by_type_tvw);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(199, 598);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "74";
            // 
            // charge_btn
            // 
            this.charge_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.charge_btn.Location = new System.Drawing.Point(12, 552);
            this.charge_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charge_btn.Name = "charge_btn";
            this.charge_btn.Size = new System.Drawing.Size(168, 32);
            this.charge_btn.TabIndex = 1;
            this.charge_btn.Tag = "26";
            this.charge_btn.UseVisualStyleBackColor = true;
            this.charge_btn.Click += new System.EventHandler(this.charge_btn_Click);
            // 
            // by_type_tvw
            // 
            this.by_type_tvw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.by_type_tvw.Location = new System.Drawing.Point(12, 31);
            this.by_type_tvw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_type_tvw.Name = "by_type_tvw";
            treeNode23.Name = "节点0";
            treeNode23.Text = "会员等级";
            treeNode24.Name = "节点1";
            treeNode24.Text = "会员状态";
            this.by_type_tvw.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            this.by_type_tvw.Size = new System.Drawing.Size(168, 503);
            this.by_type_tvw.TabIndex = 0;
            this.by_type_tvw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.by_type_tvw_AfterSelect);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.user_list_ltv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "25";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView user_list_ltv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader total_charge_balance;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.ColumnHeader total_num;
        private System.Windows.Forms.ColumnHeader total_charge_num;
        private System.Windows.Forms.ColumnHeader user_rank;
        private System.Windows.Forms.ColumnHeader user_status;
        private System.Windows.Forms.ColumnHeader register_time;
        private System.Windows.Forms.ColumnHeader last_charge_time;
        private System.Windows.Forms.ColumnHeader expired_time;
        private System.Windows.Forms.ColumnHeader remarks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox by_tel_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox by_name_txb;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button advanced_select_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView by_type_tvw;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.Button charge_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.ComboBox by_sex_cbb;
    }
}
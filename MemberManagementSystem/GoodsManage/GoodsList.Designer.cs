namespace MemberManagementSystem.GoodsManage
{
    partial class GoodsList
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("计次商品");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("非计次商品");
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.by_type_tvw = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.advanced_select_btn = new System.Windows.Forms.Button();
            this.by_supplier_name_txb = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.by_goods_name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goods_list_ltv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sold_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sell_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchase_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplier_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.by_type_tvw);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(258, 712);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "74";
            // 
            // by_type_tvw
            // 
            this.by_type_tvw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.by_type_tvw.Location = new System.Drawing.Point(6, 37);
            this.by_type_tvw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_type_tvw.Name = "by_type_tvw";
            treeNode7.Name = "节点0";
            treeNode7.Text = "计次商品";
            treeNode8.Name = "节点1";
            treeNode8.Text = "非计次商品";
            this.by_type_tvw.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.by_type_tvw.Size = new System.Drawing.Size(246, 671);
            this.by_type_tvw.TabIndex = 0;
            this.by_type_tvw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.by_type_tvw_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.advanced_select_btn);
            this.groupBox1.Controls.Add(this.by_supplier_name_txb);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.select_btn);
            this.groupBox1.Controls.Add(this.by_goods_name_txb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1274, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "105";
            // 
            // advanced_select_btn
            // 
            this.advanced_select_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advanced_select_btn.Location = new System.Drawing.Point(1133, 25);
            this.advanced_select_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advanced_select_btn.Name = "advanced_select_btn";
            this.advanced_select_btn.Size = new System.Drawing.Size(135, 36);
            this.advanced_select_btn.TabIndex = 10;
            this.advanced_select_btn.Tag = "73";
            this.advanced_select_btn.UseVisualStyleBackColor = true;
            this.advanced_select_btn.Click += new System.EventHandler(this.advanced_select_btn_Click);
            // 
            // by_supplier_name_txb
            // 
            this.by_supplier_name_txb.Location = new System.Drawing.Point(532, 25);
            this.by_supplier_name_txb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_supplier_name_txb.Name = "by_supplier_name_txb";
            this.by_supplier_name_txb.Size = new System.Drawing.Size(200, 35);
            this.by_supplier_name_txb.TabIndex = 9;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(844, 25);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(143, 36);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Tag = "72";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 6;
            this.label3.Tag = "107";
            this.label3.Text = "lbl";
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(738, 25);
            this.select_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(100, 36);
            this.select_btn.TabIndex = 4;
            this.select_btn.Tag = "71";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // by_goods_name_txb
            // 
            this.by_goods_name_txb.Location = new System.Drawing.Point(154, 25);
            this.by_goods_name_txb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_goods_name_txb.Name = "by_goods_name_txb";
            this.by_goods_name_txb.Size = new System.Drawing.Size(200, 35);
            this.by_goods_name_txb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Tag = "106";
            this.label1.Text = "lbl";
            // 
            // goods_list_ltv
            // 
            this.goods_list_ltv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goods_list_ltv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.type,
            this.stock_num,
            this.sold_num,
            this.sell_price,
            this.purchase_price,
            this.stock_time,
            this.supplier_name});
            this.goods_list_ltv.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_list_ltv.FullRowSelect = true;
            this.goods_list_ltv.GridLines = true;
            this.goods_list_ltv.HideSelection = false;
            this.goods_list_ltv.Location = new System.Drawing.Point(276, 75);
            this.goods_list_ltv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goods_list_ltv.MultiSelect = false;
            this.goods_list_ltv.Name = "goods_list_ltv";
            this.goods_list_ltv.Size = new System.Drawing.Size(1010, 708);
            this.goods_list_ltv.TabIndex = 6;
            this.goods_list_ltv.UseCompatibleStateImageBehavior = false;
            this.goods_list_ltv.View = System.Windows.Forms.View.Details;
            this.goods_list_ltv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.goods_list_ltv_ColumnClick);
            this.goods_list_ltv.DoubleClick += new System.EventHandler(this.goods_list_ltv_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 150;
            // 
            // type
            // 
            this.type.Text = "分类";
            this.type.Width = 150;
            // 
            // stock_num
            // 
            this.stock_num.Text = "库存数量";
            this.stock_num.Width = 150;
            // 
            // sold_num
            // 
            this.sold_num.Text = "已销售数量";
            this.sold_num.Width = 150;
            // 
            // sell_price
            // 
            this.sell_price.Text = "销售价格";
            this.sell_price.Width = 150;
            // 
            // purchase_price
            // 
            this.purchase_price.Text = "采购价格";
            this.purchase_price.Width = 120;
            // 
            // stock_time
            // 
            this.stock_time.Text = "入库时间";
            this.stock_time.Width = 120;
            // 
            // supplier_name
            // 
            this.supplier_name.Text = "供应商名称";
            this.supplier_name.Width = 150;
            // 
            // GoodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 798);
            this.Controls.Add(this.goods_list_ltv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GoodsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "32";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView by_type_tvw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.TextBox by_goods_name_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox by_supplier_name_txb;
        private System.Windows.Forms.Button advanced_select_btn;
        public System.Windows.Forms.ListView goods_list_ltv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader stock_num;
        private System.Windows.Forms.ColumnHeader sold_num;
        private System.Windows.Forms.ColumnHeader sell_price;
        private System.Windows.Forms.ColumnHeader purchase_price;
        private System.Windows.Forms.ColumnHeader stock_time;
        private System.Windows.Forms.ColumnHeader supplier_name;
    }
}
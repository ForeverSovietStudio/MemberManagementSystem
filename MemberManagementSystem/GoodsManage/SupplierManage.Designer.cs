namespace MemberManagementSystem.GoodsManage
{
    partial class SupplierManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.by_goods_name_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.by_tel_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.by_name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supplier_list_ltv = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.create_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_deal_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.create_supplier_gpb = new System.Windows.Forms.GroupBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.remarks_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tel_txb = new System.Windows.Forms.TextBox();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.create_supplier_gpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.select_btn);
            this.groupBox1.Controls.Add(this.by_goods_name_txb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.by_tel_txb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.by_name_txb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1286, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "108";
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_btn.Location = new System.Drawing.Point(1141, 22);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(139, 57);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Tag = "72";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(916, 22);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(139, 57);
            this.select_btn.TabIndex = 6;
            this.select_btn.Tag = "71";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // by_goods_name_txb
            // 
            this.by_goods_name_txb.Location = new System.Drawing.Point(765, 28);
            this.by_goods_name_txb.Name = "by_goods_name_txb";
            this.by_goods_name_txb.Size = new System.Drawing.Size(145, 35);
            this.by_goods_name_txb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 4;
            this.label3.Tag = "106";
            // 
            // by_tel_txb
            // 
            this.by_tel_txb.Location = new System.Drawing.Point(389, 28);
            this.by_tel_txb.Name = "by_tel_txb";
            this.by_tel_txb.Size = new System.Drawing.Size(222, 35);
            this.by_tel_txb.TabIndex = 3;
            this.by_tel_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.by_tel_txb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 2;
            this.label2.Tag = "70";
            this.label2.Text = "lbl";
            // 
            // by_name_txb
            // 
            this.by_name_txb.Location = new System.Drawing.Point(106, 28);
            this.by_name_txb.Name = "by_name_txb";
            this.by_name_txb.Size = new System.Drawing.Size(129, 35);
            this.by_name_txb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Tag = "68";
            this.label1.Text = "lbl";
            // 
            // supplier_list_ltv
            // 
            this.supplier_list_ltv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplier_list_ltv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.tel,
            this.address,
            this.create_time,
            this.last_deal_time,
            this.remarks});
            this.supplier_list_ltv.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.supplier_list_ltv.FullRowSelect = true;
            this.supplier_list_ltv.GridLines = true;
            this.supplier_list_ltv.HideSelection = false;
            this.supplier_list_ltv.Location = new System.Drawing.Point(12, 103);
            this.supplier_list_ltv.MultiSelect = false;
            this.supplier_list_ltv.Name = "supplier_list_ltv";
            this.supplier_list_ltv.Size = new System.Drawing.Size(1055, 663);
            this.supplier_list_ltv.TabIndex = 1;
            this.supplier_list_ltv.UseCompatibleStateImageBehavior = false;
            this.supplier_list_ltv.View = System.Windows.Forms.View.Details;
            this.supplier_list_ltv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.supplier_list_ltv_ColumnClick);
            this.supplier_list_ltv.DoubleClick += new System.EventHandler(this.supplier_list_ltv_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "姓名";
            this.name.Width = 120;
            // 
            // tel
            // 
            this.tel.Text = "联系方式";
            this.tel.Width = 180;
            // 
            // address
            // 
            this.address.Text = "地址";
            this.address.Width = 180;
            // 
            // create_time
            // 
            this.create_time.Text = "创建时间";
            this.create_time.Width = 120;
            // 
            // last_deal_time
            // 
            this.last_deal_time.Text = "上次交易时间";
            this.last_deal_time.Width = 120;
            // 
            // remarks
            // 
            this.remarks.Text = "备注";
            this.remarks.Width = 240;
            // 
            // create_supplier_gpb
            // 
            this.create_supplier_gpb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_supplier_gpb.Controls.Add(this.cancel_btn);
            this.create_supplier_gpb.Controls.Add(this.create_btn);
            this.create_supplier_gpb.Controls.Add(this.label7);
            this.create_supplier_gpb.Controls.Add(this.remarks_txb);
            this.create_supplier_gpb.Controls.Add(this.label6);
            this.create_supplier_gpb.Controls.Add(this.address_txb);
            this.create_supplier_gpb.Controls.Add(this.label5);
            this.create_supplier_gpb.Controls.Add(this.tel_txb);
            this.create_supplier_gpb.Controls.Add(this.name_txb);
            this.create_supplier_gpb.Controls.Add(this.label4);
            this.create_supplier_gpb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.create_supplier_gpb.Location = new System.Drawing.Point(1073, 103);
            this.create_supplier_gpb.Name = "create_supplier_gpb";
            this.create_supplier_gpb.Size = new System.Drawing.Size(225, 663);
            this.create_supplier_gpb.TabIndex = 2;
            this.create_supplier_gpb.TabStop = false;
            this.create_supplier_gpb.Tag = "109";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.Location = new System.Drawing.Point(6, 613);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(213, 44);
            this.cancel_btn.TabIndex = 10;
            this.cancel_btn.Tag = "55";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_btn.Location = new System.Drawing.Point(6, 559);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(213, 44);
            this.create_btn.TabIndex = 9;
            this.create_btn.Tag = "54";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(6, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 43);
            this.label7.TabIndex = 8;
            this.label7.Tag = "52";
            this.label7.Text = "lbl";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remarks_txb
            // 
            this.remarks_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remarks_txb.Location = new System.Drawing.Point(6, 377);
            this.remarks_txb.Multiline = true;
            this.remarks_txb.Name = "remarks_txb";
            this.remarks_txb.Size = new System.Drawing.Size(213, 159);
            this.remarks_txb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(6, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 43);
            this.label6.TabIndex = 6;
            this.label6.Tag = "110";
            this.label6.Text = "lbl";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address_txb
            // 
            this.address_txb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address_txb.Location = new System.Drawing.Point(6, 277);
            this.address_txb.Multiline = true;
            this.address_txb.Name = "address_txb";
            this.address_txb.Size = new System.Drawing.Size(213, 51);
            this.address_txb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 43);
            this.label5.TabIndex = 4;
            this.label5.Tag = "47";
            this.label5.Text = "lbl";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tel_txb
            // 
            this.tel_txb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tel_txb.Location = new System.Drawing.Point(6, 177);
            this.tel_txb.Name = "tel_txb";
            this.tel_txb.Size = new System.Drawing.Size(213, 35);
            this.tel_txb.TabIndex = 3;
            this.tel_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_txb_KeyPress);
            // 
            // name_txb
            // 
            this.name_txb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_txb.Location = new System.Drawing.Point(6, 77);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(213, 35);
            this.name_txb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 43);
            this.label4.TabIndex = 0;
            this.label4.Tag = "45";
            this.label4.Text = "lbl";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 778);
            this.Controls.Add(this.create_supplier_gpb);
            this.Controls.Add(this.supplier_list_ltv);
            this.Controls.Add(this.groupBox1);
            this.Name = "SupplierManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "37";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.create_supplier_gpb.ResumeLayout(false);
            this.create_supplier_gpb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox by_tel_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox by_name_txb;
        private System.Windows.Forms.TextBox by_goods_name_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button select_btn;
        public System.Windows.Forms.ListView supplier_list_ltv;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader create_time;
        private System.Windows.Forms.ColumnHeader last_deal_time;
        private System.Windows.Forms.ColumnHeader remarks;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.GroupBox create_supplier_gpb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel_txb;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address_txb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox remarks_txb;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}
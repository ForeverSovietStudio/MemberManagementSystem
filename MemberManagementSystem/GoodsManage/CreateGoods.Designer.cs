namespace MemberManagementSystem.GoodsManage
{
    partial class CreateGoods
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
            this.label1 = new System.Windows.Forms.Label();
            this.goods_name_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stock_num_txb = new System.Windows.Forms.TextBox();
            this.is_by_num_cbx = new System.Windows.Forms.CheckBox();
            this.sell_price_txb = new System.Windows.Forms.TextBox();
            this.purchase_price_txb = new System.Windows.Forms.TextBox();
            this.select_supplier_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.select_goods_type_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 0;
            this.label1.Tag = "96";
            this.label1.Text = "lbl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_name_txb
            // 
            this.goods_name_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_name_txb.Location = new System.Drawing.Point(174, 47);
            this.goods_name_txb.Name = "goods_name_txb";
            this.goods_name_txb.Size = new System.Drawing.Size(194, 35);
            this.goods_name_txb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(374, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 2;
            this.label2.Tag = "104";
            this.label2.Text = "lbl";
            // 
            // stock_num_txb
            // 
            this.stock_num_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stock_num_txb.Location = new System.Drawing.Point(174, 187);
            this.stock_num_txb.Name = "stock_num_txb";
            this.stock_num_txb.Size = new System.Drawing.Size(194, 35);
            this.stock_num_txb.TabIndex = 6;
            this.stock_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_num_txb_KeyPress);
            // 
            // is_by_num_cbx
            // 
            this.is_by_num_cbx.AutoSize = true;
            this.is_by_num_cbx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.is_by_num_cbx.Location = new System.Drawing.Point(378, 190);
            this.is_by_num_cbx.Name = "is_by_num_cbx";
            this.is_by_num_cbx.Size = new System.Drawing.Size(22, 21);
            this.is_by_num_cbx.TabIndex = 7;
            this.is_by_num_cbx.Tag = "100";
            this.is_by_num_cbx.UseVisualStyleBackColor = true;
            this.is_by_num_cbx.CheckedChanged += new System.EventHandler(this.is_by_num_cbx_CheckedChanged);
            // 
            // sell_price_txb
            // 
            this.sell_price_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sell_price_txb.Location = new System.Drawing.Point(174, 257);
            this.sell_price_txb.Name = "sell_price_txb";
            this.sell_price_txb.Size = new System.Drawing.Size(194, 35);
            this.sell_price_txb.TabIndex = 9;
            this.sell_price_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sell_price_txb_KeyPress);
            // 
            // purchase_price_txb
            // 
            this.purchase_price_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.purchase_price_txb.Location = new System.Drawing.Point(174, 327);
            this.purchase_price_txb.Name = "purchase_price_txb";
            this.purchase_price_txb.Size = new System.Drawing.Size(194, 35);
            this.purchase_price_txb.TabIndex = 11;
            this.purchase_price_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchase_price_txb_KeyPress);
            // 
            // select_supplier_btn
            // 
            this.select_supplier_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_supplier_btn.Location = new System.Drawing.Point(174, 388);
            this.select_supplier_btn.Name = "select_supplier_btn";
            this.select_supplier_btn.Size = new System.Drawing.Size(194, 54);
            this.select_supplier_btn.TabIndex = 13;
            this.select_supplier_btn.Tag = "98";
            this.select_supplier_btn.UseVisualStyleBackColor = true;
            this.select_supplier_btn.Click += new System.EventHandler(this.select_supplier_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.Location = new System.Drawing.Point(511, 489);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(139, 54);
            this.cancel_btn.TabIndex = 14;
            this.cancel_btn.Tag = "55";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm_btn.Location = new System.Drawing.Point(346, 489);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(139, 54);
            this.confirm_btn.TabIndex = 15;
            this.confirm_btn.Tag = "63";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // select_goods_type_btn
            // 
            this.select_goods_type_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_goods_type_btn.Location = new System.Drawing.Point(174, 105);
            this.select_goods_type_btn.Name = "select_goods_type_btn";
            this.select_goods_type_btn.Size = new System.Drawing.Size(194, 54);
            this.select_goods_type_btn.TabIndex = 16;
            this.select_goods_type_btn.Tag = "98";
            this.select_goods_type_btn.UseVisualStyleBackColor = true;
            this.select_goods_type_btn.Click += new System.EventHandler(this.select_goods_type_btn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 35);
            this.label3.TabIndex = 17;
            this.label3.Tag = "97";
            this.label3.Text = "lbl";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 35);
            this.label4.TabIndex = 18;
            this.label4.Tag = "99";
            this.label4.Text = "lbl";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 35);
            this.label5.TabIndex = 19;
            this.label5.Tag = "101";
            this.label5.Text = "lbl";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 35);
            this.label6.TabIndex = 20;
            this.label6.Tag = "102";
            this.label6.Text = "lbl";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 35);
            this.label7.TabIndex = 21;
            this.label7.Tag = "103";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 555);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select_goods_type_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.select_supplier_btn);
            this.Controls.Add(this.purchase_price_txb);
            this.Controls.Add(this.sell_price_txb);
            this.Controls.Add(this.is_by_num_cbx);
            this.Controls.Add(this.stock_num_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goods_name_txb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "31";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox goods_name_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stock_num_txb;
        private System.Windows.Forms.CheckBox is_by_num_cbx;
        private System.Windows.Forms.TextBox sell_price_txb;
        private System.Windows.Forms.TextBox purchase_price_txb;
        private System.Windows.Forms.Button select_supplier_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button select_goods_type_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
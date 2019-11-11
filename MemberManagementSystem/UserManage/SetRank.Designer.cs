namespace MemberManagementSystem.UserManage
{
    partial class SetRank
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
            this.label5 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.discount_rate_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rank_name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.user_rank_ltv = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.create_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.discount_rate_txb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rank_name_txb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 227);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "90";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(257, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(555, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "(此等级享受的折扣率,例如0.8表示打八折,1表示无折扣)";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(417, 159);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(139, 49);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Tag = "93";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(233, 159);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(139, 49);
            this.create_btn.TabIndex = 7;
            this.create_btn.Tag = "63";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(257, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(555, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "(等级名称不能重复)";
            // 
            // discount_rate_txb
            // 
            this.discount_rate_txb.Location = new System.Drawing.Point(130, 92);
            this.discount_rate_txb.Name = "discount_rate_txb";
            this.discount_rate_txb.Size = new System.Drawing.Size(121, 35);
            this.discount_rate_txb.TabIndex = 3;
            this.discount_rate_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discount_rate_txb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 2;
            this.label2.Tag = "92";
            this.label2.Text = "lbl";
            // 
            // rank_name_txb
            // 
            this.rank_name_txb.Location = new System.Drawing.Point(130, 28);
            this.rank_name_txb.Name = "rank_name_txb";
            this.rank_name_txb.Size = new System.Drawing.Size(121, 35);
            this.rank_name_txb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Tag = "91";
            this.label1.Text = "lbl";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.user_rank_ltv);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(22, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 346);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "94";
            // 
            // user_rank_ltv
            // 
            this.user_rank_ltv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_rank_ltv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.user_rank_ltv.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_rank_ltv.FullRowSelect = true;
            this.user_rank_ltv.GridLines = true;
            this.user_rank_ltv.HideSelection = false;
            this.user_rank_ltv.Location = new System.Drawing.Point(6, 27);
            this.user_rank_ltv.Name = "user_rank_ltv";
            this.user_rank_ltv.Size = new System.Drawing.Size(796, 313);
            this.user_rank_ltv.TabIndex = 0;
            this.user_rank_ltv.UseCompatibleStateImageBehavior = false;
            this.user_rank_ltv.View = System.Windows.Forms.View.Details;
            this.user_rank_ltv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.user_rank_ltv_ColumnClick);
            this.user_rank_ltv.DoubleClick += new System.EventHandler(this.user_rank_ltv_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "等级名称";
            this.columnHeader2.Width = 204;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "折扣比例";
            this.columnHeader3.Width = 184;
            // 
            // SetRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetRank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "30";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discount_rate_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rank_name_txb;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView user_rank_ltv;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
namespace MemberManagementSystem.GoodsManage
{
    partial class AdvancedGoodsSelect
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
            this.by_condition_cbb = new System.Windows.Forms.ComboBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.condition_1_txb = new System.Windows.Forms.TextBox();
            this.condition_2_txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // by_condition_cbb
            // 
            this.by_condition_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.by_condition_cbb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.by_condition_cbb.FormattingEnabled = true;
            this.by_condition_cbb.Items.AddRange(new object[] {
            "按库存数量:",
            "按销售数量:"});
            this.by_condition_cbb.Location = new System.Drawing.Point(53, 73);
            this.by_condition_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.by_condition_cbb.Name = "by_condition_cbb";
            this.by_condition_cbb.Size = new System.Drawing.Size(172, 32);
            this.by_condition_cbb.TabIndex = 18;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.Location = new System.Drawing.Point(375, 171);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(128, 53);
            this.cancel_btn.TabIndex = 17;
            this.cancel_btn.Tag = "55";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_btn.Location = new System.Drawing.Point(97, 171);
            this.select_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(128, 53);
            this.select_btn.TabIndex = 16;
            this.select_btn.Tag = "71";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(371, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 15;
            this.label4.Tag = "79";
            this.label4.Text = "lbl";
            // 
            // condition_1_txb
            // 
            this.condition_1_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.condition_1_txb.Location = new System.Drawing.Point(231, 70);
            this.condition_1_txb.Name = "condition_1_txb";
            this.condition_1_txb.Size = new System.Drawing.Size(134, 35);
            this.condition_1_txb.TabIndex = 19;
            this.condition_1_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.condition_1_txb_KeyPress);
            // 
            // condition_2_txb
            // 
            this.condition_2_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.condition_2_txb.Location = new System.Drawing.Point(417, 70);
            this.condition_2_txb.Name = "condition_2_txb";
            this.condition_2_txb.Size = new System.Drawing.Size(134, 35);
            this.condition_2_txb.TabIndex = 20;
            this.condition_2_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.condition_2_txb_KeyPress);
            // 
            // AdvancedGoodsSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 279);
            this.Controls.Add(this.condition_2_txb);
            this.Controls.Add(this.condition_1_txb);
            this.Controls.Add(this.by_condition_cbb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedGoodsSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "73";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox by_condition_cbb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox condition_1_txb;
        private System.Windows.Forms.TextBox condition_2_txb;
    }
}
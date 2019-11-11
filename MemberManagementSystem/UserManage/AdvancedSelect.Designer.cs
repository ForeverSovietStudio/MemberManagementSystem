namespace MemberManagementSystem.UserManage
{
    partial class AdvancedSelect
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
            this.time1_dtp = new System.Windows.Forms.DateTimePicker();
            this.time2_dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.time_cbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // time1_dtp
            // 
            this.time1_dtp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time1_dtp.Location = new System.Drawing.Point(274, 72);
            this.time1_dtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time1_dtp.Name = "time1_dtp";
            this.time1_dtp.Size = new System.Drawing.Size(164, 35);
            this.time1_dtp.TabIndex = 3;
            // 
            // time2_dtp
            // 
            this.time2_dtp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time2_dtp.Location = new System.Drawing.Point(485, 72);
            this.time2_dtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time2_dtp.Name = "time2_dtp";
            this.time2_dtp.Size = new System.Drawing.Size(164, 35);
            this.time2_dtp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(446, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 7;
            this.label4.Tag = "79";
            this.label4.Text = "lbl";
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_btn.Location = new System.Drawing.Point(165, 169);
            this.select_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(128, 53);
            this.select_btn.TabIndex = 10;
            this.select_btn.Tag = "71";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.Location = new System.Drawing.Point(450, 169);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(128, 53);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Tag = "55";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // time_cbb
            // 
            this.time_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_cbb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_cbb.FormattingEnabled = true;
            this.time_cbb.Items.AddRange(new object[] {
            "按注册时间:",
            "按过期时间:"});
            this.time_cbb.Location = new System.Drawing.Point(86, 74);
            this.time_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time_cbb.Name = "time_cbb";
            this.time_cbb.Size = new System.Drawing.Size(172, 32);
            this.time_cbb.TabIndex = 12;
            this.time_cbb.SelectedIndexChanged += new System.EventHandler(this.time_cbb_SelectedIndexChanged);
            // 
            // AdvancedSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 239);
            this.Controls.Add(this.time_cbb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.time2_dtp);
            this.Controls.Add(this.time1_dtp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "73";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker time1_dtp;
        private System.Windows.Forms.DateTimePicker time2_dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ComboBox time_cbb;
    }
}
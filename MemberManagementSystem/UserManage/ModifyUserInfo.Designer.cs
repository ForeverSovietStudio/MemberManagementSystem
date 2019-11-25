namespace MemberManagementSystem.UserManage
{
    partial class ModifyUserInfo
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
            this.sex_cbb = new System.Windows.Forms.ComboBox();
            this.remarks_txb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.expired_time_dtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.user_rank_cbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tel_txb = new System.Windows.Forms.TextBox();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.user_status_cbb = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sex_cbb
            // 
            this.sex_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex_cbb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex_cbb.FormattingEnabled = true;
            this.sex_cbb.Items.AddRange(new object[] {
            "男",
            "女",
            " "});
            this.sex_cbb.Location = new System.Drawing.Point(166, 110);
            this.sex_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sex_cbb.Name = "sex_cbb";
            this.sex_cbb.Size = new System.Drawing.Size(220, 32);
            this.sex_cbb.TabIndex = 32;
            // 
            // remarks_txb
            // 
            this.remarks_txb.Location = new System.Drawing.Point(423, 72);
            this.remarks_txb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remarks_txb.Multiline = true;
            this.remarks_txb.Name = "remarks_txb";
            this.remarks_txb.Size = new System.Drawing.Size(418, 393);
            this.remarks_txb.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(418, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 34);
            this.label8.TabIndex = 29;
            this.label8.Tag = "52";
            this.label8.Text = "lbl";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expired_time_dtp
            // 
            this.expired_time_dtp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.expired_time_dtp.Location = new System.Drawing.Point(166, 430);
            this.expired_time_dtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expired_time_dtp.Name = "expired_time_dtp";
            this.expired_time_dtp.Size = new System.Drawing.Size(220, 35);
            this.expired_time_dtp.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 34);
            this.label7.TabIndex = 27;
            this.label7.Tag = "51";
            this.label7.Text = "lbl";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_rank_cbb
            // 
            this.user_rank_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_rank_cbb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_rank_cbb.FormattingEnabled = true;
            this.user_rank_cbb.Location = new System.Drawing.Point(166, 270);
            this.user_rank_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_rank_cbb.Name = "user_rank_cbb";
            this.user_rank_cbb.Size = new System.Drawing.Size(220, 32);
            this.user_rank_cbb.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 34);
            this.label6.TabIndex = 25;
            this.label6.Tag = "50";
            this.label6.Text = "lbl";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 34);
            this.label3.TabIndex = 24;
            this.label3.Tag = "47";
            this.label3.Text = "lbl";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 34);
            this.label2.TabIndex = 23;
            this.label2.Tag = "46";
            this.label2.Text = "lbl";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tel_txb
            // 
            this.tel_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tel_txb.Location = new System.Drawing.Point(166, 190);
            this.tel_txb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tel_txb.Name = "tel_txb";
            this.tel_txb.Size = new System.Drawing.Size(220, 35);
            this.tel_txb.TabIndex = 22;
            this.tel_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_txb_KeyPress);
            // 
            // name_txb
            // 
            this.name_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_txb.Location = new System.Drawing.Point(166, 32);
            this.name_txb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(220, 35);
            this.name_txb.TabIndex = 21;
            this.name_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 20;
            this.label1.Tag = "45";
            this.label1.Text = "lbl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 34);
            this.label4.TabIndex = 33;
            this.label4.Tag = "64";
            this.label4.Text = "lbl";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm_btn.Location = new System.Drawing.Point(556, 487);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(129, 50);
            this.confirm_btn.TabIndex = 36;
            this.confirm_btn.Tag = "63";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.Location = new System.Drawing.Point(712, 487);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(129, 50);
            this.cancel_btn.TabIndex = 35;
            this.cancel_btn.Tag = "55";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // user_status_cbb
            // 
            this.user_status_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_status_cbb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_status_cbb.FormattingEnabled = true;
            this.user_status_cbb.Location = new System.Drawing.Point(166, 350);
            this.user_status_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_status_cbb.Name = "user_status_cbb";
            this.user_status_cbb.Size = new System.Drawing.Size(220, 32);
            this.user_status_cbb.TabIndex = 37;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete_btn.Location = new System.Drawing.Point(32, 487);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(173, 50);
            this.delete_btn.TabIndex = 38;
            this.delete_btn.Tag = "66";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // ModifyUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 563);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.user_status_cbb);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sex_cbb);
            this.Controls.Add(this.remarks_txb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.expired_time_dtp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.user_rank_cbb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tel_txb);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModifyUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "65";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sex_cbb;
        private System.Windows.Forms.TextBox remarks_txb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker expired_time_dtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox user_rank_cbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tel_txb;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ComboBox user_status_cbb;
        private System.Windows.Forms.Button delete_btn;
    }
}
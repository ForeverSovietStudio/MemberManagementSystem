namespace MemberManagementSystem.UserManage
{
    partial class ModifyUserRank
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
            this.rank_name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discount_rate_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rank_name_txb
            // 
            this.rank_name_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rank_name_txb.Location = new System.Drawing.Point(153, 35);
            this.rank_name_txb.Name = "rank_name_txb";
            this.rank_name_txb.Size = new System.Drawing.Size(169, 35);
            this.rank_name_txb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 9;
            this.label1.Tag = "91";
            this.label1.Text = "lbl";
            // 
            // discount_rate_txb
            // 
            this.discount_rate_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.discount_rate_txb.Location = new System.Drawing.Point(153, 114);
            this.discount_rate_txb.Name = "discount_rate_txb";
            this.discount_rate_txb.Size = new System.Drawing.Size(169, 35);
            this.discount_rate_txb.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 11;
            this.label2.Tag = "92";
            this.label2.Text = "lbl";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm_btn.Location = new System.Drawing.Point(33, 196);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(114, 43);
            this.confirm_btn.TabIndex = 13;
            this.confirm_btn.Tag = "63";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete_btn.Location = new System.Drawing.Point(208, 196);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(114, 43);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.Tag = "95";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // ModifyUserRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 269);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.discount_rate_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rank_name_txb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyUserRank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "94";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rank_name_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discount_rate_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}
namespace MemberManagementSystem.Init
{
    partial class Register
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_txb = new System.Windows.Forms.TextBox();
            this.account_lbl = new System.Windows.Forms.Label();
            this.account_txb = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txb = new System.Windows.Forms.TextBox();
            this.password_confirm_lbl = new System.Windows.Forms.Label();
            this.password_confirm_txb = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("宋体", 16F);
            this.username_lbl.Location = new System.Drawing.Point(144, 93);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(63, 33);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Tag = "10";
            this.username_lbl.Text = "lbl";
            // 
            // username_txb
            // 
            this.username_txb.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username_txb.Location = new System.Drawing.Point(362, 90);
            this.username_txb.Name = "username_txb";
            this.username_txb.Size = new System.Drawing.Size(288, 44);
            this.username_txb.TabIndex = 1;
            // 
            // account_lbl
            // 
            this.account_lbl.AutoSize = true;
            this.account_lbl.Font = new System.Drawing.Font("宋体", 16F);
            this.account_lbl.Location = new System.Drawing.Point(144, 166);
            this.account_lbl.Name = "account_lbl";
            this.account_lbl.Size = new System.Drawing.Size(63, 33);
            this.account_lbl.TabIndex = 2;
            this.account_lbl.Tag = "1";
            this.account_lbl.Text = "lbl";
            // 
            // account_txb
            // 
            this.account_txb.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.account_txb.Location = new System.Drawing.Point(362, 160);
            this.account_txb.Name = "account_txb";
            this.account_txb.Size = new System.Drawing.Size(288, 44);
            this.account_txb.TabIndex = 3;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("宋体", 16F);
            this.password_lbl.Location = new System.Drawing.Point(144, 240);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(63, 33);
            this.password_lbl.TabIndex = 4;
            this.password_lbl.Tag = "2";
            this.password_lbl.Text = "lbl";
            // 
            // password_txb
            // 
            this.password_txb.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_txb.Location = new System.Drawing.Point(362, 240);
            this.password_txb.Name = "password_txb";
            this.password_txb.PasswordChar = '*';
            this.password_txb.Size = new System.Drawing.Size(288, 44);
            this.password_txb.TabIndex = 5;
            // 
            // password_confirm_lbl
            // 
            this.password_confirm_lbl.AutoSize = true;
            this.password_confirm_lbl.Font = new System.Drawing.Font("宋体", 16F);
            this.password_confirm_lbl.Location = new System.Drawing.Point(144, 320);
            this.password_confirm_lbl.Name = "password_confirm_lbl";
            this.password_confirm_lbl.Size = new System.Drawing.Size(63, 33);
            this.password_confirm_lbl.TabIndex = 6;
            this.password_confirm_lbl.Tag = "8";
            this.password_confirm_lbl.Text = "lbl";
            this.password_confirm_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_confirm_txb
            // 
            this.password_confirm_txb.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_confirm_txb.Location = new System.Drawing.Point(362, 320);
            this.password_confirm_txb.Name = "password_confirm_txb";
            this.password_confirm_txb.PasswordChar = '*';
            this.password_confirm_txb.Size = new System.Drawing.Size(288, 44);
            this.password_confirm_txb.TabIndex = 7;
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register_btn.Location = new System.Drawing.Point(150, 404);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(130, 60);
            this.register_btn.TabIndex = 8;
            this.register_btn.Tag = "4";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back_btn.Location = new System.Drawing.Point(520, 404);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(130, 60);
            this.back_btn.TabIndex = 9;
            this.back_btn.Tag = "9";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.username_txb);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.account_txb);
            this.Controls.Add(this.account_lbl);
            this.Controls.Add(this.password_txb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.password_confirm_txb);
            this.Controls.Add(this.password_confirm_lbl);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.back_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "4";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_txb;
        private System.Windows.Forms.Label account_lbl;
        private System.Windows.Forms.TextBox account_txb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_txb;
        private System.Windows.Forms.Label password_confirm_lbl;
        private System.Windows.Forms.TextBox password_confirm_txb;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button back_btn;
        
    }
}
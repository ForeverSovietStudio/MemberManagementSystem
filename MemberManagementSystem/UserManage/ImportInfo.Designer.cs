namespace MemberManagementSystem.UserManage
{
    partial class ImportInfo
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
            this.select_file_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selected_file_txb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clear_file_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_file_btn
            // 
            this.select_file_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_file_btn.Location = new System.Drawing.Point(14, 217);
            this.select_file_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.select_file_btn.Name = "select_file_btn";
            this.select_file_btn.Size = new System.Drawing.Size(128, 61);
            this.select_file_btn.TabIndex = 0;
            this.select_file_btn.Tag = "86";
            this.select_file_btn.UseVisualStyleBackColor = true;
            this.select_file_btn.Click += new System.EventHandler(this.select_file_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.Location = new System.Drawing.Point(488, 217);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(128, 61);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Tag = "55";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // import_btn
            // 
            this.import_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.import_btn.Location = new System.Drawing.Point(353, 217);
            this.import_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(128, 61);
            this.import_btn.TabIndex = 2;
            this.import_btn.Tag = "88";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 3;
            this.label1.Tag = "85";
            this.label1.Text = "lbl";
            // 
            // selected_file_txb
            // 
            this.selected_file_txb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selected_file_txb.Location = new System.Drawing.Point(119, 163);
            this.selected_file_txb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selected_file_txb.Name = "selected_file_txb";
            this.selected_file_txb.Size = new System.Drawing.Size(497, 35);
            this.selected_file_txb.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(18, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 141);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "注意：导入表格时应严格按照示例仔细填写数据，且单次导入数据量不宜过大";
            // 
            // clear_file_btn
            // 
            this.clear_file_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_file_btn.Location = new System.Drawing.Point(148, 217);
            this.clear_file_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear_file_btn.Name = "clear_file_btn";
            this.clear_file_btn.Size = new System.Drawing.Size(128, 61);
            this.clear_file_btn.TabIndex = 6;
            this.clear_file_btn.Tag = "87";
            this.clear_file_btn.UseVisualStyleBackColor = true;
            this.clear_file_btn.Click += new System.EventHandler(this.clear_file_btn_Click);
            // 
            // ImportInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 293);
            this.Controls.Add(this.clear_file_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selected_file_txb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.select_file_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "28";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_file_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selected_file_txb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clear_file_btn;
    }
}
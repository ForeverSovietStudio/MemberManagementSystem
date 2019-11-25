namespace MemberManagementSystem.GoodsManage
{
    partial class SetGoodsType
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("计次商品");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("非计次商品");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goods_type_tvw = new System.Windows.Forms.TreeView();
            this.modify_goods_type_gpb = new System.Windows.Forms.GroupBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.delete_type_btn = new System.Windows.Forms.Button();
            this.create_child_type_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.type_name_txb = new System.Windows.Forms.TextBox();
            this.parent_type_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.modify_goods_type_gpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.goods_type_tvw);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 592);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "111";
            // 
            // goods_type_tvw
            // 
            this.goods_type_tvw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goods_type_tvw.HideSelection = false;
            this.goods_type_tvw.Location = new System.Drawing.Point(6, 34);
            this.goods_type_tvw.Name = "goods_type_tvw";
            treeNode1.Name = "节点1";
            treeNode1.Text = "计次商品";
            treeNode2.Name = "节点2";
            treeNode2.Text = "非计次商品";
            this.goods_type_tvw.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.goods_type_tvw.Size = new System.Drawing.Size(369, 552);
            this.goods_type_tvw.TabIndex = 0;
            this.goods_type_tvw.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.goods_type_tvw_BeforeSelect);
            this.goods_type_tvw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.goods_type_tvw_AfterSelect);
            this.goods_type_tvw.DoubleClick += new System.EventHandler(this.goods_type_tvw_DoubleClick);
            // 
            // modify_goods_type_gpb
            // 
            this.modify_goods_type_gpb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_goods_type_gpb.Controls.Add(this.confirm_btn);
            this.modify_goods_type_gpb.Controls.Add(this.delete_type_btn);
            this.modify_goods_type_gpb.Controls.Add(this.create_child_type_btn);
            this.modify_goods_type_gpb.Controls.Add(this.label2);
            this.modify_goods_type_gpb.Controls.Add(this.type_name_txb);
            this.modify_goods_type_gpb.Controls.Add(this.parent_type_tbx);
            this.modify_goods_type_gpb.Controls.Add(this.label1);
            this.modify_goods_type_gpb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modify_goods_type_gpb.Location = new System.Drawing.Point(399, 12);
            this.modify_goods_type_gpb.Name = "modify_goods_type_gpb";
            this.modify_goods_type_gpb.Size = new System.Drawing.Size(314, 586);
            this.modify_goods_type_gpb.TabIndex = 1;
            this.modify_goods_type_gpb.TabStop = false;
            this.modify_goods_type_gpb.Tag = "112";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirm_btn.Location = new System.Drawing.Point(79, 512);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(157, 42);
            this.confirm_btn.TabIndex = 7;
            this.confirm_btn.Tag = "63";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // delete_type_btn
            // 
            this.delete_type_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_type_btn.Location = new System.Drawing.Point(79, 452);
            this.delete_type_btn.Name = "delete_type_btn";
            this.delete_type_btn.Size = new System.Drawing.Size(157, 42);
            this.delete_type_btn.TabIndex = 6;
            this.delete_type_btn.Tag = "116";
            this.delete_type_btn.UseVisualStyleBackColor = true;
            this.delete_type_btn.Click += new System.EventHandler(this.delete_type_btn_Click);
            // 
            // create_child_type_btn
            // 
            this.create_child_type_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.create_child_type_btn.Location = new System.Drawing.Point(79, 392);
            this.create_child_type_btn.Name = "create_child_type_btn";
            this.create_child_type_btn.Size = new System.Drawing.Size(157, 42);
            this.create_child_type_btn.TabIndex = 5;
            this.create_child_type_btn.Tag = "115";
            this.create_child_type_btn.UseVisualStyleBackColor = true;
            this.create_child_type_btn.Click += new System.EventHandler(this.create_child_type_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 4;
            this.label2.Tag = "114";
            this.label2.Text = "lbl";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_name_txb
            // 
            this.type_name_txb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_name_txb.Location = new System.Drawing.Point(157, 120);
            this.type_name_txb.Name = "type_name_txb";
            this.type_name_txb.Size = new System.Drawing.Size(151, 35);
            this.type_name_txb.TabIndex = 3;
            this.type_name_txb.TextChanged += new System.EventHandler(this.type_name_txb_TextChanged);
            // 
            // parent_type_tbx
            // 
            this.parent_type_tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.parent_type_tbx.Location = new System.Drawing.Point(157, 50);
            this.parent_type_tbx.Name = "parent_type_tbx";
            this.parent_type_tbx.Size = new System.Drawing.Size(151, 35);
            this.parent_type_tbx.TabIndex = 1;
            this.parent_type_tbx.TextChanged += new System.EventHandler(this.parent_type_tbx_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 0;
            this.label1.Tag = "113";
            this.label1.Text = "lbl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetGoodsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 616);
            this.Controls.Add(this.modify_goods_type_gpb);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetGoodsType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "36";
            this.groupBox1.ResumeLayout(false);
            this.modify_goods_type_gpb.ResumeLayout(false);
            this.modify_goods_type_gpb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView goods_type_tvw;
        private System.Windows.Forms.GroupBox modify_goods_type_gpb;
        private System.Windows.Forms.TextBox parent_type_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type_name_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create_child_type_btn;
        private System.Windows.Forms.Button delete_type_btn;
        private System.Windows.Forms.Button confirm_btn;
    }
}
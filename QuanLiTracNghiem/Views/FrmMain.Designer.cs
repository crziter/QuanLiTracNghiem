namespace QuanLiTracNghiem.Views
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuanLi = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuThiSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDeThi = new System.Windows.Forms.ToolStripMenuItem();
            this.PnContent = new System.Windows.Forms.Panel();
            this.MnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuChuongTrinh,
            this.MnuQuanLi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuChuongTrinh
            // 
            this.MenuChuongTrinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuThoat});
            this.MenuChuongTrinh.Name = "MenuChuongTrinh";
            this.MenuChuongTrinh.Size = new System.Drawing.Size(90, 20);
            this.MenuChuongTrinh.Text = "Chương trình";
            // 
            // MnuQuanLi
            // 
            this.MnuQuanLi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuThiSinh,
            this.MnuDeThi});
            this.MnuQuanLi.Name = "MnuQuanLi";
            this.MnuQuanLi.Size = new System.Drawing.Size(57, 20);
            this.MnuQuanLi.Text = "Quản lí";
            // 
            // MnuThiSinh
            // 
            this.MnuThiSinh.Name = "MnuThiSinh";
            this.MnuThiSinh.Size = new System.Drawing.Size(116, 22);
            this.MnuThiSinh.Text = "Thí sinh";
            this.MnuThiSinh.Click += new System.EventHandler(this.MnuThiSinh_Click);
            // 
            // MnuDeThi
            // 
            this.MnuDeThi.Name = "MnuDeThi";
            this.MnuDeThi.Size = new System.Drawing.Size(116, 22);
            this.MnuDeThi.Text = "Đề thi";
            this.MnuDeThi.Click += new System.EventHandler(this.MnuDeThi_Click);
            // 
            // PnContent
            // 
            this.PnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContent.Location = new System.Drawing.Point(0, 24);
            this.PnContent.Name = "PnContent";
            this.PnContent.Size = new System.Drawing.Size(700, 489);
            this.PnContent.TabIndex = 1;
            this.PnContent.Resize += new System.EventHandler(this.PnContent_Resize);
            // 
            // MnuThoat
            // 
            this.MnuThoat.Name = "MnuThoat";
            this.MnuThoat.Size = new System.Drawing.Size(152, 22);
            this.MnuThoat.Text = "Thoát";
            this.MnuThoat.Click += new System.EventHandler(this.MnuThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 513);
            this.Controls.Add(this.PnContent);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Quản lí trắc nghiệm";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem MnuQuanLi;
        private System.Windows.Forms.ToolStripMenuItem MnuThiSinh;
        private System.Windows.Forms.Panel PnContent;
        private System.Windows.Forms.ToolStripMenuItem MnuDeThi;
        private System.Windows.Forms.ToolStripMenuItem MnuThoat;

    }
}


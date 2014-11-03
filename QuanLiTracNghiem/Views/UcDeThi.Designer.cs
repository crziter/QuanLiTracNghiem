namespace QuanLiTracNghiem.Views
{
    partial class UcDeThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDeThi));
            this.LstMonThi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMonThi = new System.Windows.Forms.TextBox();
            this.BtnThemMonThi = new System.Windows.Forms.Button();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.BtnUpDateMonThi = new System.Windows.Forms.Button();
            this.BtnHideMonThi = new System.Windows.Forms.Button();
            this.BtnNewDeThi = new System.Windows.Forms.Button();
            this.BtnHideDeThi = new System.Windows.Forms.Button();
            this.LstDeThi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LstCauHoi = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.BtnXoaCauHoi = new System.Windows.Forms.Button();
            this.PnCauHoi = new System.Windows.Forms.Panel();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.CbDapAn = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtD = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtNoiDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PnCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstMonThi
            // 
            this.LstMonThi.FormattingEnabled = true;
            this.LstMonThi.Location = new System.Drawing.Point(11, 23);
            this.LstMonThi.Name = "LstMonThi";
            this.LstMonThi.Size = new System.Drawing.Size(120, 147);
            this.LstMonThi.TabIndex = 0;
            this.LstMonThi.SelectedIndexChanged += new System.EventHandler(this.LstMonThi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn thi:";
            // 
            // TxtMonThi
            // 
            this.TxtMonThi.Location = new System.Drawing.Point(11, 176);
            this.TxtMonThi.Name = "TxtMonThi";
            this.TxtMonThi.Size = new System.Drawing.Size(120, 21);
            this.TxtMonThi.TabIndex = 2;
            // 
            // BtnThemMonThi
            // 
            this.BtnThemMonThi.ImageIndex = 3;
            this.BtnThemMonThi.ImageList = this.ImgList;
            this.BtnThemMonThi.Location = new System.Drawing.Point(137, 174);
            this.BtnThemMonThi.Name = "BtnThemMonThi";
            this.BtnThemMonThi.Size = new System.Drawing.Size(23, 23);
            this.BtnThemMonThi.TabIndex = 3;
            this.BtnThemMonThi.UseVisualStyleBackColor = true;
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "clear.png");
            this.ImgList.Images.SetKeyName(1, "delete.png");
            this.ImgList.Images.SetKeyName(2, "edit.png");
            this.ImgList.Images.SetKeyName(3, "new.png");
            // 
            // BtnUpDateMonThi
            // 
            this.BtnUpDateMonThi.ImageIndex = 2;
            this.BtnUpDateMonThi.ImageList = this.ImgList;
            this.BtnUpDateMonThi.Location = new System.Drawing.Point(137, 147);
            this.BtnUpDateMonThi.Name = "BtnUpDateMonThi";
            this.BtnUpDateMonThi.Size = new System.Drawing.Size(23, 23);
            this.BtnUpDateMonThi.TabIndex = 4;
            this.BtnUpDateMonThi.UseVisualStyleBackColor = true;
            this.BtnUpDateMonThi.Click += new System.EventHandler(this.BtnUpDateMonThi_Click);
            // 
            // BtnHideMonThi
            // 
            this.BtnHideMonThi.ImageIndex = 1;
            this.BtnHideMonThi.ImageList = this.ImgList;
            this.BtnHideMonThi.Location = new System.Drawing.Point(137, 118);
            this.BtnHideMonThi.Name = "BtnHideMonThi";
            this.BtnHideMonThi.Size = new System.Drawing.Size(23, 23);
            this.BtnHideMonThi.TabIndex = 5;
            this.BtnHideMonThi.UseVisualStyleBackColor = true;
            // 
            // BtnNewDeThi
            // 
            this.BtnNewDeThi.ImageIndex = 3;
            this.BtnNewDeThi.ImageList = this.ImgList;
            this.BtnNewDeThi.Location = new System.Drawing.Point(137, 216);
            this.BtnNewDeThi.Name = "BtnNewDeThi";
            this.BtnNewDeThi.Size = new System.Drawing.Size(23, 23);
            this.BtnNewDeThi.TabIndex = 6;
            this.BtnNewDeThi.UseVisualStyleBackColor = true;
            // 
            // BtnHideDeThi
            // 
            this.BtnHideDeThi.ImageIndex = 1;
            this.BtnHideDeThi.ImageList = this.ImgList;
            this.BtnHideDeThi.Location = new System.Drawing.Point(137, 245);
            this.BtnHideDeThi.Name = "BtnHideDeThi";
            this.BtnHideDeThi.Size = new System.Drawing.Size(23, 23);
            this.BtnHideDeThi.TabIndex = 7;
            this.BtnHideDeThi.UseVisualStyleBackColor = true;
            // 
            // LstDeThi
            // 
            this.LstDeThi.FormattingEnabled = true;
            this.LstDeThi.Location = new System.Drawing.Point(11, 216);
            this.LstDeThi.Name = "LstDeThi";
            this.LstDeThi.Size = new System.Drawing.Size(120, 186);
            this.LstDeThi.TabIndex = 8;
            this.LstDeThi.SelectedIndexChanged += new System.EventHandler(this.LstDeThi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đề thi:";
            // 
            // LstCauHoi
            // 
            this.LstCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cContent,
            this.cA,
            this.cB,
            this.cC,
            this.cD});
            this.LstCauHoi.FullRowSelect = true;
            this.LstCauHoi.GridLines = true;
            this.LstCauHoi.Location = new System.Drawing.Point(166, 23);
            this.LstCauHoi.Name = "LstCauHoi";
            this.LstCauHoi.Size = new System.Drawing.Size(423, 210);
            this.LstCauHoi.TabIndex = 10;
            this.LstCauHoi.UseCompatibleStateImageBehavior = false;
            this.LstCauHoi.View = System.Windows.Forms.View.Details;
            this.LstCauHoi.SelectedIndexChanged += new System.EventHandler(this.LstCauHoi_SelectedIndexChanged);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            // 
            // cContent
            // 
            this.cContent.Text = "Nội dung";
            // 
            // cA
            // 
            this.cA.Text = "A";
            // 
            // cB
            // 
            this.cB.Text = "B";
            // 
            // cC
            // 
            this.cC.Text = "C";
            // 
            // cD
            // 
            this.cD.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách câu hỏi:";
            // 
            // BtnXoaCauHoi
            // 
            this.BtnXoaCauHoi.ImageIndex = 1;
            this.BtnXoaCauHoi.ImageList = this.ImgList;
            this.BtnXoaCauHoi.Location = new System.Drawing.Point(137, 23);
            this.BtnXoaCauHoi.Name = "BtnXoaCauHoi";
            this.BtnXoaCauHoi.Size = new System.Drawing.Size(23, 23);
            this.BtnXoaCauHoi.TabIndex = 12;
            this.BtnXoaCauHoi.UseVisualStyleBackColor = true;
            this.BtnXoaCauHoi.Click += new System.EventHandler(this.BtnXoaCauHoi_Click);
            // 
            // PnCauHoi
            // 
            this.PnCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnCauHoi.Controls.Add(this.BtnClear);
            this.PnCauHoi.Controls.Add(this.BtnLuu);
            this.PnCauHoi.Controls.Add(this.BtnNew);
            this.PnCauHoi.Controls.Add(this.CbDapAn);
            this.PnCauHoi.Controls.Add(this.label9);
            this.PnCauHoi.Controls.Add(this.label8);
            this.PnCauHoi.Controls.Add(this.label7);
            this.PnCauHoi.Controls.Add(this.label6);
            this.PnCauHoi.Controls.Add(this.label5);
            this.PnCauHoi.Controls.Add(this.TxtD);
            this.PnCauHoi.Controls.Add(this.TxtC);
            this.PnCauHoi.Controls.Add(this.TxtB);
            this.PnCauHoi.Controls.Add(this.TxtA);
            this.PnCauHoi.Controls.Add(this.TxtNoiDung);
            this.PnCauHoi.Controls.Add(this.label4);
            this.PnCauHoi.Location = new System.Drawing.Point(166, 236);
            this.PnCauHoi.Name = "PnCauHoi";
            this.PnCauHoi.Size = new System.Drawing.Size(423, 166);
            this.PnCauHoi.TabIndex = 13;
            // 
            // BtnLuu
            // 
            this.BtnLuu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLuu.Location = new System.Drawing.Point(214, 136);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(56, 23);
            this.BtnLuu.TabIndex = 25;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Location = new System.Drawing.Point(152, 136);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(56, 23);
            this.BtnNew.TabIndex = 24;
            this.BtnNew.Text = "Thêm";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // CbDapAn
            // 
            this.CbDapAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDapAn.FormattingEnabled = true;
            this.CbDapAn.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.CbDapAn.Location = new System.Drawing.Point(59, 138);
            this.CbDapAn.Name = "CbDapAn";
            this.CbDapAn.Size = new System.Drawing.Size(87, 21);
            this.CbDapAn.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Đáp án:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "A:";
            // 
            // TxtD
            // 
            this.TxtD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtD.Location = new System.Drawing.Point(59, 111);
            this.TxtD.Name = "TxtD";
            this.TxtD.Size = new System.Drawing.Size(361, 21);
            this.TxtD.TabIndex = 17;
            // 
            // TxtC
            // 
            this.TxtC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtC.Location = new System.Drawing.Point(59, 84);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(361, 21);
            this.TxtC.TabIndex = 16;
            // 
            // TxtB
            // 
            this.TxtB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtB.Location = new System.Drawing.Point(59, 57);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(361, 21);
            this.TxtB.TabIndex = 15;
            // 
            // TxtA
            // 
            this.TxtA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtA.Location = new System.Drawing.Point(59, 30);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(361, 21);
            this.TxtA.TabIndex = 14;
            // 
            // TxtNoiDung
            // 
            this.TxtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNoiDung.Location = new System.Drawing.Point(59, 3);
            this.TxtNoiDung.Name = "TxtNoiDung";
            this.TxtNoiDung.Size = new System.Drawing.Size(361, 21);
            this.TxtNoiDung.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nội dung:";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(276, 136);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(79, 23);
            this.BtnClear.TabIndex = 26;
            this.BtnClear.Text = "Xóa trắng";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // UcDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnCauHoi);
            this.Controls.Add(this.BtnXoaCauHoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LstCauHoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LstDeThi);
            this.Controls.Add(this.BtnHideDeThi);
            this.Controls.Add(this.BtnNewDeThi);
            this.Controls.Add(this.BtnHideMonThi);
            this.Controls.Add(this.BtnUpDateMonThi);
            this.Controls.Add(this.BtnThemMonThi);
            this.Controls.Add(this.TxtMonThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstMonThi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcDeThi";
            this.Size = new System.Drawing.Size(599, 414);
            this.Load += new System.EventHandler(this.UcDeThi_Load);
            this.PnCauHoi.ResumeLayout(false);
            this.PnCauHoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstMonThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMonThi;
        private System.Windows.Forms.Button BtnThemMonThi;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Button BtnUpDateMonThi;
        private System.Windows.Forms.Button BtnHideMonThi;
        private System.Windows.Forms.Button BtnNewDeThi;
        private System.Windows.Forms.Button BtnHideDeThi;
        private System.Windows.Forms.ListBox LstDeThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LstCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnXoaCauHoi;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cContent;
        private System.Windows.Forms.ColumnHeader cA;
        private System.Windows.Forms.ColumnHeader cB;
        private System.Windows.Forms.ColumnHeader cC;
        private System.Windows.Forms.ColumnHeader cD;
        private System.Windows.Forms.Panel PnCauHoi;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ComboBox CbDapAn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtD;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtNoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClear;
    }
}

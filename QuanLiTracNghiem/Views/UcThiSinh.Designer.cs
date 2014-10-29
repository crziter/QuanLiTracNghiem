namespace QuanLiTracNghiem.Views
{
    partial class UcThiSinh
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
            this.LstThiSinh = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRealName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTenDangNhap = new System.Windows.Forms.TextBox();
            this.TxtMatKhau = new System.Windows.Forms.TextBox();
            this.TxtTenThat = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.cActivate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChkActivate = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstThiSinh
            // 
            this.LstThiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstThiSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cUserName,
            this.cRealName,
            this.cEmail,
            this.cActivate});
            this.LstThiSinh.FullRowSelect = true;
            this.LstThiSinh.GridLines = true;
            this.LstThiSinh.Location = new System.Drawing.Point(6, 16);
            this.LstThiSinh.MultiSelect = false;
            this.LstThiSinh.Name = "LstThiSinh";
            this.LstThiSinh.Size = new System.Drawing.Size(622, 331);
            this.LstThiSinh.TabIndex = 0;
            this.LstThiSinh.UseCompatibleStateImageBehavior = false;
            this.LstThiSinh.View = System.Windows.Forms.View.Details;
            this.LstThiSinh.SelectedIndexChanged += new System.EventHandler(this.LstThiSinh_SelectedIndexChanged);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            // 
            // cUserName
            // 
            this.cUserName.Text = "Tên đăng nhập";
            this.cUserName.Width = 120;
            // 
            // cRealName
            // 
            this.cRealName.Text = "Tên thật";
            this.cRealName.Width = 150;
            // 
            // cEmail
            // 
            this.cEmail.Text = "Email";
            this.cEmail.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách thí sinh:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên thật:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // TxtTenDangNhap
            // 
            this.TxtTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTenDangNhap.Location = new System.Drawing.Point(124, 353);
            this.TxtTenDangNhap.Name = "TxtTenDangNhap";
            this.TxtTenDangNhap.Size = new System.Drawing.Size(195, 21);
            this.TxtTenDangNhap.TabIndex = 7;
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtMatKhau.Location = new System.Drawing.Point(124, 380);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.Size = new System.Drawing.Size(195, 21);
            this.TxtMatKhau.TabIndex = 8;
            this.TxtMatKhau.UseSystemPasswordChar = true;
            // 
            // TxtTenThat
            // 
            this.TxtTenThat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTenThat.Location = new System.Drawing.Point(407, 353);
            this.TxtTenThat.Name = "TxtTenThat";
            this.TxtTenThat.Size = new System.Drawing.Size(195, 21);
            this.TxtTenThat.TabIndex = 9;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtEmail.Location = new System.Drawing.Point(407, 380);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(195, 21);
            this.TxtEmail.TabIndex = 10;
            // 
            // cActivate
            // 
            this.cActivate.Text = "Hoạt động";
            this.cActivate.Width = 70;
            // 
            // ChkActivate
            // 
            this.ChkActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkActivate.AutoSize = true;
            this.ChkActivate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivate.Location = new System.Drawing.Point(124, 407);
            this.ChkActivate.Name = "ChkActivate";
            this.ChkActivate.Size = new System.Drawing.Size(84, 17);
            this.ChkActivate.TabIndex = 14;
            this.ChkActivate.Text = "Hoạt động";
            this.ChkActivate.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Image = global::QuanLiTracNghiem.Properties.Resources.clear;
            this.BtnClear.Location = new System.Drawing.Point(634, 130);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(51, 51);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Image = global::QuanLiTracNghiem.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(634, 73);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(51, 51);
            this.BtnNew.TabIndex = 13;
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Image = global::QuanLiTracNghiem.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(634, 16);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(51, 51);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // UcThiSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.ChkActivate);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTenThat);
            this.Controls.Add(this.TxtMatKhau);
            this.Controls.Add(this.TxtTenDangNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstThiSinh);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcThiSinh";
            this.Size = new System.Drawing.Size(688, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstThiSinh;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cUserName;
        private System.Windows.Forms.ColumnHeader cRealName;
        private System.Windows.Forms.ColumnHeader cEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTenDangNhap;
        private System.Windows.Forms.TextBox TxtMatKhau;
        private System.Windows.Forms.TextBox TxtTenThat;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ColumnHeader cActivate;
        private System.Windows.Forms.CheckBox ChkActivate;
        private System.Windows.Forms.Button BtnClear;

    }
}

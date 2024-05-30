namespace win3tier.GUI
{
    partial class frmSinhVien
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
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtNamvaohoc = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnXoatextbox = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnTimtheoTen = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMasv
            // 
            this.txtMasv.BackColor = System.Drawing.SystemColors.Info;
            this.txtMasv.Location = new System.Drawing.Point(120, 91);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(200, 20);
            this.txtMasv.TabIndex = 0;
            // 
            // txtTensv
            // 
            this.txtTensv.BackColor = System.Drawing.SystemColors.Info;
            this.txtTensv.Location = new System.Drawing.Point(120, 118);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(200, 20);
            this.txtTensv.TabIndex = 1;
            // 
            // txtNamvaohoc
            // 
            this.txtNamvaohoc.BackColor = System.Drawing.SystemColors.Info;
            this.txtNamvaohoc.Location = new System.Drawing.Point(120, 145);
            this.txtNamvaohoc.Name = "txtNamvaohoc";
            this.txtNamvaohoc.Size = new System.Drawing.Size(200, 20);
            this.txtNamvaohoc.TabIndex = 2;
            // 
            // txtQuequan
            // 
            this.txtQuequan.BackColor = System.Drawing.SystemColors.Info;
            this.txtQuequan.Location = new System.Drawing.Point(120, 220);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(200, 20);
            this.txtQuequan.TabIndex = 4;
            // 
            // txtGhichu
            // 
            this.txtGhichu.BackColor = System.Drawing.SystemColors.Info;
            this.txtGhichu.Location = new System.Drawing.Point(120, 247);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(200, 87);
            this.txtGhichu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Năm vào học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quê quán: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "THÔNG TIN SINH VIÊN";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(332, 90);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(510, 284);
            this.dgvSinhVien.TabIndex = 13;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpNgaysinh.Location = new System.Drawing.Point(120, 181);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaysinh.TabIndex = 14;
            // 
            // btnXoatextbox
            // 
            this.btnXoatextbox.Location = new System.Drawing.Point(130, 351);
            this.btnXoatextbox.Name = "btnXoatextbox";
            this.btnXoatextbox.Size = new System.Drawing.Size(75, 23);
            this.btnXoatextbox.TabIndex = 15;
            this.btnXoatextbox.Text = "Xóa textbox";
            this.btnXoatextbox.UseVisualStyleBackColor = true;
            this.btnXoatextbox.Click += new System.EventHandler(this.btnXoatextbox_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(245, 351);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 16;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnTimtheoTen
            // 
            this.btnTimtheoTen.Location = new System.Drawing.Point(766, 62);
            this.btnTimtheoTen.Name = "btnTimtheoTen";
            this.btnTimtheoTen.Size = new System.Drawing.Size(75, 23);
            this.btnTimtheoTen.TabIndex = 17;
            this.btnTimtheoTen.Text = "Tìm kiếm";
            this.btnTimtheoTen.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(332, 64);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(394, 20);
            this.txtTimKiem.TabIndex = 18;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 402);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimtheoTen);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnXoatextbox);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.txtNamvaohoc);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.txtMasv);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtNamvaohoc;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Button btnXoatextbox;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnTimtheoTen;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
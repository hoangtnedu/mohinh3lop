namespace win3tier.GUI
{
    partial class frmNhap2so
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
            this.txtSothu1 = new System.Windows.Forms.TextBox();
            this.txtSothu2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnXoatextbox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSothu1
            // 
            this.txtSothu1.BackColor = System.Drawing.SystemColors.Info;
            this.txtSothu1.Location = new System.Drawing.Point(178, 68);
            this.txtSothu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSothu1.Name = "txtSothu1";
            this.txtSothu1.Size = new System.Drawing.Size(206, 26);
            this.txtSothu1.TabIndex = 0;
            // 
            // txtSothu2
            // 
            this.txtSothu2.BackColor = System.Drawing.SystemColors.Info;
            this.txtSothu2.Location = new System.Drawing.Point(178, 112);
            this.txtSothu2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSothu2.Name = "txtSothu2";
            this.txtSothu2.Size = new System.Drawing.Size(206, 26);
            this.txtSothu2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số thứ 2:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOK.Location = new System.Drawing.Point(244, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 37);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Tính tổng";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnXoatextbox
            // 
            this.btnXoatextbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoatextbox.Location = new System.Drawing.Point(63, 199);
            this.btnXoatextbox.Name = "btnXoatextbox";
            this.btnXoatextbox.Size = new System.Drawing.Size(153, 37);
            this.btnXoatextbox.TabIndex = 5;
            this.btnXoatextbox.Text = "Xóa TextBox";
            this.btnXoatextbox.UseVisualStyleBackColor = false;
            this.btnXoatextbox.Click += new System.EventHandler(this.btnXoatextbox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(118, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "NHẬP 2 SỐ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetQua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtKetQua.Location = new System.Drawing.Point(178, 156);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(136, 26);
            this.txtKetQua.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả: ";
            // 
            // frmNhap2so
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(399, 270);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoatextbox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSothu2);
            this.Controls.Add(this.txtSothu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhap2so";
            this.Text = "Nhập 2 số nguyên và tính tổng hai số đó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSothu1;
        private System.Windows.Forms.TextBox txtSothu2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnXoatextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
    }
}
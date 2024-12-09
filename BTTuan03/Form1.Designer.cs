namespace BTTuan03
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.Phaisangtrai = new System.Windows.Forms.Button();
            this.TatcaPhaisangtrai = new System.Windows.Forms.Button();
            this.Traisangphai = new System.Windows.Forms.Button();
            this.TatcaTraisangphai = new System.Windows.Forms.Button();
            this.lstBandau = new System.Windows.Forms.ListBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp A: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp B: ";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(536, 89);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(102, 34);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(109, 362);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 34);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(488, 362);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(102, 34);
            this.btnKetthuc.TabIndex = 6;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.button3_Click);
            // 
            // Phaisangtrai
            // 
            this.Phaisangtrai.Location = new System.Drawing.Point(352, 187);
            this.Phaisangtrai.Name = "Phaisangtrai";
            this.Phaisangtrai.Size = new System.Drawing.Size(76, 34);
            this.Phaisangtrai.TabIndex = 7;
            this.Phaisangtrai.Text = "<";
            this.Phaisangtrai.UseVisualStyleBackColor = true;
            this.Phaisangtrai.Click += new System.EventHandler(this.Phaisangtrai_Click);
            // 
            // TatcaPhaisangtrai
            // 
            this.TatcaPhaisangtrai.Location = new System.Drawing.Point(352, 247);
            this.TatcaPhaisangtrai.Name = "TatcaPhaisangtrai";
            this.TatcaPhaisangtrai.Size = new System.Drawing.Size(76, 34);
            this.TatcaPhaisangtrai.TabIndex = 8;
            this.TatcaPhaisangtrai.Text = "<<";
            this.TatcaPhaisangtrai.UseVisualStyleBackColor = true;
            this.TatcaPhaisangtrai.Click += new System.EventHandler(this.TatcaPhaisangtrai_Click);
            // 
            // Traisangphai
            // 
            this.Traisangphai.Location = new System.Drawing.Point(267, 187);
            this.Traisangphai.Name = "Traisangphai";
            this.Traisangphai.Size = new System.Drawing.Size(79, 34);
            this.Traisangphai.TabIndex = 9;
            this.Traisangphai.Text = ">";
            this.Traisangphai.UseVisualStyleBackColor = true;
            this.Traisangphai.Click += new System.EventHandler(this.Traisangphai_Click);
            // 
            // TatcaTraisangphai
            // 
            this.TatcaTraisangphai.Location = new System.Drawing.Point(267, 247);
            this.TatcaTraisangphai.Name = "TatcaTraisangphai";
            this.TatcaTraisangphai.Size = new System.Drawing.Size(79, 34);
            this.TatcaTraisangphai.TabIndex = 10;
            this.TatcaTraisangphai.Text = ">>";
            this.TatcaTraisangphai.UseVisualStyleBackColor = true;
            this.TatcaTraisangphai.Click += new System.EventHandler(this.TatcaTraisangphai_Click);
            // 
            // lstBandau
            // 
            this.lstBandau.FormattingEnabled = true;
            this.lstBandau.ItemHeight = 16;
            this.lstBandau.Location = new System.Drawing.Point(66, 165);
            this.lstBandau.Name = "lstBandau";
            this.lstBandau.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBandau.Size = new System.Drawing.Size(179, 180);
            this.lstBandau.TabIndex = 11;
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 16;
            this.lstKetqua.Location = new System.Drawing.Point(453, 165);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKetqua.Size = new System.Drawing.Size(185, 180);
            this.lstKetqua.TabIndex = 12;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(139, 95);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(373, 22);
            this.txtHoten.TabIndex = 13;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCapnhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(754, 413);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.lstBandau);
            this.Controls.Add(this.TatcaTraisangphai);
            this.Controls.Add(this.Traisangphai);
            this.Controls.Add(this.TatcaPhaisangtrai);
            this.Controls.Add(this.Phaisangtrai);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản lí sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.Button Phaisangtrai;
        private System.Windows.Forms.Button TatcaPhaisangtrai;
        private System.Windows.Forms.Button Traisangphai;
        private System.Windows.Forms.Button TatcaTraisangphai;
        private System.Windows.Forms.ListBox lstBandau;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.TextBox txtHoten;
    }
}


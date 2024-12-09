namespace Bai02
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
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btChonchandau = new System.Windows.Forms.Button();
            this.btLecuoi = new System.Windows.Forms.Button();
            this.btXoaphantudangchon = new System.Windows.Forms.Button();
            this.btXoaphantudau = new System.Windows.Forms.Button();
            this.btXoaphantucuoi = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên: ";
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.Location = new System.Drawing.Point(157, 65);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(231, 22);
            this.txtSonguyen.TabIndex = 1;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            // 
            // btCapnhat
            // 
            this.btCapnhat.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapnhat.Location = new System.Drawing.Point(411, 60);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(96, 32);
            this.btCapnhat.TabIndex = 2;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = true;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // lstKetqua
            // 
            this.lstKetqua.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 16;
            this.lstKetqua.Location = new System.Drawing.Point(43, 117);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(207, 244);
            this.lstKetqua.TabIndex = 3;
            this.lstKetqua.SelectedIndexChanged += new System.EventHandler(this.lstKetqua_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chức năng của chương trình";
            // 
            // btTang2
            // 
            this.btTang2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTang2.Location = new System.Drawing.Point(291, 148);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(216, 32);
            this.btTang2.TabIndex = 5;
            this.btTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btTang2.UseVisualStyleBackColor = true;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btChonchandau
            // 
            this.btChonchandau.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChonchandau.Location = new System.Drawing.Point(291, 186);
            this.btChonchandau.Name = "btChonchandau";
            this.btChonchandau.Size = new System.Drawing.Size(216, 32);
            this.btChonchandau.TabIndex = 6;
            this.btChonchandau.Text = "Chọn số chẵn đầu";
            this.btChonchandau.UseVisualStyleBackColor = true;
            this.btChonchandau.Click += new System.EventHandler(this.btChonchandau_Click);
            // 
            // btLecuoi
            // 
            this.btLecuoi.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLecuoi.Location = new System.Drawing.Point(291, 224);
            this.btLecuoi.Name = "btLecuoi";
            this.btLecuoi.Size = new System.Drawing.Size(216, 32);
            this.btLecuoi.TabIndex = 7;
            this.btLecuoi.Text = "Chọn số lẻ cuối";
            this.btLecuoi.UseVisualStyleBackColor = true;
            this.btLecuoi.Click += new System.EventHandler(this.btLecuoi_Click);
            // 
            // btXoaphantudangchon
            // 
            this.btXoaphantudangchon.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaphantudangchon.Location = new System.Drawing.Point(291, 262);
            this.btXoaphantudangchon.Name = "btXoaphantudangchon";
            this.btXoaphantudangchon.Size = new System.Drawing.Size(216, 32);
            this.btXoaphantudangchon.TabIndex = 8;
            this.btXoaphantudangchon.Text = "Xóa phần tử đang chọn";
            this.btXoaphantudangchon.UseVisualStyleBackColor = true;
            this.btXoaphantudangchon.Click += new System.EventHandler(this.btXoaphantudangchon_Click);
            // 
            // btXoaphantudau
            // 
            this.btXoaphantudau.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaphantudau.Location = new System.Drawing.Point(291, 300);
            this.btXoaphantudau.Name = "btXoaphantudau";
            this.btXoaphantudau.Size = new System.Drawing.Size(216, 32);
            this.btXoaphantudau.TabIndex = 9;
            this.btXoaphantudau.Text = "Xóa phần tử đầu";
            this.btXoaphantudau.UseVisualStyleBackColor = true;
            this.btXoaphantudau.Click += new System.EventHandler(this.btXoaphantudau_Click);
            // 
            // btXoaphantucuoi
            // 
            this.btXoaphantucuoi.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaphantucuoi.Location = new System.Drawing.Point(291, 338);
            this.btXoaphantucuoi.Name = "btXoaphantucuoi";
            this.btXoaphantucuoi.Size = new System.Drawing.Size(216, 31);
            this.btXoaphantucuoi.TabIndex = 10;
            this.btXoaphantucuoi.Text = "Xóa phần tử cuối";
            this.btXoaphantucuoi.UseVisualStyleBackColor = true;
            this.btXoaphantucuoi.Click += new System.EventHandler(this.btXoaphantucuoi_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetthuc.Location = new System.Drawing.Point(43, 397);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(464, 27);
            this.btKetthuc.TabIndex = 11;
            this.btKetthuc.Text = "Kết thúc chương trình";
            this.btKetthuc.UseVisualStyleBackColor = true;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btCapnhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 468);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.btXoaphantucuoi);
            this.Controls.Add(this.btXoaphantudau);
            this.Controls.Add(this.btXoaphantudangchon);
            this.Controls.Add(this.btLecuoi);
            this.Controls.Add(this.btChonchandau);
            this.Controls.Add(this.btTang2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button btChonchandau;
        private System.Windows.Forms.Button btLecuoi;
        private System.Windows.Forms.Button btXoaphantudangchon;
        private System.Windows.Forms.Button btXoaphantudau;
        private System.Windows.Forms.Button btXoaphantucuoi;
        private System.Windows.Forms.Button btKetthuc;
    }
}


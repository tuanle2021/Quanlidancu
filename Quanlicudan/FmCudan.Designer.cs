
namespace Quanlicudan
{
	partial class FmCudan
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
			this.tabcontrolDancu = new System.Windows.Forms.TabControl();
			this.tpThongtin = new System.Windows.Forms.TabPage();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnCapnhat = new System.Windows.Forms.Button();
			this.picAVT = new System.Windows.Forms.PictureBox();
			this.txtNewpass2 = new System.Windows.Forms.TextBox();
			this.txtNewpass = new System.Windows.Forms.TextBox();
			this.txtOldpass = new System.Windows.Forms.TextBox();
			this.txtFullname = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tpTamtru = new System.Windows.Forms.TabPage();
			this.tpKethon = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtHotenTT = new System.Windows.Forms.TextBox();
			this.txtNamsinhTT = new System.Windows.Forms.TextBox();
			this.txtCccdTT = new System.Windows.Forms.TextBox();
			this.txtDiachithuongtru = new System.Windows.Forms.TextBox();
			this.txtDiachitamtru = new System.Windows.Forms.TextBox();
			this.rtxtLidoTT = new System.Windows.Forms.RichTextBox();
			this.dtpNgayTT = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayhetTT = new System.Windows.Forms.DateTimePicker();
			this.rbtncomfirm = new System.Windows.Forms.RadioButton();
			this.btnDangki = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.tabcontrolDancu.SuspendLayout();
			this.tpThongtin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAVT)).BeginInit();
			this.tpTamtru.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabcontrolDancu
			// 
			this.tabcontrolDancu.Controls.Add(this.tpThongtin);
			this.tabcontrolDancu.Controls.Add(this.tpTamtru);
			this.tabcontrolDancu.Controls.Add(this.tpKethon);
			this.tabcontrolDancu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabcontrolDancu.Location = new System.Drawing.Point(0, 0);
			this.tabcontrolDancu.Name = "tabcontrolDancu";
			this.tabcontrolDancu.SelectedIndex = 0;
			this.tabcontrolDancu.Size = new System.Drawing.Size(800, 450);
			this.tabcontrolDancu.TabIndex = 0;
			// 
			// tpThongtin
			// 
			this.tpThongtin.BackColor = System.Drawing.Color.LightGray;
			this.tpThongtin.Controls.Add(this.btnThoat);
			this.tpThongtin.Controls.Add(this.btnCapnhat);
			this.tpThongtin.Controls.Add(this.picAVT);
			this.tpThongtin.Controls.Add(this.txtNewpass2);
			this.tpThongtin.Controls.Add(this.txtNewpass);
			this.tpThongtin.Controls.Add(this.txtOldpass);
			this.tpThongtin.Controls.Add(this.txtFullname);
			this.tpThongtin.Controls.Add(this.txtUsername);
			this.tpThongtin.Controls.Add(this.label5);
			this.tpThongtin.Controls.Add(this.label4);
			this.tpThongtin.Controls.Add(this.label3);
			this.tpThongtin.Controls.Add(this.label2);
			this.tpThongtin.Controls.Add(this.label1);
			this.tpThongtin.Location = new System.Drawing.Point(4, 25);
			this.tpThongtin.Name = "tpThongtin";
			this.tpThongtin.Padding = new System.Windows.Forms.Padding(3);
			this.tpThongtin.Size = new System.Drawing.Size(792, 421);
			this.tpThongtin.TabIndex = 0;
			this.tpThongtin.Text = "Thông tin tài khoản";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.MistyRose;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(653, 292);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(112, 35);
			this.btnThoat.TabIndex = 26;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			// 
			// btnCapnhat
			// 
			this.btnCapnhat.BackColor = System.Drawing.Color.MistyRose;
			this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapnhat.Location = new System.Drawing.Point(499, 292);
			this.btnCapnhat.Name = "btnCapnhat";
			this.btnCapnhat.Size = new System.Drawing.Size(112, 35);
			this.btnCapnhat.TabIndex = 25;
			this.btnCapnhat.Text = "Cập nhật";
			this.btnCapnhat.UseVisualStyleBackColor = false;
			this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
			// 
			// picAVT
			// 
			this.picAVT.BackColor = System.Drawing.Color.DimGray;
			this.picAVT.Location = new System.Drawing.Point(89, 88);
			this.picAVT.Name = "picAVT";
			this.picAVT.Size = new System.Drawing.Size(135, 155);
			this.picAVT.TabIndex = 24;
			this.picAVT.TabStop = false;
			// 
			// txtNewpass2
			// 
			this.txtNewpass2.Location = new System.Drawing.Point(578, 247);
			this.txtNewpass2.Name = "txtNewpass2";
			this.txtNewpass2.Size = new System.Drawing.Size(187, 22);
			this.txtNewpass2.TabIndex = 22;
			// 
			// txtNewpass
			// 
			this.txtNewpass.Location = new System.Drawing.Point(578, 207);
			this.txtNewpass.Name = "txtNewpass";
			this.txtNewpass.Size = new System.Drawing.Size(187, 22);
			this.txtNewpass.TabIndex = 21;
			// 
			// txtOldpass
			// 
			this.txtOldpass.Location = new System.Drawing.Point(578, 168);
			this.txtOldpass.Name = "txtOldpass";
			this.txtOldpass.Size = new System.Drawing.Size(187, 22);
			this.txtOldpass.TabIndex = 20;
			// 
			// txtFullname
			// 
			this.txtFullname.Location = new System.Drawing.Point(578, 126);
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.Size = new System.Drawing.Size(187, 22);
			this.txtFullname.TabIndex = 19;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(578, 88);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(187, 22);
			this.txtUsername.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(335, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(181, 18);
			this.label5.TabIndex = 16;
			this.label5.Text = "Nhập lại mật khẩu mới:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(335, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 18);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mật khẩu mới:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(335, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 18);
			this.label3.TabIndex = 14;
			this.label3.Text = "Mật khẩu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(335, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 18);
			this.label2.TabIndex = 13;
			this.label2.Text = "Tên đầy đủ:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(335, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 18);
			this.label1.TabIndex = 12;
			this.label1.Text = "Username:";
			// 
			// tpTamtru
			// 
			this.tpTamtru.Controls.Add(this.label14);
			this.tpTamtru.Controls.Add(this.btnDangki);
			this.tpTamtru.Controls.Add(this.rbtncomfirm);
			this.tpTamtru.Controls.Add(this.dtpNgayhetTT);
			this.tpTamtru.Controls.Add(this.dtpNgayTT);
			this.tpTamtru.Controls.Add(this.rtxtLidoTT);
			this.tpTamtru.Controls.Add(this.txtDiachitamtru);
			this.tpTamtru.Controls.Add(this.txtDiachithuongtru);
			this.tpTamtru.Controls.Add(this.txtCccdTT);
			this.tpTamtru.Controls.Add(this.txtNamsinhTT);
			this.tpTamtru.Controls.Add(this.txtHotenTT);
			this.tpTamtru.Controls.Add(this.label13);
			this.tpTamtru.Controls.Add(this.label12);
			this.tpTamtru.Controls.Add(this.label11);
			this.tpTamtru.Controls.Add(this.label10);
			this.tpTamtru.Controls.Add(this.label9);
			this.tpTamtru.Controls.Add(this.label8);
			this.tpTamtru.Controls.Add(this.label7);
			this.tpTamtru.Controls.Add(this.label6);
			this.tpTamtru.Location = new System.Drawing.Point(4, 25);
			this.tpTamtru.Name = "tpTamtru";
			this.tpTamtru.Padding = new System.Windows.Forms.Padding(3);
			this.tpTamtru.Size = new System.Drawing.Size(792, 421);
			this.tpTamtru.TabIndex = 1;
			this.tpTamtru.Text = "Tạm trú - Tạm vắng";
			this.tpTamtru.UseVisualStyleBackColor = true;
			// 
			// tpKethon
			// 
			this.tpKethon.Location = new System.Drawing.Point(4, 25);
			this.tpKethon.Name = "tpKethon";
			this.tpKethon.Size = new System.Drawing.Size(792, 421);
			this.tpKethon.TabIndex = 2;
			this.tpKethon.Text = "Đăng kí kết hôn";
			this.tpKethon.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(19, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "Họ tên người đăng kí:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 18);
			this.label7.TabIndex = 1;
			this.label7.Text = "Năm sinh: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(19, 150);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 18);
			this.label8.TabIndex = 2;
			this.label8.Text = "Số CCCD: ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(19, 186);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(146, 18);
			this.label9.TabIndex = 3;
			this.label9.Text = "Địa chỉ thường trú:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(18, 220);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(156, 18);
			this.label10.TabIndex = 4;
			this.label10.Text = "Nơi đăng kí tạm trú:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(18, 254);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(169, 18);
			this.label11.TabIndex = 5;
			this.label11.Text = "Ngày bắt đầu tạm trú:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(18, 292);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(169, 18);
			this.label12.TabIndex = 6;
			this.label12.Text = "Ngày hết hạn tạm trú:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(405, 80);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(50, 18);
			this.label13.TabIndex = 7;
			this.label13.Text = "Lí do:";
			// 
			// txtHotenTT
			// 
			this.txtHotenTT.Location = new System.Drawing.Point(204, 78);
			this.txtHotenTT.Name = "txtHotenTT";
			this.txtHotenTT.Size = new System.Drawing.Size(171, 22);
			this.txtHotenTT.TabIndex = 8;
			// 
			// txtNamsinhTT
			// 
			this.txtNamsinhTT.Location = new System.Drawing.Point(204, 112);
			this.txtNamsinhTT.Name = "txtNamsinhTT";
			this.txtNamsinhTT.Size = new System.Drawing.Size(171, 22);
			this.txtNamsinhTT.TabIndex = 9;
			// 
			// txtCccdTT
			// 
			this.txtCccdTT.Location = new System.Drawing.Point(204, 149);
			this.txtCccdTT.Name = "txtCccdTT";
			this.txtCccdTT.Size = new System.Drawing.Size(171, 22);
			this.txtCccdTT.TabIndex = 10;
			// 
			// txtDiachithuongtru
			// 
			this.txtDiachithuongtru.Location = new System.Drawing.Point(204, 185);
			this.txtDiachithuongtru.Name = "txtDiachithuongtru";
			this.txtDiachithuongtru.Size = new System.Drawing.Size(230, 22);
			this.txtDiachithuongtru.TabIndex = 11;
			// 
			// txtDiachitamtru
			// 
			this.txtDiachitamtru.Location = new System.Drawing.Point(204, 220);
			this.txtDiachitamtru.Name = "txtDiachitamtru";
			this.txtDiachitamtru.Size = new System.Drawing.Size(230, 22);
			this.txtDiachitamtru.TabIndex = 12;
			// 
			// rtxtLidoTT
			// 
			this.rtxtLidoTT.Location = new System.Drawing.Point(472, 81);
			this.rtxtLidoTT.Name = "rtxtLidoTT";
			this.rtxtLidoTT.Size = new System.Drawing.Size(297, 161);
			this.rtxtLidoTT.TabIndex = 13;
			this.rtxtLidoTT.Text = "";
			// 
			// dtpNgayTT
			// 
			this.dtpNgayTT.Location = new System.Drawing.Point(204, 254);
			this.dtpNgayTT.Name = "dtpNgayTT";
			this.dtpNgayTT.Size = new System.Drawing.Size(230, 22);
			this.dtpNgayTT.TabIndex = 14;
			// 
			// dtpNgayhetTT
			// 
			this.dtpNgayhetTT.Location = new System.Drawing.Point(204, 292);
			this.dtpNgayhetTT.Name = "dtpNgayhetTT";
			this.dtpNgayhetTT.Size = new System.Drawing.Size(230, 22);
			this.dtpNgayhetTT.TabIndex = 15;
			// 
			// rbtncomfirm
			// 
			this.rbtncomfirm.AutoSize = true;
			this.rbtncomfirm.Location = new System.Drawing.Point(467, 257);
			this.rbtncomfirm.Name = "rbtncomfirm";
			this.rbtncomfirm.Size = new System.Drawing.Size(302, 21);
			this.rbtncomfirm.TabIndex = 16;
			this.rbtncomfirm.TabStop = true;
			this.rbtncomfirm.Text = "Tôi cam đoan thông tin đã khai là chính xác";
			this.rbtncomfirm.UseVisualStyleBackColor = true;
			// 
			// btnDangki
			// 
			this.btnDangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangki.Location = new System.Drawing.Point(622, 284);
			this.btnDangki.Name = "btnDangki";
			this.btnDangki.Size = new System.Drawing.Size(147, 37);
			this.btnDangki.TabIndex = 17;
			this.btnDangki.Text = "Gửi mẫu đăng kí";
			this.btnDangki.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(272, 39);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(278, 20);
			this.label14.TabIndex = 18;
			this.label14.Text = "ĐĂNG KÍ THÔNG TIN TẠM TRÚ";
			// 
			// FmCudan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabcontrolDancu);
			this.Name = "FmCudan";
			this.Text = "FmCudan";
			this.tabcontrolDancu.ResumeLayout(false);
			this.tpThongtin.ResumeLayout(false);
			this.tpThongtin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAVT)).EndInit();
			this.tpTamtru.ResumeLayout(false);
			this.tpTamtru.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabcontrolDancu;
		private System.Windows.Forms.TabPage tpThongtin;
		private System.Windows.Forms.TabPage tpTamtru;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnCapnhat;
		private System.Windows.Forms.PictureBox picAVT;
		private System.Windows.Forms.TextBox txtNewpass2;
		private System.Windows.Forms.TextBox txtNewpass;
		private System.Windows.Forms.TextBox txtOldpass;
		private System.Windows.Forms.TextBox txtFullname;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnDangki;
		private System.Windows.Forms.RadioButton rbtncomfirm;
		private System.Windows.Forms.DateTimePicker dtpNgayhetTT;
		private System.Windows.Forms.DateTimePicker dtpNgayTT;
		private System.Windows.Forms.RichTextBox rtxtLidoTT;
		private System.Windows.Forms.TextBox txtDiachitamtru;
		private System.Windows.Forms.TextBox txtDiachithuongtru;
		private System.Windows.Forms.TextBox txtCccdTT;
		private System.Windows.Forms.TextBox txtNamsinhTT;
		private System.Windows.Forms.TextBox txtHotenTT;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tpKethon;
	}
}
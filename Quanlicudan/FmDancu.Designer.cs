
namespace Quanlicudan
{
	partial class FmDancu
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
			this.tabpageDancu = new System.Windows.Forms.TabControl();
			this.pageTaikhoan = new System.Windows.Forms.TabPage();
			this.pagekethon = new System.Windows.Forms.TabPage();
			this.pageTamtru = new System.Windows.Forms.TabPage();
			this.tabpageDancu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabpageDancu
			// 
			this.tabpageDancu.Controls.Add(this.pageTaikhoan);
			this.tabpageDancu.Controls.Add(this.pagekethon);
			this.tabpageDancu.Controls.Add(this.pageTamtru);
			this.tabpageDancu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabpageDancu.Location = new System.Drawing.Point(0, 0);
			this.tabpageDancu.Name = "tabpageDancu";
			this.tabpageDancu.SelectedIndex = 0;
			this.tabpageDancu.Size = new System.Drawing.Size(800, 450);
			this.tabpageDancu.TabIndex = 0;
			// 
			// pageTaikhoan
			// 
			this.pageTaikhoan.Location = new System.Drawing.Point(4, 25);
			this.pageTaikhoan.Name = "pageTaikhoan";
			this.pageTaikhoan.Padding = new System.Windows.Forms.Padding(3);
			this.pageTaikhoan.Size = new System.Drawing.Size(792, 421);
			this.pageTaikhoan.TabIndex = 0;
			this.pageTaikhoan.Text = "Tài khoản";
			this.pageTaikhoan.UseVisualStyleBackColor = true;
			// 
			// pagekethon
			// 
			this.pagekethon.Location = new System.Drawing.Point(4, 25);
			this.pagekethon.Name = "pagekethon";
			this.pagekethon.Padding = new System.Windows.Forms.Padding(3);
			this.pagekethon.Size = new System.Drawing.Size(792, 421);
			this.pagekethon.TabIndex = 1;
			this.pagekethon.Text = "Đăng kí kết hôn";
			this.pagekethon.UseVisualStyleBackColor = true;
			// 
			// pageTamtru
			// 
			this.pageTamtru.Location = new System.Drawing.Point(4, 25);
			this.pageTamtru.Name = "pageTamtru";
			this.pageTamtru.Size = new System.Drawing.Size(792, 421);
			this.pageTamtru.TabIndex = 2;
			this.pageTamtru.Text = "Tạm trú - Tạm vắng";
			this.pageTamtru.UseVisualStyleBackColor = true;
			// 
			// FmDancu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabpageDancu);
			this.Name = "FmDancu";
			this.Text = "FmDancu";
			this.tabpageDancu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabpageDancu;
		private System.Windows.Forms.TabPage pageTaikhoan;
		private System.Windows.Forms.TabPage pagekethon;
		private System.Windows.Forms.TabPage pageTamtru;
	}
}
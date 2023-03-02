
namespace Quanlicudan
{
	partial class FmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
			this.label1 = new System.Windows.Forms.Label();
			this.btnDangnhap = new System.Windows.Forms.Button();
			this.btnTamtru = new System.Windows.Forms.Button();
			this.btnQuanli = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(64, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 0;
			// 
			// btnDangnhap
			// 
			this.btnDangnhap.Location = new System.Drawing.Point(331, 255);
			this.btnDangnhap.Name = "btnDangnhap";
			this.btnDangnhap.Size = new System.Drawing.Size(157, 44);
			this.btnDangnhap.TabIndex = 1;
			this.btnDangnhap.Text = "Đăng nhập";
			this.btnDangnhap.UseVisualStyleBackColor = true;
			this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
			// 
			// btnTamtru
			// 
			this.btnTamtru.Location = new System.Drawing.Point(232, 321);
			this.btnTamtru.Name = "btnTamtru";
			this.btnTamtru.Size = new System.Drawing.Size(154, 44);
			this.btnTamtru.TabIndex = 2;
			this.btnTamtru.Text = "Đăng kí tạm trú";
			this.btnTamtru.UseVisualStyleBackColor = true;
			// 
			// btnQuanli
			// 
			this.btnQuanli.Location = new System.Drawing.Point(431, 321);
			this.btnQuanli.Name = "btnQuanli";
			this.btnQuanli.Size = new System.Drawing.Size(154, 44);
			this.btnQuanli.TabIndex = 3;
			this.btnQuanli.Text = "Quản lí hộ gia đình";
			this.btnQuanli.UseVisualStyleBackColor = true;
			// 
			// FmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(807, 435);
			this.Controls.Add(this.btnQuanli);
			this.Controls.Add(this.btnTamtru);
			this.Controls.Add(this.btnDangnhap);
			this.Controls.Add(this.label1);
			this.Name = "FmMain";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDangnhap;
		private System.Windows.Forms.Button btnTamtru;
		private System.Windows.Forms.Button btnQuanli;
	}
}


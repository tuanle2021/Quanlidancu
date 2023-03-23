
namespace Quanlicudan
{
	partial class FmTTTV
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
			this.dtgvTTTV = new System.Windows.Forms.DataGridView();
			this.btnDuyet = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgvTTTV)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgvTTTV
			// 
			this.dtgvTTTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvTTTV.Location = new System.Drawing.Point(0, 130);
			this.dtgvTTTV.Name = "dtgvTTTV";
			this.dtgvTTTV.RowHeadersWidth = 51;
			this.dtgvTTTV.RowTemplate.Height = 24;
			this.dtgvTTTV.Size = new System.Drawing.Size(800, 320);
			this.dtgvTTTV.TabIndex = 0;
			// 
			// btnDuyet
			// 
			this.btnDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDuyet.Location = new System.Drawing.Point(12, 76);
			this.btnDuyet.Name = "btnDuyet";
			this.btnDuyet.Size = new System.Drawing.Size(82, 31);
			this.btnDuyet.TabIndex = 1;
			this.btnDuyet.Text = "Duyệt";
			this.btnDuyet.UseVisualStyleBackColor = true;
			this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(141, 76);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(82, 31);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(278, 76);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(82, 31);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// FmTTTV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnDuyet);
			this.Controls.Add(this.dtgvTTTV);
			this.Name = "FmTTTV";
			this.Text = "FmTTTV";
			this.Load += new System.EventHandler(this.FmTTTV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvTTTV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgvTTTV;
		private System.Windows.Forms.Button btnDuyet;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
	}
}
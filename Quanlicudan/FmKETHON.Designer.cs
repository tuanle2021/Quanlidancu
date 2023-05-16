
namespace Quanlicudan
{
	partial class FmKETHON
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
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnDuyet = new System.Windows.Forms.Button();
			this.dtgvKETHON = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtgvKETHON)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(278, 38);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(82, 31);
			this.btnThoat.TabIndex = 7;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(141, 38);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(82, 31);
			this.btnXoa.TabIndex = 6;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnDuyet
			// 
			this.btnDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDuyet.Location = new System.Drawing.Point(12, 38);
			this.btnDuyet.Name = "btnDuyet";
			this.btnDuyet.Size = new System.Drawing.Size(82, 31);
			this.btnDuyet.TabIndex = 5;
			this.btnDuyet.Text = "Duyệt";
			this.btnDuyet.UseVisualStyleBackColor = true;
			// 
			// dtgvKETHON
			// 
			this.dtgvKETHON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvKETHON.Location = new System.Drawing.Point(0, 92);
			this.dtgvKETHON.Name = "dtgvKETHON";
			this.dtgvKETHON.RowHeadersWidth = 51;
			this.dtgvKETHON.RowTemplate.Height = 24;
			this.dtgvKETHON.Size = new System.Drawing.Size(800, 320);
			this.dtgvKETHON.TabIndex = 4;
			// 
			// FmKETHON
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnDuyet);
			this.Controls.Add(this.dtgvKETHON);
			this.Name = "FmKETHON";
			this.Text = "FmKETHON";
			this.Load += new System.EventHandler(this.FmKETHON_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvKETHON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnDuyet;
		private System.Windows.Forms.DataGridView dtgvKETHON;
	}
}
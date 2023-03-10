using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Quanlicudan
{
	public partial class FmThem : Form
	{
		public FmThem()
		{
			InitializeComponent();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string mahk = txtmaHK.Text;
			string ten = txtHoten.Text;
			string namsinh = txtNamsinh.Text;
			string gioitinh = txtGioitinh.Text;
			string sdt = txtSDT.Text;
			string diachi = txtDiachi.Text;
			int nhankhau = (int)nbNhankhau.Value;
			if(mahk==null || ten==null ||namsinh==null||gioitinh==null||sdt==null|| diachi==null ||nhankhau == 0)
			{
				MessageBox.Show("Vui lòng nhập đủ thông tin!!");
			}
			if (ChuhoDAO.Instance.Themchuho(mahk, ten, namsinh, gioitinh, sdt, diachi, nhankhau))
			{
				MessageBox.Show("Thêm thành công");
				ChuhoDAO.Instance.LoadChuho();
			}
			else
				MessageBox.Show("Thêm thất bại. Vui lòng thử lại !");
		}
	}
}

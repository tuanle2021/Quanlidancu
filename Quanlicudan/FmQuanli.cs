using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAO;

namespace Quanlicudan
{
	public partial class FmQuanli : Form
	{
		private User loginUser;

		public User LoginUser { get => loginUser; set => loginUser = value; }

		public FmQuanli(User acc)
		{
			InitializeComponent();
			this.loginUser = acc;
			ChuhoBUS.Instance.LoadChuho(dtgvCudan);
			ShowUserDetail();
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			FmThem f = new FmThem();
			f.Show();
		}

		private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FmUserprofile f = new FmUserprofile(loginUser);
			f.ShowDialog();
		}
		void ShowUserDetail()
		{
			txtTimmaho.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"MaHK", true, DataSourceUpdateMode.Never));
			txtTimten.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"TenCH", true, DataSourceUpdateMode.Never));
			txtTimsdt.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"SDT", true, DataSourceUpdateMode.Never));
			txtTimdiachi.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"diachi", true, DataSourceUpdateMode.Never));
			txtTimgioitinh.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"Gioitinh", true, DataSourceUpdateMode.Never));
			txtTimNamsinh.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"namsinhCH", true, DataSourceUpdateMode.Never));
			nrNhankhau.DataBindings.Add(new Binding("Value",dtgvCudan.DataSource,"sothanhvien", true, DataSourceUpdateMode.Never));
			txtTimCMND.DataBindings.Add(new Binding("Text", dtgvCudan.DataSource, "CCCD", true, DataSourceUpdateMode.Never));
		}
		private void label4_Click(object sender, EventArgs e)
		{

		}
		void Suachuho()
		{
			string maHK = txtTimmaho.Text;
			string tenCH = txtTimten.Text;
			string namsinh = txtTimNamsinh.Text;
			string gioitinh = txtTimgioitinh.Text;
			string sdt = txtTimsdt.Text;
			string diachi = txtTimdiachi.Text;
			int nhankhau = (int)nrNhankhau.Value;
			string cccd = txtTimCMND.Text;
			if(tenCH == null || namsinh == null || gioitinh==null || sdt ==null || diachi ==null ||nhankhau==0|| cccd==null)
			{
				MessageBox.Show("Vui lòng nhập đủ thông tin Chủ hộ !");
			}
			else
			{
				if (ChuhoDAO.Instance.Suachuho(maHK,tenCH, namsinh, gioitinh, sdt, diachi, nhankhau, cccd))
				{
					MessageBox.Show("Cập nhật thành công !");
					ChuhoBUS.Instance.LoadChuho(dtgvCudan);
				}
				else
					MessageBox.Show("Vui lòng thử lại");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Suachuho();
		}
		void Xoachuho()
		{
			string maHK = txtTimmaho.Text;
			if (ChuhoDAO.Instance.Xoachuho(maHK))
			{
				MessageBox.Show("Xoá thành công hộ gia đình");
				ChuhoBUS.Instance.LoadChuho(dtgvCudan);
			}
			else MessageBox.Show("Vui lòng thử lại sau");

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Xoachuho();
		}

		private void btnCapnhat_Click(object sender, EventArgs e)
		{
			ChuhoBUS.Instance.LoadChuho(dtgvCudan);
		}

		private void FmQuanli_Load(object sender, EventArgs e)
		{

		}

		private void menutttv_Click(object sender, EventArgs e)
		{
			FmTTTV f = new FmTTTV();
			f.ShowDialog();
		}
	}
}

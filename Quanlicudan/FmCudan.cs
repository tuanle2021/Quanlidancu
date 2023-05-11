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
using DTO;

namespace Quanlicudan
{
	public partial class FmCudan : Form
	{
		private User loginUser;
		public User LoginUser { get => loginUser; set
			{loginUser=value;ChangeUser(loginUser); } 
		}
		public FmCudan(User acc)
		{
			InitializeComponent();
			LoginUser = acc;
		}
		void Updateuser()
		{
			string fullname = txtFullname.Text;
			string newpass = txtNewpass.Text;
			string password = txtOldpass.Text;
			string enternewpass = txtNewpass2.Text;
			string username = txtUsername.Text;
			if (!newpass.Equals(enternewpass))
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
			}
			else
			{
				if (UserDAO.Instance.UpdateUser(username, fullname, password, newpass))
				{
					MessageBox.Show("Cập nhật thành công");
				}
				else
				{
					MessageBox.Show("Vui lòng thử lại sau");
				}
			}
		}
		public void ChangeUser(User acc)
		{
			loginUser = acc;
			txtUsername.Text = acc.Username;
			txtFullname.Text = acc.Ten;
		}

		private void btnCapnhat_Click(object sender, EventArgs e)
		{
			Updateuser();
		}

		private void tpTamtru_Click(object sender, EventArgs e)
		{

		}
		void Submit()
		{
			string ten = txtHotenTT.Text;
			string namsinh = txtNamsinhTT.Text;
			string cccd = txtCccdTT.Text;
			string dcthuongtru = txtDiachithuongtru.Text;
			string dctamtru = txtDiachitamtru.Text;
			DateTime ngayden = dtpNgayTT.Value.Date;
			DateTime ngaydi = dtpNgayhetTT.Value.Date;
			string lido = rtxtLidoTT.Text;
			int state = 0;
			if( ten==null || namsinh==null || cccd==null|| dcthuongtru==null ||dctamtru==null|| ngayden==null||ngaydi==null || lido==null)
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng kí");
			}
			else
			{
				if (TamtruDAO.Instance.Submit(ten, namsinh, cccd, dcthuongtru, dctamtru, ngayden, ngaydi, lido, state))
				{
					MessageBox.Show("GỬI ĐƠN THÀNH CÔNG");
				}
				else
					MessageBox.Show("VUI LÒNG THỬ LẠI");
			}
		}

		private void btnDangki_Click(object sender, EventArgs e)
		{

			Submit();
			
		}

		private void tpKinhdoanh_Click(object sender, EventArgs e)
		{

		}
		void Loadtinh()
		{
			cbTinh.DataSource = DangkiDAO.Instance.Loadtinh();
			cbTinh.DisplayMember = "TenTinh";
			cbTinh.ValueMember = "MaTinh";
		}
		void Loadhuyen(int matinh)
		{
			cbHuyen.DataSource = DangkiDAO.Instance.Loadhuyen(matinh);
			cbHuyen.DisplayMember = "TenHuyen";
			cbHuyen.ValueMember = "MaHuyen";
		}

		private void tpThongtin_Click(object sender, EventArgs e)
		{

		}

		private void FmCudan_Load(object sender, EventArgs e)
		{
			Loadtinh();
		}

		private void cbTinh_SelectedValueChanged(object sender, EventArgs e)
		{

			Loadhuyen(cbTinh.SelectedIndex + 1);
			
		}
		void DKKinhdoanh()
		{
			string tenHKD = txtTenHKD.Text;
			int matinh = cbTinh.SelectedIndex;
			int mahuyen = cbHuyen.SelectedIndex;
			string diachi = txtdiachi.Text;
			string sdt = txtSdtHKD.Text;
			string email = txtEmailHKD.Text;
			string website = txtWebHKD.Text;
			string nganhnghe = txtNgheHKD.Text;
			string vondangki = txtVonHKD.Text + " VND";
			string tendaidienHKD = txtTenchuHKD.Text;
			string gioitinh = cbGioitinhHKD.SelectedItem.ToString();
			DateTime ngaysinh = dtNgaysinhHKD.Value;
			string cccd = txtCccdHKD.Text;
			string quoctich = txtQuoctichHKD.Text;
			if (tenHKD == null || diachi == null || email == null)
			{
				MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN ĐĂNG KÍ");
			}
			else
			{
				if(HKDDAO.Instance.SubmitHKD(tenHKD, matinh, mahuyen, diachi, sdt, email, website, nganhnghe, vondangki, tendaidienHKD, gioitinh, ngaysinh, cccd, quoctich))
				{
					MessageBox.Show("ĐÃ GỬI ĐƠN ĐĂNG KÍ");
				}
				else MessageBox.Show("HÃY THỬ LẠI");

			}
			


		}
		private void btnKinhdoanh_Click(object sender, EventArgs e)
		{
			DKKinhdoanh();
		}
	}
}

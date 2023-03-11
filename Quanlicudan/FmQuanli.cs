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

namespace Quanlicudan
{
	public partial class FmQuanli : Form
	{
		private User loginUser;

		public User LoginUser { get => loginUser; set => loginUser = value; }

		public FmQuanli(User lguser)
		{
			InitializeComponent();
			this.loginUser = lguser;
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
			txtTimmaho.DataBindings.Add(new Binding("Text", dtgvCudan.DataSource, "MaHK"));
			txtTimten.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"TenCh"));
			//txtTimCMND.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"CMND"));
			txtTimsdt.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"SDT"));
			txtTimdiachi.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"diachi"));
			txtTimgioitinh.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"Gioitinh"));
			txtTimNamsinh.DataBindings.Add(new Binding("Text",dtgvCudan.DataSource,"namsinhCH"));
			nrNhankhau.DataBindings.Add(new Binding("Value",dtgvCudan.DataSource,"sothanhvien"));
		}
		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}

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
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			ChuhoBUS.Instance.LoadChuho(dtgvCudan);
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
	}
}

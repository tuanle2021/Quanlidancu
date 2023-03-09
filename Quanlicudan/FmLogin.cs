using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlicudan
{
	public partial class FmLogin : Form
	{
		public FmLogin()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Trở về Trang chủ", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.No)
			{
				FmMain f = new FmMain();
				f.Show();
				this.Hide();
			}
			;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			FmQuanli f = new FmQuanli();
			f.Show();
			this.Hide();
		}
	}
}

using DAO;
using DTO;
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
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			/*if (login(username, password))
			{
				User loginUser = UserDAO.Instance.GetUserbyUsername(username);
				FmQuanli f = new FmQuanli(loginUser);
				f.Show();
				this.Hide();
			}*/

			if (login(username, password))
			{
				if(checkroles(username))
				{
					User loginUser = UserDAO.Instance.GetUserbyUsername(username);
					FmQuanli f = new FmQuanli(loginUser);
					f.Show();
					this.Hide();
				}
				else
				{
					User loginUser = UserDAO.Instance.GetUserbyUsername(username);
					FmCudan f = new FmCudan(loginUser);
					f.Show();
					this.Hide();
				}
			}
			else
				MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Cảnh báo", MessageBoxButtons.YesNo);
		}
		bool login(string username, string password)
		{
			return UserDAO.Instance.login(username,password);
		}
		bool checkroles(string username)
		{
			return UserDAO.Instance.checkroles(username);
		}
		private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
		{

		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace Quanlicudan
{
	public partial class FmUserprofile : Form
	{
		private User loginUser;
		public User LoginUser { get => loginUser;
			set {loginUser=value; ChangeUser(loginUser); }
		}
		public FmUserprofile(User acc)
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
			if(!newpass.Equals(enternewpass))
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
			}
			else
			{
				if(UserDAO.Instance.UpdateUser(username,fullname,password,newpass))
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
			txtDiaban.Text = acc.Madiaban;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Updateuser();
		}
	}
}

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

		

		public void ChangeUser(User acc)
		{
			loginUser = acc;
			txtUsername.Text = acc.Username;
			txtFullname.Text = acc.Ten;
			txtDiaban.Text = acc.Madiaban;
		}
	}
}

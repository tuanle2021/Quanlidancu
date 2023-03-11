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
	public partial class FmDancu : Form
	{
		private User loginUser;

		public User LoginUser { get => loginUser; set => loginUser = value; }
		public FmDancu(User lguser)
		{
			InitializeComponent();
			this.loginUser = lguser;
		}
	}
}

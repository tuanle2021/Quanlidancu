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
	public partial class FmKETHON : Form
	{
		public FmKETHON()
		{
			InitializeComponent();
		}

		private void FmKETHON_Load(object sender, EventArgs e)
		{
			KethonDAO.Instance.LoadDonDKKH(dtgvKETHON);
		}
	}
}

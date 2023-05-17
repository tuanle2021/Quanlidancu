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

		private void btnDuyet_Click(object sender, EventArgs e)
		{
			int index = dtgvKETHON.CurrentRow.Index;
			int id = (int)dtgvKETHON.Rows[index].Cells["Id"].Value;
			if (KethonDAO.Instance.DuyetdonKethon(id))
			{
				MessageBox.Show("");
				string cccdchong = dtgvKETHON.Rows[index].Cells["CCCDChong"].Value.ToString();
				string cccdvo = dtgvKETHON.Rows[index].Cells["CCCDVo"].Value.ToString();
				KethonDAO.Instance.SetTTHonnhan(cccdchong);
				KethonDAO.Instance.SetTTHonnhan(cccdvo);
				KethonDAO.Instance.LoadDonDKKH(dtgvKETHON);
			}
			else
				MessageBox.Show("");
		}
	}
}

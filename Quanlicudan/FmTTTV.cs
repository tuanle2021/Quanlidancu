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
	public partial class FmTTTV : Form
	{
		public FmTTTV()
		{
			InitializeComponent();
			
		}

		private void FmTTTV_Load(object sender, EventArgs e)
		{
			TamtruDAO.Instance.LoadDonTTTV(dtgvTTTV);
		}

		private void btnDuyet_Click(object sender, EventArgs e)
		{
			int index = dtgvTTTV.CurrentRow.Index;
			int id = (int)dtgvTTTV.Rows[index].Cells["id"].Value;
			if(TamtruDAO.Instance.DuyetdonTTTV(id))
			{
				MessageBox.Show("Đã duyệt đơn");
				TamtruDAO.Instance.LoadDonTTTV(dtgvTTTV);
			}
			else
			{
				MessageBox.Show("Xin thử lại");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int index = dtgvTTTV.CurrentRow.Index;
			int id = (int)dtgvTTTV.Rows[index].Cells["id"].Value;
			if (TamtruDAO.Instance.XoadonTTTV(id))
			{
				MessageBox.Show("Đã xoá đơn");
				TamtruDAO.Instance.LoadDonTTTV(dtgvTTTV);
			}
			else
			{
				MessageBox.Show("Xin thử lại");
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

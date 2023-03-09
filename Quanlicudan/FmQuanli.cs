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

namespace Quanlicudan
{
	public partial class FmQuanli : Form
	{
		public FmQuanli()
		{
			InitializeComponent();
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			ChuhoBUS.Instance.LoadChuho(dtgvCudan);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAO;
namespace BUS
{
	public class ChuhoBUS
	{
		private static ChuhoBUS instance;

		public static ChuhoBUS Instance
		{
			get
			{
				if (instance == null)
					instance = new ChuhoBUS();
				return instance;
			}
		}
		private ChuhoBUS() { }
		public void LoadChuho(DataGridView data)
		{
			data.DataSource = ChuhoDAO.Instance.LoadChuho();
		}
	}
}

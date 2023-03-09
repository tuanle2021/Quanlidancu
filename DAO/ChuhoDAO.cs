using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
	public class ChuhoDAO
	{
		private static ChuhoDAO instance;

		public static ChuhoDAO Instance { get
			{
				if (instance == null)
					instance = new ChuhoDAO();
				return instance;
			}
		}
		private ChuhoDAO() { }
		public List<Chuho> LoadChuho()
		{
			List<Chuho> chuho = new List<Chuho>();
			string query = "select * from Chuho";
			DataTable data = DataProvider.Instance.ReadData(query);
			foreach(DataRow item in data.Rows )
			{
				string maHK = item.Cells["MaHK"].Value.ToString();
				string tenCH = item.Cells["TenCh"].Value.ToString();
				int soThanhvien = (int)item.Cells["sothanhvien"].Value;
				string sdt = item.Cells["SDT"].Value.ToString();
				string diachi = item.Cells["diachi"].Value.ToString();
				string namsinhCH = item.Cells["namsinhCH"].Value.ToString();
				string gioitinh = item.Cells["Gioitinh"].Value.ToString();
				Chuho newCH = new Chuho(maHK, tenCH, soThanhvien, sdt, diachi, namsinhCH, gioitinh);
				chuho.Add(newCH);

			}
			return chuho;
		}
	}
}

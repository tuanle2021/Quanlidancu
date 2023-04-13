using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
	public class DangkiDAO
	{
		private static DangkiDAO instance;

		public static DangkiDAO Instance
		{
			get { if (instance == null) instance = new DangkiDAO(); return instance; }

			private set { instance = value; }
		}
		public List<TINH> Loadtinh()
		{
			List<TINH> listtinh = new List<TINH>();
			DataTable data = DataProvider.Instance.ReadData("select * from dbo.TINH");
			foreach(DataRow item in data.Rows)
			{
				int matinh = (int)item["MaTinh"];
				string tentinh = item["TenTinh"].ToString();
				TINH newtinh = new TINH(matinh, tentinh);
				listtinh.Add(newtinh);

			}
			return listtinh;

		}
		public List<HUYEN> Loadhuyen(int matinh)
		{
			List<HUYEN> listhuyen = new List<HUYEN>();
			DataTable data = DataProvider.Instance.ReadData("select * from dbo.HUYEN where MaTinh = '" + matinh + "'");
			foreach (DataRow item in data.Rows)
			{
				int mahuyen = (int)item["MaHuyen"];
				string tenhuyen = item["TenHuyen"].ToString();
				HUYEN newhuyen = new HUYEN(mahuyen, tenhuyen);
				listhuyen.Add(newhuyen);

			}
			return listhuyen;

		}
	}
}

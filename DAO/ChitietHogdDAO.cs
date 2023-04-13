using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
	public class ChitietHogdDAO
	{
		private static ChitietHogdDAO instance;

		public static ChitietHogdDAO Instance
		{
			get { if (instance == null) instance = new ChitietHogdDAO(); return instance; }
			private set
			{
				instance = value;
			}
		}
		private ChitietHogdDAO() { }
		public List<ChitietHoGDModel> LoadHoGD(string mahk)
		{
			List<ChitietHoGDModel> hoGD = new List<ChitietHoGDModel>();
			DataTable data = DataProvider.Instance.ReadData("select * from ChitietHoGD where MaHK = '" + mahk + "'");
			foreach (DataRow item in data.Rows)
			{
				int id = (int)item["Id"];
				string maHK = item["MaHK"].ToString();
				string hoten = item["Hoten"].ToString();
				string sdt = item["SDT"].ToString();
				string gioitinh = item["Gioitinh"].ToString();
				string cccd = item["CCCD"].ToString();
				DateTime ngaysinh = (DateTime)item["Ngaysinh"];
				string quanheCH = item["QuanheCH"].ToString();
				ChitietHoGDModel newhoGD = new ChitietHoGDModel(id, maHK,hoten,gioitinh,cccd,sdt,ngaysinh,quanheCH);
				hoGD.Add(newhoGD);

			}
			return hoGD;
		}

	}
}

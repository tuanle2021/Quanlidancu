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
				string maHK = item["MaHK"].ToString();
				string tenCH = item["TenCh"].ToString();
				int soThanhvien = (int)item["sothanhvien"];
				string sdt = item["SDT"].ToString();
				string diachi = item["diachi"].ToString();
				string namsinhCH = item["namsinhCH"].ToString();
				string gioitinh = item["Gioitinh"].ToString();
				Chuho newCH = new Chuho(maHK, tenCH, soThanhvien, sdt, diachi, namsinhCH, gioitinh);
				chuho.Add(newCH);

			}
			return chuho;
		}
		public bool Themchuho(string maHK, string tenCH, string namsinh,string gioitinh,string sdt, string diachi, int sonhankhau)
		{
			string query =string.Format("insert dbo.Chuho (MaHK,TenCH,namsinhCH,Gioitinh,SDT,diachi,sothanhvien) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6})", maHK,tenCH,namsinh,gioitinh,sdt,diachi,sonhankhau);
			int result = DataProvider.Instance.ExecuteNonQuery(query);
			return result > 0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace DAO
{
	public class KethonDAO
	{
		private static KethonDAO instance;

		public static KethonDAO Instance {
			get {if(instance==null) instance = new KethonDAO();return instance; }
			private set { instance = value; } 
		}
		private KethonDAO() { }
		public bool KiemtraCCCD(string cccd)
		{
			string query = "SELECT * FROM dbo.ChitietHoGD where CCCD = N'" + cccd + "'";
			DataTable result = DataProvider.Instance.ReadData(query);
			return result.Rows.Count > 0;
		}
		public string GetTenbyCCCD(string cccd)
		{
			DataTable data = DataProvider.Instance.ReadData("select HoTen from dbo.ChitietHoGD where CCCD = '" + cccd + "'");
			foreach (DataRow item in data.Rows)
			{
				return item["HoTen"].ToString();
			}
			return null;
		}
		public bool Submit(string tenchong, string cccdchong, string tenvo, string cccdvo)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("insert into dbo.KETHON(TenChong,CCCDChong,TenVo,CCCDVo) values (N'" + tenchong + "', '" + cccdchong + "','" + tenvo + "','"+cccdvo + "')");
			return result > 0;
		}
		public List<KethonModel> LoadDKKH()
		{
			List<KethonModel> list = new List<KethonModel>();
			string query = "select * from dbo.KETHON";
			DataTable data = DataProvider.Instance.ReadData(query);
			foreach(DataRow item in data.Rows)
			{
				int id = (int)item["Id"];
				string tenchong = item["TenChong"].ToString();
				string cccdchong = item["CCCDChong"].ToString();
				string tenvo = item["TenVo"].ToString();
				string cccdvo = item["CCCDVo"].ToString();
				int state = (int)item["State"];
				KethonModel newkethon = new KethonModel(id, tenchong, cccdchong, tenvo, cccdvo, state);
				list.Add(newkethon);
			}
			return list;
		}
		public void LoadDonDKKH(DataGridView dtgv)
		{
			dtgv.DataSource = this.LoadDKKH();
		}
		public bool SetTTHonnhan(string cccd)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("update dbo.ChitietHoGD SET TTHonnhan = 1 where CCCD = N'"+ cccd + "'");
			return result > 0;
		}
		public bool DuyetdonKethon(int id)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("update dbo.KETHON set State = 1 where id = '" + id + "'");
			return result > 0;
		}
		public string GetDiachibyMaHK(string cccd)
		{
			DataTable data = DataProvider.Instance.ReadData("select Chuho.diachi from dbo.Chuho,dbo.ChitietHoGD where ChitietHoGD.CCCD = N'" + cccd + "' and Chuho.MaHK = ChitietHoGD.MaHK");
			foreach (DataRow item in data.Rows)
			{
				return item["diachi"].ToString();
			}
			return null;
		}
		public DateTime GetngaysinhbyCCCD(string cccd)
		{
			DataTable data = DataProvider.Instance.ReadData("select Ngaysinh from dbo.ChitietHoGD where CCCD = '" + cccd + "'");
			foreach (DataRow item in data.Rows)
			{
				return (DateTime)item["Ngaysinh"];
			}
			return DateTime.Today;
		}
	}
}

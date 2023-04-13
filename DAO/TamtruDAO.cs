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
	public class TamtruDAO
	{
		private static TamtruDAO instance;

		public static TamtruDAO Instance { 
			get { if (instance == null) instance = new TamtruDAO(); return instance; }
			private set { instance = value; }
		}
		private TamtruDAO() { }
		public bool Submit(string ten, string namsinh, string cccd, string dcthuongtru, string dctamtru, DateTime ngayden, DateTime ngaydi, string lido, int state)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("nsert into dbo.TTTV (Ten, namsinh, CCCD, DCthuongtru, DCtamtru, Ngayden,Ngaydi, Lido, State) values (N'"+ ten +"', N'" + namsinh + "', N'" + cccd + "', N'" + dcthuongtru + "', N'" + dctamtru + "', '" + ngayden + "', N'" + ngaydi + "', N'" + lido + "', '" + state + "')");
			return result > 0;
		}
		public List<TamtruModel> LoadTTTV()
		{
			List<TamtruModel> list = new List<TamtruModel>();
			string query = "select * from dbo.TTTV";
			DataTable data = DataProvider.Instance.ReadData(query);
			foreach(DataRow item in data.Rows)
			{
				int id = (int)item["id"];
				string ten = item["Ten"].ToString();
				string namsinh = item["namsinh"].ToString();
				string cccd = item["CCCD"].ToString();
				string dcthtru = item["DCthuongtru"].ToString();
				string dcttru = item["DCtamtru"].ToString();
				DateTime ngayden = (DateTime)item["Ngayden"];
				DateTime ngaydi = (DateTime)item["Ngaydi"];
				string lido = item["Lido"].ToString();
				int state = (int)item["State"];
				TamtruModel newTTTV = new TamtruModel(id, ten, namsinh, cccd, dcthtru, dcttru, ngayden, ngaydi, lido, state);
				list.Add(newTTTV);
			}
			return list;
		}
		public void LoadDonTTTV(DataGridView data )
		{
			data.DataSource = this.LoadTTTV();
		}
		public bool DuyetdonTTTV(int id)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("update dbo.TTTV set State = 1 where id = '" + id + "'");
			return result > 0;
		}
		public bool XoadonTTTV(int id)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("delete from dbo.TTTV where id = '" + id + "'");
			return result > 0;
		}
	}
}

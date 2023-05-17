using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
	public class KhaisinhDAO
	{
		private static KhaisinhDAO instance;

		public static KhaisinhDAO Instance {
			get { if (instance == null) instance = new KhaisinhDAO(); return instance; }
			private set { instance = value; }
		}
		private KhaisinhDAO() { }
		public bool Submit(string hoten, string gioitinh, DateTime ngaysinh,string quequan, string noisinh, string cccdme,string cccdcha)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("insert into dbo.KHAISINH(Hoten,Gioitinh,Ngaysinh,Quequan,Noisinh,CCCDMe,CCCDCha) values (N'" + hoten + "', N'" + gioitinh + "', '" + ngaysinh + "','" + quequan + "', '" + noisinh + "', '" + cccdme + "', '" + cccdcha + "')");
			return result > 0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
	public class AdminDAO
	{
		private static AdminDAO instance;

		public static AdminDAO Instance
		{
			get { if (instance == null) instance = new AdminDAO(); return instance; }

			private set { instance = value; }
		}
		private AdminDAO() { }
		//dang nhap
		public bool login(string username, string password)
		{
			string query = "SELECT * FROM dbo.Admin where Username = N'" + username + "' and Password = N'" + password + "'";
			DataTable result = DataProvider.Instance.ReadData(query);
			return result.Rows.Count > 0;
		}
		public bool checkroles(string username)
		{
			return true;
		}
		//lay user theo username
		public Admin GetUserbyUsername(string username)
		{
			DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.Admin where Username = '" + username + "'");
			foreach (DataRow item in data.Rows)
			{
				return new Admin(item);
			}
			return null;
		}

		//update user
		public bool UpdateUser(string username, string fullname, string password, string newpass)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAdmin '" + username + "' , '" + fullname + "', '" + password + "', '" + newpass + "'");
			return result > 0;
		}
	}
}

using DTO;
using System.Data;

namespace DAO
{
	public class UserDAO
	{
		private static UserDAO instance;

		public static UserDAO Instance
		{
			get { if (instance == null) instance = new UserDAO(); return instance; }

			private set { instance = value; }
		}
		private UserDAO() { }
		//dang nhap
		public bool login(string username, string password)
		{
			string query = "SELECT * FROM dbo.Users where Username = N'" + username + "' and Password = N'" + password + "'";
			DataTable result = DataProvider.Instance.ReadData(query);
			return result.Rows.Count > 0;
		}
		public bool checkroles(string username)
		{
			string query = "SELECT * FROM dbo.Users where Username = N'" + username + "' and Roles = 1";
			DataTable result = DataProvider.Instance.ReadData(query);
			return result.Rows.Count > 0;
		}
		//lay user theo username
		public User GetUserbyUsername(string username)
		{
			DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.Users where Username = '" + username + "'");
			foreach (DataRow item in data.Rows)
			{
				return new User(item);
			}
			return null;
		}

		//update user
		public bool UpdateUser(string username,string fullname, string password, string newpass)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateUser '" + username + "' , '" + fullname + "', '" + password + "', '" + newpass + "' ");
			return result > 0;
		}
	}
}

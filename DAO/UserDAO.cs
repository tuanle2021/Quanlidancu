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
		public bool login(string username, string password)
		{
			string query = "SELECT * FROM dbo.Users where Username = N'" + username + "' and Password = N'" + password + "'";
			DataTable result = DataProvider.Instance.ReadData(query);
			return result.Rows.Count > 0;
		}
		public User GetUserbyUsername(string username)
		{
			DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.Users where Username = '" + username + "'");
			foreach (DataRow item in data.Rows)
			{
				return new User(item);
			}
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class User
	{
		private string id;
		private string username;
		private string password;
		private string ten;
		private string namsinh;
		private string gioitinh;
		private string madiaban;

		public string Id { get => id; set => id = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Ten { get => ten; set => ten = value; }
		public string Namsinh { get => namsinh; set => namsinh = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public string Madiaban { get => madiaban; set => madiaban = value; }
		public User(string id, string username,string password,string ten,string namsinh, string gioitinh, string madiaban)
		{
			this.id = id;
			this.username = username;
			this.password = password;
			this.ten = ten;
			this.namsinh = namsinh;
			this.gioitinh = gioitinh;
			this.madiaban = madiaban;
		}
		public User(DataRow row)
		{
			this.id =row["id"].ToString();
			this.username =row["username"].ToString();
			this.password =row["password"].ToString();
			this.ten =row["ten"].ToString();
			this.namsinh = row["namsinh"].ToString();
			this.gioitinh = row["gioitinh"].ToString();
			this.madiaban = row["madiaban"].ToString();
		}
	}
}

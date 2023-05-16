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
		private int id;
		private string username;
		private string password;
		private string ten;
		private DateTime namsinh;
		private string gioitinh;
		private int tTHonnhan;

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Ten { get => ten; set => ten = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public int Id { get => id; set => id = value; }
		public DateTime Namsinh { get => namsinh; set => namsinh = value; }
		public int TTHonnhan { get => tTHonnhan; set => tTHonnhan = value; }

		public User(int id, string username,string password,string ten,DateTime namsinh, string gioitinh, int tthonnhan)
		{
			this.Id = id;
			this.username = username;
			this.password = password;
			this.ten = ten;
			this.Namsinh = namsinh;
			this.gioitinh = gioitinh;
			this.tTHonnhan = tthonnhan;
		}
		public User(DataRow row)
		{
			this.Id =(int)row["id"];
			this.username =row["username"].ToString();
			this.password =row["password"].ToString();
			this.ten =row["HoTen"].ToString();
			this.Namsinh = (DateTime)row["Ngaysinh"];
			this.gioitinh = row["Gioitinh"].ToString();
			this.tTHonnhan = (int)row["TTHonnhan"];
		}
	}
}

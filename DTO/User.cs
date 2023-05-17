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
		private string mahk;
		private string username;
		private string password;
		private string ten;
		private DateTime namsinh;
		private string gioitinh;
		private int tTHonnhan;
		private string cccd;

		public int Id { get => id; set => id = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Ten { get => ten; set => ten = value; }
		public DateTime Namsinh { get => namsinh; set => namsinh = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public int TTHonnhan { get => tTHonnhan; set => tTHonnhan = value; }
		public string Cccd { get => cccd; set => cccd = value; }
		public string Mahk { get => mahk; set => mahk = value; }

		public User(int id,string mahk, string ten, string gioitinh, string cccd, DateTime namsinh, int tthonnhan, string username,string password)
		{
			this.Id = id;
			this.Mahk = mahk;
			this.Ten = ten;
			this.Gioitinh = gioitinh;
			this.Cccd = cccd;
			this.Namsinh = namsinh;
			this.TTHonnhan = tthonnhan;
			this.Username = username;
			this.Password = password;		
		}
		public User(DataRow row)
		{
			this.Id =(int)row["Id"];
			this.Mahk = row["MaHK"].ToString();
			this.Ten = row["HoTen"].ToString();
			this.Gioitinh = row["Gioitinh"].ToString();
			this.Cccd = row["CCCD"].ToString();
			this.Namsinh = (DateTime)row["Ngaysinh"];
			this.TTHonnhan = (int)row["TTHonnhan"];
			this.Username =row["username"].ToString();
			this.Password =row["password"].ToString();	
			
			
		}
	}
}

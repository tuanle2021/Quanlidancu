﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Admin
	{
		private string id;
		private string username;
		private string password;
		private string ten;
		private string namsinh;
		private string gioitinh;
		private int madiaban;
		private int roles;


		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Ten { get => ten; set => ten = value; }
		public string Namsinh { get => namsinh; set => namsinh = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public int Madiaban { get => madiaban; set => madiaban = value; }
		public int Roles { get => roles; set => roles = value; }
		public string Id { get => id; set => id = value; }

		public Admin(string id, string username, string password, string ten, string namsinh, string gioitinh, int madiaban, int roles)
		{
			this.Id = id;
			this.username = username;
			this.password = password;
			this.ten = ten;
			this.namsinh = namsinh;
			this.gioitinh = gioitinh;
			this.Madiaban = madiaban;
			this.roles = roles;
		}
		public Admin(DataRow row)
		{
			this.Id = row["id"].ToString();
			this.username = row["username"].ToString();
			this.password = row["password"].ToString();
			this.ten = row["ten"].ToString();
			this.namsinh = row["namsinh"].ToString();
			this.gioitinh = row["gioitinh"].ToString();
			this.Madiaban = (int)row["madiaban"];
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
	public class KhaisinhModel
	{
		private int id;
		private string hoten;
		private string gioitinh;
		private DateTime ngaysinh;
		private string quequan;
		private string noisinh;
		private string cccdMe;
		private string cccdCha;

		public int Id { get => id; set => id = value; }
		public string Hoten { get => hoten; set => hoten = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
		public string Quequan { get => quequan; set => quequan = value; }
		public string Noisinh { get => noisinh; set => noisinh = value; }
		public string CccdMe { get => cccdMe; set => cccdMe = value; }
		public string CccdCha { get => cccdCha; set => cccdCha = value; }
		public KhaisinhModel(int id, string hoten, string gioitinh,DateTime ngaysinh,string quequan,string noisinh, string cccdMe,string cccdCha)
		{
			this.id = id;
			this.hoten = hoten;
			this.gioitinh = gioitinh;
			this.ngaysinh = ngaysinh;
			this.quequan = quequan;
			this.noisinh = noisinh;
			this.cccdMe = cccdMe;
			this.cccdCha = cccdCha;
		}
		public KhaisinhModel(DataRow row)
		{
			this.id = (int)row["Id"];
			this.hoten = row["Hoten"].ToString();
			this.gioitinh = row["Gioitinh"].ToString();
			this.ngaysinh = (DateTime)row["Ngaysinh"];
			this.quequan = row["Quequan"].ToString();
			this.noisinh = row["Noisinh"].ToString();
			this.cccdMe = row["CCCDMe"].ToString();
			this.cccdCha = row["CCCDCha"].ToString();
		}
	}
}

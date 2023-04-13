using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
	public class ChitietHoGDModel
	{
		private int id;
		private string maHK;
		private string hoten;
		private string gioitinh;
		private string cCCD;
		private string sdt;
		private DateTime ngaysinh;
		private string quanheCH;

		public int Id { get => id; set => id = value; }
		public string MaHK { get => maHK; set => maHK = value; }
		public string Hoten { get => hoten; set => hoten = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public string CCCD { get => cCCD; set => cCCD = value; }
		public string Sdt { get => sdt; set => sdt = value; }
		public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
		public string QuanheCH { get => quanheCH; set => quanheCH = value; }
		public ChitietHoGDModel(int id, string maHK, string hoten,string gioitinh, string cccd, string sdt, DateTime ngaysinh, string quanheCH)
		{
			this.id = id;
			this.maHK = maHK;
			this.hoten = hoten;
			this.gioitinh = gioitinh;
			this.cCCD = cccd;
			this.sdt = sdt;
			this.ngaysinh = ngaysinh;
			this.quanheCH = quanheCH;
		}
		public ChitietHoGDModel(DataRow row)
		{
			this.id = (int)row["ID"];
			this.maHK = row["MaHK"].ToString();
			this.hoten = row["Hoten"].ToString();
			this.gioitinh = row["Gioitinh"].ToString();
			this.cCCD = row["CCCD"].ToString();
			this.sdt = row["SDT"].ToString();
			this.ngaysinh = (DateTime)row["Ngaysinh"];
			this.quanheCH = row["QuanheCH"].ToString();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
	public class Chuho
	{
		private string maHK;
		private string tenCH;
		private int soThanhvien;
		private string sdt;
		private string diachi;
		private string namsinhCH;
		private string gioitinh;
		private string cCCD;
		private int maTinh;

		public string MaHK { get => maHK; set => maHK = value; }
		public string TenCH { get => tenCH; set => tenCH = value; }
		public int SoThanhvien { get => soThanhvien; set => soThanhvien = value; }
		public string Sdt { get => sdt; set => sdt = value; }
		public string Diachi { get => diachi; set => diachi = value; }
		public string NamsinhCH { get => namsinhCH; set => namsinhCH = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public string CCCD { get => cCCD; set => cCCD = value; }
		public int MaTinh { get => maTinh; set => maTinh = value; }

		public Chuho(string maHK, string tenCH, int soThanhvien, string sdt, string diachi, string namsinhCH, string gioitinh, string cccd, int matinh)
		{
			this.maHK = maHK;
			this.tenCH = tenCH;
			this.soThanhvien = soThanhvien;
			this.sdt = sdt;
			this.diachi = diachi;
			this.namsinhCH = namsinhCH;
			this.gioitinh = gioitinh;
			this.cCCD = cccd;
			this.maTinh = matinh;
		 }
		public Chuho(DataRow row)
		{
			this.maHK = row["MaHK"].ToString();
			this.tenCH = row["TenCH"].ToString();
			this.soThanhvien = (int)row["sothanhvien"];
			this.sdt = row["SDT"].ToString();
			this.diachi = row["diachi"].ToString();
			this.namsinhCH = row["namsinhCH"].ToString();
			this.gioitinh = row["Gioitinh"].ToString();
			this.cCCD = row["CCCD"].ToString();
			this.maTinh = (int)row["MaTinh"];
		}

	}
}

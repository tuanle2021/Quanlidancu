using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public string MaHK { get => maHK; set => maHK = value; }
		public string TenCH { get => tenCH; set => tenCH = value; }
		public int SoThanhvien { get => soThanhvien; set => soThanhvien = value; }
		public string Sdt { get => sdt; set => sdt = value; }
		public string Diachi { get => diachi; set => diachi = value; }
		public string NamsinhCH { get => namsinhCH; set => namsinhCH = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public Chuho(string maHK, string tenCH, int soThanhvien, string sdt, string diachi, string namsinhCH, string gioitinh)
		{
			this.maHK = maHK;
			this.tenCH = tenCH;
			this.soThanhvien = soThanhvien;
			this.sdt = sdt;
			this.diachi = diachi;
			this.namsinhCH = namsinhCH;
			this.gioitinh = gioitinh;

		}
	}
}

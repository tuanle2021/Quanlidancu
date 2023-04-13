using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class HokinhdoanhModel
	{
		private int id;
		private string tenHKD;
		private int matinh;
		private int mahuyen;
		private string diadiem;
		private string sdt;
		private string email;
		private string website;
		private string nganhnghe;
		private string vonKD;
		private string tenDaidienHKD;
		private string gioitinh;
		private DateTime ngaysinh;
		private string cccd;
		private string quoctich;

		public int Id { get => id; set => id = value; }
		public string TenHKD { get => tenHKD; set => tenHKD = value; }
		public int Matinh { get => matinh; set => matinh = value; }
		public int Mahuyen { get => mahuyen; set => mahuyen = value; }
		public string Diadiem { get => diadiem; set => diadiem = value; }
		public string Sdt { get => sdt; set => sdt = value; }
		public string Email { get => email; set => email = value; }
		public string Website { get => website; set => website = value; }
		public string Nganhnghe { get => nganhnghe; set => nganhnghe = value; }
		public string VonKD { get => vonKD; set => vonKD = value; }
		public string TenDaidienHKD { get => tenDaidienHKD; set => tenDaidienHKD = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
		public string Cccd { get => cccd; set => cccd = value; }
		public string Quoctich { get => quoctich; set => quoctich = value; }
	}
}

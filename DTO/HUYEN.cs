using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
	public class HUYEN
	{
		private int mahuyen;
		private string tenhuyen;
		public int Mahuyen { get => mahuyen; set => mahuyen = value; }
		public string Tenhuyen { get => tenhuyen; set => tenhuyen = value; }
		public HUYEN(int maHuyen, string tenHuyen)
		{
			this.mahuyen = maHuyen;
			this.tenhuyen = tenHuyen;
		}
		public HUYEN(DataRow row)
		{
			this.mahuyen = (int)row["MaHuyen"];
			this.tenhuyen = row["TenHuyen"].ToString();
		}
	}
}

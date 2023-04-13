using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
	public class TINH
	{
		private int matinh;
		private string tentinh;

		public int Matinh { get => matinh; set => matinh = value; }
		public string Tentinh { get => tentinh; set => tentinh = value; }
		public TINH(int maTinh, string tenTinh)
		{
			this.matinh = maTinh;
			this.tentinh = tenTinh;
		}
		public TINH(DataRow row)
		{
			this.matinh = (int)row["MaTinh"];
			this.tentinh = row["TenTinh"].ToString();
		}
	}
}

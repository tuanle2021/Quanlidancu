using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace DAO
{
	public class HKDDAO
	{
		private static HKDDAO instance;

		public static HKDDAO Instance {
			get { if (instance == null) instance = new HKDDAO(); return instance; }
			private set { instance = value; }
		}
		private HKDDAO() { }
		public bool SubmitHKD(string tenHKD, int matinh, int mahuyen, string diachi, string sdt , string email, string website, string nganhnghe, string vondangki, string tendaidienHKD, string gioitinh,DateTime ngaysinh, string cccd, string quotich)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("insert into dbo.DangkiKD (TenhoKD, MaTinh, MaHuyen, DiaDiem, SDT, Email, Website, Nganhnghe, Von, Tendaidien, Gioitinh, Ngaysinh, CCCD, Quoctich) values (N'" + tenHKD + "', '" + matinh + "', '" + mahuyen + "', N'" + diachi + "', N'" + sdt + "', '" + email + "', N'" + website + "', N'" + nganhnghe + "', N'" + vondangki + "', N'" + tendaidienHKD + "', N'" + gioitinh + "', N'" + ngaysinh + "', N'" + cccd + "', N'" + quotich + "')");
			return result > 0;
		}
	}
}

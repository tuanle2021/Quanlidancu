using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TamtruModel
	{
		private int id;
		private string ten;
		private string namsinh;
		private string cCCD;
		private string dcthuongtru;
		private string dctamtru;
		private DateTime ngayden;
		private DateTime ngaydi;
		private string lido;
		private int state;

		public int Id { get => id; set => id = value; }
		public string Ten { get => ten; set => ten = value; }
		public string Namsinh { get => namsinh; set => namsinh = value; }
		public string CCCD { get => cCCD; set => cCCD = value; }
		public string Dcthuongtru { get => dcthuongtru; set => dcthuongtru = value; }
		public string Dctamtru { get => dctamtru; set => dctamtru = value; }
		public DateTime Ngayden { get => ngayden; set => ngayden = value; }
		public DateTime Ngaydi { get => ngaydi; set => ngaydi = value; }
		public string Lido { get => lido; set => lido = value; }
		public int State { get => state; set => state = value; }
		public TamtruModel(int id, string ten, string namsinh,string cccd, string dcthuongtru, string dctamtru, DateTime ngayden, DateTime ngaydi, string lido, int state)
		{
			this.id = id;
			this.ten = ten;
			this.namsinh = namsinh;
			this.cCCD = cccd;
			this.dcthuongtru = dcthuongtru;
			this.dctamtru = dctamtru;
			this.ngayden = ngayden;
			this.ngaydi = ngaydi;
			this.lido = lido;
			this.state = state;
		}
	}
}

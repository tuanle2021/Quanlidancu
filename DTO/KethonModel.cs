using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
	public class KethonModel
	{
		private int id;
		private string tenchong;
		private string cccdchong;
		private string tenvo;
		private string cccdvo;
		private int state;

		public int Id { get => id; set => id = value; }
		public string Tenchong { get => tenchong; set => tenchong = value; }
		public string Cccdchong { get => cccdchong; set => cccdchong = value; }
		public string Tenvo { get => tenvo; set => tenvo = value; }
		public string Cccdvo { get => cccdvo; set => cccdvo = value; }
		public int State { get => state; set => state = value; }
		public KethonModel(int id,string tenchong, string cccdchong,string tenvo,string cccdvo,int state)
		{
			this.id = id;
			this.tenchong = tenchong;
			this.cccdchong = cccdchong;
			this.tenvo = tenvo;
			this.cccdvo = cccdvo;
			this.state = state;
		}
		public KethonModel(DataRow row)
		{
			this.id = (int)row["Id"];
			this.tenchong = row["TenChong"].ToString();
			this.cccdchong = row["CCCDChong"].ToString();
			this.tenvo = row["TenVo"].ToString();
			this.cccdvo = row["CCCDVo"].ToString();
			this.state = (int)row["State"];
		}
	}
}

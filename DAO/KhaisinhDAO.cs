using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
	public class KhaisinhDAO
	{
		private static KhaisinhDAO instance;

		public static KhaisinhDAO Instance {
			get { if (instance == null) instance = new KhaisinhDAO(); return instance; }
			private set { instance = value; }
		}
		private KhaisinhDAO() { }

	}
}

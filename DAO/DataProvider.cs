using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
	public class DataProvider
	{
		private static DataProvider instance;
		SqlConnection conn = null;

		public static DataProvider Instance { 
			get {
				if(instance==null)
				{
					instance = new DataProvider();
				}
				return instance;
				}
		}

		//Mo ket noi
		public void Openconnect()
		{
			conn = new SqlConnection(Properties.Settings.Default.connStr);
			if (conn.State != ConnectionState.Open)
				conn.Open();
		}
		//Tra ve table
		public DataTable ReadData(string sqlSelect)
		{
			DataTable dt = new DataTable();
			Openconnect();
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, conn);
			sqlData.Fill(dt);
			CloseConnect();
			return dt;
		}
		public DataTable ExcuteQuery(string sqlSelect)
		{
			DataTable dt = new DataTable();
			Openconnect();
			SqlCommand command = new SqlCommand(sqlSelect, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dt);
			CloseConnect();
			return dt;
		}
		//Cac lenh Insert dele....
		public int ExecuteNonQuery(string sqlSelect)
		{
			Openconnect();
			int data = 0;
			SqlCommand command = new SqlCommand(sqlSelect, conn);
			data = command.ExecuteNonQuery();
			CloseConnect();
			return data;
		}
		//Dong ket noi
		void CloseConnect()
		{
			if (conn.State != ConnectionState.Closed)
			{
				conn.Close();
				conn.Dispose();

			}
		}
	}
}

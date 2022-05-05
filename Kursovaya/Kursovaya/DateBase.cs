using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursovaya
{
	public class DateBase
	{
		public static SqlConnection connection = new SqlConnection(@"Data Source=408-010;Initial Catalog=BookShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		public static SqlDataAdapter adapter;
		public static SqlCommand m_sqlCmd = new SqlCommand();
		
		
		public static bool comandsToBD(string c)//возвращает true если команда выполнена
		{
			DateBase.connection.Open();
			if (connection.State != ConnectionState.Open)
			{
				MessageBox.Show("Не могу найти базу данных"); return false;
			}

			try
			{
				m_sqlCmd.CommandText = c;
				m_sqlCmd.ExecuteNonQuery();
				DateBase.connection.Close();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка базы данных \n" + ex.Message);
				DateBase.connection.Close();
				return false;
			}
			DateBase.connection.Close();
		}
		public static DataTable selectBD(string c)
		{
			DataTable dTable = new DataTable();
			String sqlQuery;

			connection.Open();
			m_sqlCmd.Connection = connection;

			if (connection.State != ConnectionState.Open)
			{
				MessageBox.Show("Не могу найти базу данных"); return null;
			}

			try
			{
				sqlQuery = c;
				SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
				adapter.Fill(dTable);
				return dTable;
			}
			catch
			{
				MessageBox.Show("Ошибка базы данных");
				return null;
			}
		}





	}
}

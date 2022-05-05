using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursovaya
{
	public partial class Check : Form
	{
		public Check()
		{
			InitializeComponent();
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			int check_num = Convert.ToInt32(t_check.Text);
			SqlCommand command = new SqlCommand("SELECT * FROM Sell,Books where Sell.id_book = Books.id and Sell.check_num = " + check_num, DateBase.connection);
			var adapter = new SqlDataAdapter(command);
			var Table = new DataTable();
			try
			{
				string s = "Книжный магазин\n Номер чека: " + check_num + "\n";
				s += "------------------------------------\n";
				decimal sum = 0;
				DateBase.connection.Open();
				adapter.Fill(Table);
				BookSell bk = new BookSell();
				for (int i = 0; i < Table.Rows.Count; ++i)
				{
					bk = new BookSell();
					bk.id = (int)Table.Rows[i]["id"];
					bk.amount = (int)Table.Rows[i]["amount"];
					bk.price = (int)Table.Rows[i]["price"];
					bk.bookid = (int)Table.Rows[i]["id_book"];
					bk.name = (string)Table.Rows[i]["name"];
					bk.check_num = (int)Table.Rows[i]["check_num"];
					bk.date = (DateTime)Table.Rows[i]["date"];
					s += "Название: " + bk.name.Replace(" ", "") + ". Количество: " + bk.amount + ". Цена: " + bk.price + ". Сумма: " + (bk.amount * bk.price);
					s += "\n";
					sum += bk.amount * bk.price;
				}
				DateBase.connection.Close();
				s += "------------------------------------\n";
				s += $"Итого: {sum}";
				tb_check.Text = s;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DateBase.connection.Close();
			}

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

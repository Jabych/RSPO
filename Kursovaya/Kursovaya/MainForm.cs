using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Kursovaya
{
	public partial class MainForm : Form
	{
		bool admin;

		public MainForm()
		{
			InitializeComponent();
		}


		public int Parol(string Par)  //	кодируем пароль
		{
			int S = 0;
			foreach (var V in Par)
			{
				S = (S + V) * 4567;
			}
			return S;
		}
		bool proverka(string Name, string Password)
		{

			String sqlQuery = "SELECT * FROM User2 where nickname = '" + Name + "'";

			SqlCommand command = new SqlCommand(sqlQuery, DateBase.connection);
			var adapter = new SqlDataAdapter(command);
			var Table = new DataTable();
			try
			{
				DateBase.connection.Open();
				adapter.Fill(Table);
				if (Table.Rows.Count > 0)
				{
					int G = Parol(Password);
					if (G == (int)Table.Rows[0].ItemArray[2])
					{
						admin = ((int)Table.Rows[0].ItemArray[3] == 0);
						DateBase.connection.Close();
						return true;
					}
					else
					{
						MessageBox.Show("Пароль не верный");
						DateBase.connection.Close();
						return false;
					}


				}
				else
				{
					MessageBox.Show("Такого пользователя нет");
					DateBase.connection.Close();
					return false;
				}

				DateBase.connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DateBase.connection.Close();
			}



			return true;
		}
		public DataTable selectBD(string c)
		{
			DataTable dTable = new DataTable();
			String sqlQuery;

			DateBase.connection.Open();
			DateBase.m_sqlCmd.Connection = DateBase.connection;


			if (DateBase.connection.State != ConnectionState.Open)
			{
				MessageBox.Show("Не могу найти базу данных");
				DateBase.connection.Close();
				return null;
			}

			try
			{
				sqlQuery = c;
				SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, DateBase.connection);
				adapter.Fill(dTable);
				DateBase.connection.Close();
				return dTable;
			}
			catch
			{
				MessageBox.Show("Ошибка базы данных");
				DateBase.connection.Close();
				return null;
			}
		}
		public void add(string Name, string Password, bool Admin)
		{
			DateBase.connection.Open();

			if (DateBase.connection.State != ConnectionState.Open)
			{
				MessageBox.Show("Не могу найти базу данных"); return;
			}

			try
			{
				int p = Parol(Password);
				DateBase.m_sqlCmd.CommandText = "INSERT INTO User2 (Nickname, Password, Type) values ('" + Name + "' , " + p + ", '" + (Admin ? 0 : 1) + "')";
				DateBase.m_sqlCmd.ExecuteNonQuery();
				MessageBox.Show("Пользователь успешно добавлен", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка базы данных \n" + ex.Message);
			}
			DateBase.connection.Close();
		}

		public void update(long id, string Name, string Password, bool Admin)
		{
			DateBase.connection.Open();

			if (DateBase.connection.State != ConnectionState.Open)
			{
				MessageBox.Show("Не могу найти базу данных");
				return;
			}

			try
			{
				int p = Parol(Password);
				DateBase.m_sqlCmd.CommandText = "update User2 set Nickname= '" + Name + "' , Password = '" + p + "', Type = '" + (Admin ? 0 : 1) + "' where id = " + id;
				DateBase.m_sqlCmd.ExecuteNonQuery();
				MessageBox.Show("Пользователь успешно исправлен", "Исправление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка базы данных \n" + ex.Message);
			}
			DateBase.connection.Close();
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			Visible = false;

			FormUserPassword WinFUP = new FormUserPassword();
			DialogResult P = WinFUP.ShowDialog();
			if (P != DialogResult.OK) { 
				Close();
				return;
			}
			else
				{
				string Name = WinFUP.textBox1.Text;
				string Password = WinFUP.textBox2.Text;
				if (proverka(Name, Password) == false)
				{
					Close();
					return;
				}
				else
				{
					if (admin)
					{
						panel.Visible = false;

						//создаем форму с закладками
						admiSelectControl admiSelectControl = new admiSelectControl();
						admiSelectControl.Parent = MainPanel;
						admiSelectControl.Dock = DockStyle.Fill;


						//создается панель администратора для работы с пользователем
						admincontrol admincontrol = new admincontrol(this);
						admincontrol.Parent = admiSelectControl.tabPage1;
						admincontrol.Dock = DockStyle.Fill;

						admincontrol.ReLoadListBox();

					}
				}
			}
			Visible = true;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Prihod pr = new Prihod();
			this.Visible = false;
			pr.ShowDialog();
			this.Visible = true; 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Nalichie nal = new Nalichie();
			this.Visible = false;
			nal.ShowDialog();
			this.Visible = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Sell sl = new Sell();
			this.Visible = false;
			sl.ShowDialog();
			this.Visible = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			info info = new info();
			info.ShowDialog();
		}

		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.Size = new Size(60, 60);
			pictureBox1.Cursor = Cursors.Hand;
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.Size = new Size(50, 50);
			pictureBox1.Cursor = Cursors.Arrow;
		}
	}
}

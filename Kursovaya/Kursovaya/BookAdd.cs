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
	public partial class BookAdd : Form
	{
		public BookType bt = BookType.Book;
		Book bk = new Book();

		public BookAdd(BookType bt1)
		{
			InitializeComponent();

			bt = bt1;
			if (bt != BookType.Book)
			{
				AuthorAdd.Visible =
				IzdatelctvoAdd.Visible =
				Izdatelctvo.Visible =
				author.Visible =
				date.Visible =
				LDate.Visible =
				LAuthor.Visible =
				LIzdatelcvtvo.Visible = false;
			}
			switch (bt)
			{
				case BookType.Book:
					Text = "Книга";
					break;
				case BookType.Author:
					Text = "Автор";
					break;
				case BookType.Izdatelctvo:
					Text = "Издательство";
					break;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			switch (bt)
			{
				case BookType.Book:
					try
					{
						bk.name = name.Text;
						bk.authorid = (author.SelectedItem as Author).id;
						bk.year = Convert.ToInt32(date.Text);
						bk.izdatelctvoid = (Izdatelctvo.SelectedItem as Izdatelctvo).id;

						string query1;
						query1 = "INSERT into Books(name,id_author,year,id_izdatelctvo) values ('" + bk.name + "'," + bk.authorid + "," + bk.year + "," + bk.izdatelctvoid + ")";
						SqlCommand command = new SqlCommand(query1, DateBase.connection);
						DateBase.connection.Open();
						command.ExecuteNonQuery();
						DateBase.connection.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						MessageBox.Show("Проверьте правильность введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						DateBase.connection.Close();
						return;
					}
					break;

				case BookType.Author:
					try
					{
						string query1;
						query1 = "INSERT into Authors(name) values ('" + name.Text + "')";
						SqlCommand command = new SqlCommand(query1, DateBase.connection);
						DateBase.connection.Open();
						command.ExecuteNonQuery();
						DateBase.connection.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						MessageBox.Show("Проверьте правильность введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						DateBase.connection.Close();
						return;
					}
					break;
				case BookType.Izdatelctvo:
					try
					{
						string query1;
						query1 = "INSERT into Izdatelctvo(name) values ('" + name.Text + "')";
						SqlCommand command = new SqlCommand(query1, DateBase.connection);
						DateBase.connection.Open();
						command.ExecuteNonQuery();
						DateBase.connection.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						MessageBox.Show("Проверьте правильность введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						DateBase.connection.Close();
						return;
					}
					break;

			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void FillAuthors()
		{
			// author.Items.Clear();
			List<Author> l = new List<Author>();
			SqlCommand command = new SqlCommand("SELECT * FROM Authors", DateBase.connection);
			var adapter = new SqlDataAdapter(command);
			var Table = new DataTable();
			try
			{
				DateBase.connection.Open();
				adapter.Fill(Table);
				Author bk = new Author();
				for (int i = 0; i < Table.Rows.Count; ++i)
				{
					bk = new Author();
					bk.id = (int)Table.Rows[i]["id"];
					bk.name = (string)Table.Rows[i]["name"];
					l.Add(bk);
				}
				author.DataSource = l;
				DateBase.connection.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DateBase.connection.Close();
			}
		}
		private void FillIzdatelctvo()
		{
			// author.Items.Clear();
			List<Izdatelctvo> l = new List<Izdatelctvo>();
			SqlCommand command = new SqlCommand("SELECT * FROM Izdatelctvo", DateBase.connection);
			var adapter = new SqlDataAdapter(command);
			var Table = new DataTable();
			try
			{
				DateBase.connection.Open();
				adapter.Fill(Table);
				Izdatelctvo bk = new Izdatelctvo();
				for (int i = 0; i < Table.Rows.Count; ++i)
				{
					bk = new Izdatelctvo();
					bk.id = (int)Table.Rows[i]["id"];
					bk.name = (string)Table.Rows[i]["name"];
					l.Add(bk);
				}
				Izdatelctvo.DataSource = l;
				DateBase.connection.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DateBase.connection.Close();
			}
		}


		private void AuthorAdd_Click(object sender, EventArgs e)
		{
			BookAdd book = new BookAdd(BookType.Author);
			var b = book.ShowDialog();
			if (b == DialogResult.OK)
			{
				FillAuthors();
				if (author.Items.Count > 0)
					author.SelectedIndex = 0;
			}
		}

		private void IzdatelctvoAdd_Click(object sender, EventArgs e)
		{
			BookAdd book = new BookAdd(BookType.Izdatelctvo);
			var b = book.ShowDialog();
			if (b == DialogResult.OK)
			{
				FillIzdatelctvo();
				if (Izdatelctvo.Items.Count > 0)
					Izdatelctvo.SelectedIndex = 0;
			}
		}

		private void BookAdd_Load(object sender, EventArgs e)
		{
			if (bt == BookType.Book)
			{
				FillAuthors();
				if (author.Items.Count > 0)
					author.SelectedIndex = 0;
				FillIzdatelctvo();
				if (Izdatelctvo.Items.Count > 0)
					Izdatelctvo.SelectedIndex = 0;
			}
		}
	}
}

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
	public partial class Nalichie : Form
	{
		public Nalichie()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
      comboBox2.SelectedIndex = 0;
    }

		private void FillTable(string where = "")
    {
      DG.Rows.Clear();
      SqlCommand command = new SqlCommand("SELECT * FROM Nalichie,Books where Nalichie.id_book = Books.id "+where, DateBase.connection);
      var adapter = new SqlDataAdapter(command);
      var Table = new DataTable();
      try
      {
        DateBase.connection.Open();
        adapter.Fill(Table);
        BookNalichie bk = new BookNalichie();
        for (int i = 0; i < Table.Rows.Count; ++i)
        {
          bk = new BookNalichie();
          bk.id = (int)Table.Rows[i]["id"];
          bk.amount = (int)Table.Rows[i]["amount"];
          bk.price = (decimal)Table.Rows[i]["price"];
          bk.bookid = (int)Table.Rows[i]["id_book"];
          bk.name = (string)Table.Rows[i]["name"];
          if (bk.amount != 0) { 
          int k = DG.Rows.Add(bk.name, bk.price, bk.amount, bk.bookid);
					DG.Rows[k].Tag = bk;
          }

        }
					DateBase.connection.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        DateBase.connection.Close();
      }
    }
    private void Nalichie_Load(object sender, EventArgs e)
		{
      FillTable();
    }
    private void NalSell(BookNalichie bl, int amount)
    {
      try
      {
        string query1;
        query1 = "UPDATE Nalichie set amount = " + (bl.amount - amount) + " where id = " + bl.id;
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
    }
    private void SellBooks(BookNalichie bl, int amount, int check)
    {
      try
      {
        string query1;
        query1 = "INSERT into Sell(amount,date,price,id_book,check_num) values (" + amount + ",'" + DateTime.Now.ToString("MM-dd-yyyy") + "'," + (int)bl.price + "," + bl.bookid + "," + check + ")";
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
    }

    private void buttonAdd_Click(object sender, EventArgs e)
		{
      if (DG.SelectedRows.Count == 0)
      {
        MessageBox.Show("Вы не выбрали книгу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      BookNalichie bl = DG.SelectedRows[0].Tag as BookNalichie;
      int ind = DG.SelectedRows[0].Index;
      if (bl.amount == 0)
      {
        MessageBox.Show("Нет книг в наличии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      SellBook sl = new SellBook();
      if (sl.ShowDialog() == DialogResult.OK)
			{
				try
				{
					int check = Convert.ToInt32(sl.check.Text);
					int amount = Convert.ToInt32(sl.amount.Text);
					if (amount > bl.amount)
					{
						MessageBox.Show($"Такого количества книг в наличии нету.\nВсего книг в наличии: {bl.amount}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					SellBooks(bl, amount, check);
					NalSell(bl, amount);
					FillTable();
				}
				catch(Exception ex)
				{
          MessageBox.Show("Проверьте написание данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


				}

		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
      Check ch = new Check();
      ch.ShowDialog();
    }

		private void button1_Click(object sender, EventArgs e)
		{
      if (comboBox1.SelectedIndex == 0) //н
      {
        string d = textBox1.Text;
        int r = DG.SelectedRows[0].Index;
        if (DG.SelectedRows.Count == 0) r = 0;
        for (int i = r + 1; i < DG.Rows.Count; ++i)
        {
          var dt = (string)(DG.Rows[i].Cells["Название"].Value);

          if (dt.ToUpper().StartsWith(d.ToUpper()))
          {
            DG.Rows[i].Cells["Название"].Selected = true;
            return;
          }
        }
      }
      if (comboBox1.SelectedIndex == 1) //ц
      {
        decimal d = Convert.ToDecimal(textBox1.Text);
        int r = DG.SelectedRows[0].Index;
        if (DG.SelectedRows.Count == 0) r = 0;
        for (int i = r + 1; i < DG.Rows.Count; ++i)
        {
          var dt = (decimal)(DG.Rows[i].Cells["Цена"].Value);

          if (dt == d)
          {
            DG.Rows[i].Cells["Цена"].Selected = true;
            return;
          }
        }
      }

      if (comboBox1.SelectedIndex == 2) //а
      {
        int d = Convert.ToInt32(textBox1.Text);
        int r = DG.SelectedRows[0].Index;
        if (DG.SelectedRows.Count == 0) r = 0;
        for (int i = r + 1; i < DG.Rows.Count; ++i)
        {
          var dt = (int)(DG.Rows[i].Cells["Артикул_книги"].Value);

          if (dt == d)
          {
            DG.Rows[i].Cells["Артикул_книги"].Selected = true;
            return;
          }
        }
      }
    }

		private void button2_Click(object sender, EventArgs e)
		{
      if (comboBox2.SelectedIndex == 0) // name
      {
        var d1 = textBox2.Text;
        FillTable($"and name LIKE '%{d1}%' ");

      }
      if (comboBox2.SelectedIndex == 1) // цена
      {
        decimal d1 = 0;
        decimal d2 = decimal.MaxValue;
        if (!(decimal.TryParse(textBox2.Text, out d1) && decimal.TryParse(textBox3.Text, out d2)))
        {
          d1 = 0;
          d2 = decimal.MaxValue;
        }
        FillTable("and price >= " + d1 + " and price<= " + d2 + " order by price");

      }
      if (comboBox2.SelectedIndex == 2) // артикул
      {
        decimal d1 = 0;
        decimal d2 = decimal.MaxValue;
        if (!(decimal.TryParse(textBox2.Text, out d1) && decimal.TryParse(textBox3.Text, out d2)))
        {
          d1 = 0;
          d2 = decimal.MaxValue;
        }
        FillTable("and id_book >= " + d1 + " and id_book<= " + d2 + " order by id_book");

      }
    }

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
      if (comboBox2.SelectedIndex == 0)
			{
				label3.Visible = false;
        textBox3.Visible = false;
			}
      else
			{
        label3.Visible = true;
        textBox3.Visible = true;
			}
		}
	}
}

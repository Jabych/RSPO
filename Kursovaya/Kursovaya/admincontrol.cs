using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
	public partial class admincontrol : UserControl
	{
		MainForm MainForm;
		public admincontrol(MainForm F)
		{
			InitializeComponent();
			MainForm = F;
		}

		public admincontrol()
		{
			InitializeComponent();

		}

		public void ReLoadListBox()
		{
			listBox1.Items.Clear();
			DataTable spisok;
			spisok = MainForm.selectBD("select * FROM User2");
			user u;
			for (int i = 0; i < spisok.Rows.Count; i++)
			{
				u.id = (int)spisok.Rows[i].ItemArray[0];
				u.nickname = (string)spisok.Rows[i].ItemArray[1];
				u.password = (int)spisok.Rows[i].ItemArray[2];
				u.type = ((int)spisok.Rows[i].ItemArray[3] == 0);
				listBox1.Items.Add(u);
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			MainForm.add(textBox1.Text, textBox2.Text, checkBox1.Checked);
			
			ReLoadListBox();
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			user u = (user)listBox1.SelectedItem;
			FormUserUpdate formUserUpdate = new FormUserUpdate();
			formUserUpdate.textBox1.Text = u.nickname.Trim();
			formUserUpdate.textBox2.Text = "";
			formUserUpdate.checkBox1.Checked = u.type;
			var r = formUserUpdate.ShowDialog();
			if (r == DialogResult.OK)
			{
				u.nickname = formUserUpdate.textBox1.Text;
				string password = formUserUpdate.textBox2.Text;
				u.password = MainForm.Parol(password);
				u.type = formUserUpdate.checkBox1.Checked;
				MainForm.update(u.id, u.nickname, password, u.type);
				listBox1.SelectedItem = u;
				listBox1.Update();
			}
			ReLoadListBox();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
				user u = (user)listBox1.SelectedItem;
				if (u.nickname != "admin")
				{
					DateBase.comandsToBD("DELETE FROM User2 WHERE ID =" + u.id);
					listBox1.Items.Remove(u);
				}
				else
				{
					MessageBox.Show("admin постоянный пользователь", "предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

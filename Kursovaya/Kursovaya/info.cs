using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursovaya
{
	public partial class info : Form
	{
		public info()
		{
			InitializeComponent();
		}

		private void info_Load(object sender, EventArgs e)
		{
			if (File.Exists("info.txt"))
				textBox1.Text = File.ReadAllText("info.txt");
			else
				textBox1.Text = "Ошибка: Файла info.txt нету.";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

namespace Kursovaya
{
	partial class Nalichie
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DG = new System.Windows.Forms.DataGridView();
			this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Артикул_книги = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonCheck = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DG
			// 
			this.DG.AllowUserToAddRows = false;
			this.DG.AllowUserToDeleteRows = false;
			this.DG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название,
            this.Цена,
            this.Количество,
            this.Артикул_книги});
			this.DG.Location = new System.Drawing.Point(12, 12);
			this.DG.MultiSelect = false;
			this.DG.Name = "DG";
			this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DG.Size = new System.Drawing.Size(776, 302);
			this.DG.TabIndex = 6;
			// 
			// Название
			// 
			this.Название.HeaderText = "Название";
			this.Название.Name = "Название";
			this.Название.Width = 200;
			// 
			// Цена
			// 
			this.Цена.HeaderText = "Цена";
			this.Цена.Name = "Цена";
			// 
			// Количество
			// 
			this.Количество.HeaderText = "Количество";
			this.Количество.Name = "Количество";
			// 
			// Артикул_книги
			// 
			this.Артикул_книги.HeaderText = "Артикул книги";
			this.Артикул_книги.Name = "Артикул_книги";
			this.Артикул_книги.Width = 200;
			// 
			// buttonCheck
			// 
			this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCheck.Location = new System.Drawing.Point(675, 405);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new System.Drawing.Size(89, 31);
			this.buttonCheck.TabIndex = 5;
			this.buttonCheck.Text = "Выписать чек";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Location = new System.Drawing.Point(675, 332);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(89, 31);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Продать";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Location = new System.Drawing.Point(371, 332);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(253, 106);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Фильтр";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(155, 74);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(71, 20);
			this.textBox3.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(131, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "По";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(40, 74);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(71, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "С";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "По названию",
            "По цене",
            "По артиклю"});
			this.comboBox2.Location = new System.Drawing.Point(117, 34);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "Фильтровать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(12, 332);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(244, 106);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(117, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 20);
			this.textBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Что искать:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "По названию",
            "По цене",
            "По артиклю"});
			this.comboBox1.Location = new System.Drawing.Point(117, 34);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(70, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Искать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Nalichie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.DG);
			this.Controls.Add(this.buttonCheck);
			this.Controls.Add(this.buttonAdd);
			this.Name = "Nalichie";
			this.Text = "Наличие книг";
			this.Load += new System.EventHandler(this.Nalichie_Load);
			((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DG;
		private System.Windows.Forms.Button buttonCheck;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn Название;
		private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
		private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
		private System.Windows.Forms.DataGridViewTextBoxColumn Артикул_книги;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
	}
}
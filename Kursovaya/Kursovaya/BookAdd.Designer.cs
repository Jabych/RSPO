namespace Kursovaya
{
	partial class BookAdd
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
			this.author = new System.Windows.Forms.ComboBox();
			this.name = new System.Windows.Forms.TextBox();
			this.LName = new System.Windows.Forms.Label();
			this.LAuthor = new System.Windows.Forms.Label();
			this.AuthorAdd = new System.Windows.Forms.Button();
			this.IzdatelctvoAdd = new System.Windows.Forms.Button();
			this.Izdatelctvo = new System.Windows.Forms.ComboBox();
			this.LIzdatelcvtvo = new System.Windows.Forms.Label();
			this.LDate = new System.Windows.Forms.Label();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.date = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// author
			// 
			this.author.FormattingEnabled = true;
			this.author.Location = new System.Drawing.Point(103, 56);
			this.author.Name = "author";
			this.author.Size = new System.Drawing.Size(446, 21);
			this.author.TabIndex = 13;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(103, 17);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(446, 20);
			this.name.TabIndex = 12;
			// 
			// LName
			// 
			this.LName.AutoSize = true;
			this.LName.Location = new System.Drawing.Point(14, 20);
			this.LName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LName.Name = "LName";
			this.LName.Size = new System.Drawing.Size(60, 13);
			this.LName.TabIndex = 11;
			this.LName.Text = "Название:";
			// 
			// LAuthor
			// 
			this.LAuthor.AutoSize = true;
			this.LAuthor.Location = new System.Drawing.Point(14, 56);
			this.LAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LAuthor.Name = "LAuthor";
			this.LAuthor.Size = new System.Drawing.Size(40, 13);
			this.LAuthor.TabIndex = 10;
			this.LAuthor.Text = "Автор:";
			// 
			// AuthorAdd
			// 
			this.AuthorAdd.Location = new System.Drawing.Point(555, 56);
			this.AuthorAdd.Name = "AuthorAdd";
			this.AuthorAdd.Size = new System.Drawing.Size(38, 23);
			this.AuthorAdd.TabIndex = 14;
			this.AuthorAdd.Text = "+";
			this.AuthorAdd.UseVisualStyleBackColor = true;
			this.AuthorAdd.Click += new System.EventHandler(this.AuthorAdd_Click);
			// 
			// IzdatelctvoAdd
			// 
			this.IzdatelctvoAdd.Location = new System.Drawing.Point(555, 141);
			this.IzdatelctvoAdd.Name = "IzdatelctvoAdd";
			this.IzdatelctvoAdd.Size = new System.Drawing.Size(38, 23);
			this.IzdatelctvoAdd.TabIndex = 17;
			this.IzdatelctvoAdd.Text = "+";
			this.IzdatelctvoAdd.UseVisualStyleBackColor = true;
			this.IzdatelctvoAdd.Click += new System.EventHandler(this.IzdatelctvoAdd_Click);
			// 
			// Izdatelctvo
			// 
			this.Izdatelctvo.FormattingEnabled = true;
			this.Izdatelctvo.Location = new System.Drawing.Point(103, 141);
			this.Izdatelctvo.Name = "Izdatelctvo";
			this.Izdatelctvo.Size = new System.Drawing.Size(446, 21);
			this.Izdatelctvo.TabIndex = 16;
			// 
			// LIzdatelcvtvo
			// 
			this.LIzdatelcvtvo.AutoSize = true;
			this.LIzdatelcvtvo.Location = new System.Drawing.Point(14, 144);
			this.LIzdatelcvtvo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LIzdatelcvtvo.Name = "LIzdatelcvtvo";
			this.LIzdatelcvtvo.Size = new System.Drawing.Size(82, 13);
			this.LIzdatelcvtvo.TabIndex = 15;
			this.LIzdatelcvtvo.Text = "Издательство:";
			// 
			// LDate
			// 
			this.LDate.AutoSize = true;
			this.LDate.Location = new System.Drawing.Point(13, 103);
			this.LDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LDate.Name = "LDate";
			this.LDate.Size = new System.Drawing.Size(71, 13);
			this.LDate.TabIndex = 18;
			this.LDate.Text = "Год выпуска";
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEdit.Location = new System.Drawing.Point(523, 199);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(89, 31);
			this.buttonEdit.TabIndex = 21;
			this.buttonEdit.Text = "Отмена";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Location = new System.Drawing.Point(402, 199);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(115, 31);
			this.buttonAdd.TabIndex = 20;
			this.buttonAdd.Text = "Подтвердить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// date
			// 
			this.date.Location = new System.Drawing.Point(103, 100);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(119, 20);
			this.date.TabIndex = 22;
			// 
			// BookAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 242);
			this.Controls.Add(this.date);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.LDate);
			this.Controls.Add(this.IzdatelctvoAdd);
			this.Controls.Add(this.Izdatelctvo);
			this.Controls.Add(this.LIzdatelcvtvo);
			this.Controls.Add(this.AuthorAdd);
			this.Controls.Add(this.author);
			this.Controls.Add(this.name);
			this.Controls.Add(this.LName);
			this.Controls.Add(this.LAuthor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BookAdd";
			this.Text = "Добавить книгу";
			this.Load += new System.EventHandler(this.BookAdd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox author;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label LName;
		private System.Windows.Forms.Label LAuthor;
		private System.Windows.Forms.Button AuthorAdd;
		private System.Windows.Forms.Button IzdatelctvoAdd;
		private System.Windows.Forms.ComboBox Izdatelctvo;
		private System.Windows.Forms.Label LIzdatelcvtvo;
		private System.Windows.Forms.Label LDate;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox date;
	}
}
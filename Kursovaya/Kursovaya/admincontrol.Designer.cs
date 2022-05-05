namespace Kursovaya
{
    partial class admincontrol
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(131, 220);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(113, 53);
			this.buttonAdd.TabIndex = 11;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(327, 147);
			this.textBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(358, 24);
			this.textBox2.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(132, 147);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 18);
			this.label3.TabIndex = 9;
			this.label3.Text = "Пароль";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(327, 102);
			this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(358, 24);
			this.textBox1.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(132, 102);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Имя";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(285, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Создание и изменение пользователя";
			// 
			// buttonChange
			// 
			this.buttonChange.Location = new System.Drawing.Point(338, 220);
			this.buttonChange.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(113, 53);
			this.buttonChange.TabIndex = 12;
			this.buttonChange.Text = "Изменить";
			this.buttonChange.UseVisualStyleBackColor = true;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(528, 220);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(113, 53);
			this.buttonDelete.TabIndex = 13;
			this.buttonDelete.Text = "Удалить\r\n";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(329, 178);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(135, 22);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "Администратор";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new System.Drawing.Point(131, 299);
			this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(572, 184);
			this.listBox1.TabIndex = 15;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// admincontrol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "admincontrol";
			this.Size = new System.Drawing.Size(829, 514);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.ListBox listBox1;
    }
}

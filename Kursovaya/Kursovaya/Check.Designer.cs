namespace Kursovaya
{
	partial class Check
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
			this.t_check = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonShow = new System.Windows.Forms.Button();
			this.LCheck = new System.Windows.Forms.Label();
			this.tb_check = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// t_check
			// 
			this.t_check.Location = new System.Drawing.Point(140, 20);
			this.t_check.Name = "t_check";
			this.t_check.Size = new System.Drawing.Size(174, 20);
			this.t_check.TabIndex = 17;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(416, 327);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(89, 31);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonShow
			// 
			this.buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonShow.Location = new System.Drawing.Point(295, 327);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(115, 31);
			this.buttonShow.TabIndex = 15;
			this.buttonShow.Text = "Показать";
			this.buttonShow.UseVisualStyleBackColor = true;
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// LCheck
			// 
			this.LCheck.AutoSize = true;
			this.LCheck.Location = new System.Drawing.Point(16, 23);
			this.LCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LCheck.Name = "LCheck";
			this.LCheck.Size = new System.Drawing.Size(66, 13);
			this.LCheck.TabIndex = 14;
			this.LCheck.Text = "Количество";
			// 
			// tb_check
			// 
			this.tb_check.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_check.Location = new System.Drawing.Point(19, 60);
			this.tb_check.Multiline = true;
			this.tb_check.Name = "tb_check";
			this.tb_check.Size = new System.Drawing.Size(486, 251);
			this.tb_check.TabIndex = 18;
			// 
			// Check
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 370);
			this.Controls.Add(this.tb_check);
			this.Controls.Add(this.t_check);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.LCheck);
			this.Name = "Check";
			this.Text = "Check";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox t_check;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonShow;
		private System.Windows.Forms.Label LCheck;
		private System.Windows.Forms.TextBox tb_check;
	}
}
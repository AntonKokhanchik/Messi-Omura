namespace Messi_Omura
{
	partial class Form1
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxModule = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxEncodeA = new System.Windows.Forms.TextBox();
			this.textBoxEncodeB = new System.Windows.Forms.TextBox();
			this.textBoxDecodeA = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxDecodeB = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonKeys = new System.Windows.Forms.Button();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.buttonSendA = new System.Windows.Forms.Button();
			this.buttonSendB = new System.Windows.Forms.Button();
			this.buttonEncodeB = new System.Windows.Forms.Button();
			this.buttonDecodeB = new System.Windows.Forms.Button();
			this.buttonDecodeA = new System.Windows.Forms.Button();
			this.buttonEncodeA = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxModule
			// 
			this.textBoxModule.Location = new System.Drawing.Point(213, 29);
			this.textBoxModule.Name = "textBoxModule";
			this.textBoxModule.Size = new System.Drawing.Size(238, 22);
			this.textBoxModule.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(242, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Модуль (простое число)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ключ зашифроваия А";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(452, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Ключ зашифрования Б";
			// 
			// textBoxEncodeA
			// 
			this.textBoxEncodeA.Location = new System.Drawing.Point(12, 83);
			this.textBoxEncodeA.Name = "textBoxEncodeA";
			this.textBoxEncodeA.Size = new System.Drawing.Size(238, 22);
			this.textBoxEncodeA.TabIndex = 0;
			// 
			// textBoxEncodeB
			// 
			this.textBoxEncodeB.Location = new System.Drawing.Point(418, 83);
			this.textBoxEncodeB.Name = "textBoxEncodeB";
			this.textBoxEncodeB.Size = new System.Drawing.Size(238, 22);
			this.textBoxEncodeB.TabIndex = 0;
			// 
			// textBoxDecodeA
			// 
			this.textBoxDecodeA.Location = new System.Drawing.Point(12, 134);
			this.textBoxDecodeA.Name = "textBoxDecodeA";
			this.textBoxDecodeA.Size = new System.Drawing.Size(238, 22);
			this.textBoxDecodeA.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Ключ расшифроваия Б";
			// 
			// textBoxDecodeB
			// 
			this.textBoxDecodeB.Location = new System.Drawing.Point(418, 134);
			this.textBoxDecodeB.Name = "textBoxDecodeB";
			this.textBoxDecodeB.Size = new System.Drawing.Size(238, 22);
			this.textBoxDecodeB.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(452, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Ключ расшифрования Б";
			// 
			// buttonKeys
			// 
			this.buttonKeys.Location = new System.Drawing.Point(256, 83);
			this.buttonKeys.Name = "buttonKeys";
			this.buttonKeys.Size = new System.Drawing.Size(154, 73);
			this.buttonKeys.TabIndex = 2;
			this.buttonKeys.Text = "Получить ключи расшифрования";
			this.buttonKeys.UseVisualStyleBackColor = true;
			this.buttonKeys.Click += new System.EventHandler(this.buttonKeys_Click);
			// 
			// textBoxA
			// 
			this.textBoxA.Location = new System.Drawing.Point(12, 192);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(296, 22);
			this.textBoxA.TabIndex = 0;
			// 
			// textBoxB
			// 
			this.textBoxB.Location = new System.Drawing.Point(373, 192);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(283, 22);
			this.textBoxB.TabIndex = 0;
			// 
			// buttonSendA
			// 
			this.buttonSendA.Location = new System.Drawing.Point(204, 220);
			this.buttonSendA.Name = "buttonSendA";
			this.buttonSendA.Size = new System.Drawing.Size(104, 38);
			this.buttonSendA.TabIndex = 2;
			this.buttonSendA.Text = "Отправить";
			this.buttonSendA.UseVisualStyleBackColor = true;
			this.buttonSendA.Click += new System.EventHandler(this.buttonSendA_Click);
			// 
			// buttonSendB
			// 
			this.buttonSendB.Location = new System.Drawing.Point(373, 220);
			this.buttonSendB.Name = "buttonSendB";
			this.buttonSendB.Size = new System.Drawing.Size(92, 38);
			this.buttonSendB.TabIndex = 2;
			this.buttonSendB.Text = "Отправить";
			this.buttonSendB.UseVisualStyleBackColor = true;
			this.buttonSendB.Click += new System.EventHandler(this.buttonSendB_Click);
			// 
			// buttonEncodeB
			// 
			this.buttonEncodeB.Location = new System.Drawing.Point(566, 220);
			this.buttonEncodeB.Name = "buttonEncodeB";
			this.buttonEncodeB.Size = new System.Drawing.Size(90, 38);
			this.buttonEncodeB.TabIndex = 2;
			this.buttonEncodeB.Text = "Расшифр";
			this.buttonEncodeB.UseVisualStyleBackColor = true;
			this.buttonEncodeB.Click += new System.EventHandler(this.buttonEncodeB_Click);
			// 
			// buttonDecodeB
			// 
			this.buttonDecodeB.Location = new System.Drawing.Point(470, 220);
			this.buttonDecodeB.Name = "buttonDecodeB";
			this.buttonDecodeB.Size = new System.Drawing.Size(90, 38);
			this.buttonDecodeB.TabIndex = 2;
			this.buttonDecodeB.Text = "Зашифр";
			this.buttonDecodeB.UseVisualStyleBackColor = true;
			this.buttonDecodeB.Click += new System.EventHandler(this.buttonDecodeB_Click);
			// 
			// buttonDecodeA
			// 
			this.buttonDecodeA.Location = new System.Drawing.Point(108, 220);
			this.buttonDecodeA.Name = "buttonDecodeA";
			this.buttonDecodeA.Size = new System.Drawing.Size(90, 38);
			this.buttonDecodeA.TabIndex = 2;
			this.buttonDecodeA.Text = "Расшфр";
			this.buttonDecodeA.UseVisualStyleBackColor = true;
			this.buttonDecodeA.Click += new System.EventHandler(this.buttonDecodeA_Click);
			// 
			// buttonEncodeA
			// 
			this.buttonEncodeA.Location = new System.Drawing.Point(12, 220);
			this.buttonEncodeA.Name = "buttonEncodeA";
			this.buttonEncodeA.Size = new System.Drawing.Size(90, 38);
			this.buttonEncodeA.TabIndex = 2;
			this.buttonEncodeA.Text = "Зашифр";
			this.buttonEncodeA.UseVisualStyleBackColor = true;
			this.buttonEncodeA.Click += new System.EventHandler(this.buttonEncodeA_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(85, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "У абонента А";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(489, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 17);
			this.label7.TabIndex = 1;
			this.label7.Text = "У абонента Б";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 285);
			this.Controls.Add(this.buttonEncodeA);
			this.Controls.Add(this.buttonDecodeB);
			this.Controls.Add(this.buttonDecodeA);
			this.Controls.Add(this.buttonEncodeB);
			this.Controls.Add(this.buttonSendB);
			this.Controls.Add(this.buttonSendA);
			this.Controls.Add(this.buttonKeys);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxDecodeB);
			this.Controls.Add(this.textBoxEncodeB);
			this.Controls.Add(this.textBoxB);
			this.Controls.Add(this.textBoxA);
			this.Controls.Add(this.textBoxDecodeA);
			this.Controls.Add(this.textBoxEncodeA);
			this.Controls.Add(this.textBoxModule);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Система Месси-Омуры";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxModule;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxEncodeA;
		private System.Windows.Forms.TextBox textBoxEncodeB;
		private System.Windows.Forms.TextBox textBoxDecodeA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxDecodeB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonKeys;
		private System.Windows.Forms.TextBox textBoxA;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.Button buttonSendA;
		private System.Windows.Forms.Button buttonSendB;
		private System.Windows.Forms.Button buttonEncodeB;
		private System.Windows.Forms.Button buttonDecodeB;
		private System.Windows.Forms.Button buttonDecodeA;
		private System.Windows.Forms.Button buttonEncodeA;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}


namespace WindowsFormsApp14
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
            this.Nn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nn
            // 
            this.Nn.Location = new System.Drawing.Point(207, 22);
            this.Nn.Name = "Nn";
            this.Nn.Size = new System.Drawing.Size(129, 22);
            this.Nn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер массива";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mas
            // 
            this.mas.Location = new System.Drawing.Point(15, 81);
            this.mas.Multiline = true;
            this.mas.Name = "mas";
            this.mas.ReadOnly = true;
            this.mas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mas.Size = new System.Drawing.Size(436, 206);
            this.mas.TabIndex = 3;
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(15, 294);
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.Size = new System.Drawing.Size(321, 22);
            this.rez.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите число";
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(207, 53);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(129, 22);
            this.Num.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 346);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mas;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num;
    }
}


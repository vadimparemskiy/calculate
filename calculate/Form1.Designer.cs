namespace calculate
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
            this.addition = new System.Windows.Forms.Button();
            this.sabtraction = new System.Windows.Forms.Button();
            this.multyplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.buttonRadical = new System.Windows.Forms.Button();
            this.buttonDegree = new System.Windows.Forms.Button();
            this.buttonDegreeFraction = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(2, 63);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 0;
            this.addition.Text = "Сложение";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.Click);
            // 
            // sabtraction
            // 
            this.sabtraction.Location = new System.Drawing.Point(85, 63);
            this.sabtraction.Name = "sabtraction";
            this.sabtraction.Size = new System.Drawing.Size(75, 23);
            this.sabtraction.TabIndex = 1;
            this.sabtraction.Text = "Вычитане";
            this.sabtraction.UseVisualStyleBackColor = true;
            this.sabtraction.Click += new System.EventHandler(this.Click);
            // 
            // multyplication
            // 
            this.multyplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multyplication.Location = new System.Drawing.Point(2, 92);
            this.multyplication.Name = "multyplication";
            this.multyplication.Size = new System.Drawing.Size(75, 23);
            this.multyplication.TabIndex = 2;
            this.multyplication.Text = "Умножение";
            this.multyplication.UseVisualStyleBackColor = true;
            this.multyplication.Click += new System.EventHandler(this.Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(85, 92);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 3;
            this.division.Text = "Деление";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(2, 136);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneClick);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(85, 136);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneClick);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(166, 136);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 9;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OneClick);
            // 
            // buttonRadical
            // 
            this.buttonRadical.Location = new System.Drawing.Point(2, 199);
            this.buttonRadical.Name = "buttonRadical";
            this.buttonRadical.Size = new System.Drawing.Size(75, 23);
            this.buttonRadical.TabIndex = 10;
            this.buttonRadical.Text = "Квадратный корень";
            this.buttonRadical.UseVisualStyleBackColor = true;
            this.buttonRadical.Click += new System.EventHandler(this.OneClick);
            // 
            // buttonDegree
            // 
            this.buttonDegree.Location = new System.Drawing.Point(84, 179);
            this.buttonDegree.Name = "buttonDegree";
            this.buttonDegree.Size = new System.Drawing.Size(75, 23);
            this.buttonDegree.TabIndex = 11;
            this.buttonDegree.Text = "Степень";
            this.buttonDegree.UseVisualStyleBackColor = true;
            this.buttonDegree.Click += new System.EventHandler(this.Click);
            // 
            // buttonDegreeFraction
            // 
            this.buttonDegreeFraction.Location = new System.Drawing.Point(248, 179);
            this.buttonDegreeFraction.Name = "buttonDegreeFraction";
            this.buttonDegreeFraction.Size = new System.Drawing.Size(75, 23);
            this.buttonDegreeFraction.TabIndex = 12;
            this.buttonDegreeFraction.Text = "1/степень";
            this.buttonDegreeFraction.UseVisualStyleBackColor = true;
            this.buttonDegreeFraction.Click += new System.EventHandler(this.Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 292);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonDegreeFraction);
            this.Controls.Add(this.buttonDegree);
            this.Controls.Add(this.buttonRadical);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multyplication);
            this.Controls.Add(this.sabtraction);
            this.Controls.Add(this.addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button sabtraction;
        private System.Windows.Forms.Button multyplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button buttonRadical;
        private System.Windows.Forms.Button buttonDegree;
        private System.Windows.Forms.Button buttonDegreeFraction;
        private System.Windows.Forms.TextBox textBox4;
    }
}


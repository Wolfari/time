namespace Time
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.minUP = new System.Windows.Forms.NumericUpDown();
            this.secUP = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.minUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secUP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таймер";
            // 
            // minUP
            // 
            this.minUP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minUP.Location = new System.Drawing.Point(107, 20);
            this.minUP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minUP.Name = "minUP";
            this.minUP.Size = new System.Drawing.Size(50, 29);
            this.minUP.TabIndex = 4;
            this.minUP.ValueChanged += new System.EventHandler(this.minUP_ValueChanged);
            // 
            // secUP
            // 
            this.secUP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secUP.Location = new System.Drawing.Point(107, 77);
            this.secUP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secUP.Name = "secUP";
            this.secUP.Size = new System.Drawing.Size(50, 29);
            this.secUP.TabIndex = 5;
            this.secUP.ValueChanged += new System.EventHandler(this.minUP_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(226, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(140, 60);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(88, 36);
            this.Time.TabIndex = 8;
            this.Time.Text = "00:00";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.Location = new System.Drawing.Point(7, 20);
            this.Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(74, 23);
            this.Min.TabIndex = 9;
            this.Min.Text = "Минут:";
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Sec
            // 
            this.Sec.AutoSize = true;
            this.Sec.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sec.Location = new System.Drawing.Point(7, 83);
            this.Sec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(80, 23);
            this.Sec.TabIndex = 10;
            this.Sec.Text = "Секунд:";
            this.Sec.Click += new System.EventHandler(this.Sec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Min);
            this.groupBox1.Controls.Add(this.Sec);
            this.groupBox1.Controls.Add(this.minUP);
            this.groupBox1.Controls.Add(this.secUP);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(204, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Интервал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.minUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secUP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minUP;
        private System.Windows.Forms.NumericUpDown secUP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Sec;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


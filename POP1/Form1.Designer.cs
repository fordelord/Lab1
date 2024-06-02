
namespace POP1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rInput = new System.Windows.Forms.NumericUpDown();
            this.lInput = new System.Windows.Forms.NumericUpDown();
            this.cInput = new System.Windows.Forms.NumericUpDown();
            this.vInput = new System.Windows.Forms.NumericUpDown();
            this.xInput = new System.Windows.Forms.NumericUpDown();
            this.wInput = new System.Windows.Forms.NumericUpDown();
            this.mInput = new System.Windows.Forms.NumericUpDown();
            this.aInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rInput);
            this.panel1.Controls.Add(this.lInput);
            this.panel1.Controls.Add(this.cInput);
            this.panel1.Controls.Add(this.vInput);
            this.panel1.Controls.Add(this.xInput);
            this.panel1.Controls.Add(this.wInput);
            this.panel1.Controls.Add(this.mInput);
            this.panel1.Controls.Add(this.aInput);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 428);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 221);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(755, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Радiус (r)";
            // 
            // rInput
            // 
            this.rInput.DecimalPlaces = 2;
            this.rInput.Location = new System.Drawing.Point(758, 150);
            this.rInput.Margin = new System.Windows.Forms.Padding(2);
            this.rInput.Name = "rInput";
            this.rInput.ReadOnly = true;
            this.rInput.Size = new System.Drawing.Size(90, 20);
            this.rInput.TabIndex = 22;
            this.rInput.ValueChanged += new System.EventHandler(this.handleRInputChange);
            // 
            // lInput
            // 
            this.lInput.DecimalPlaces = 2;
            this.lInput.Location = new System.Drawing.Point(508, 150);
            this.lInput.Margin = new System.Windows.Forms.Padding(2);
            this.lInput.Name = "lInput";
            this.lInput.ReadOnly = true;
            this.lInput.Size = new System.Drawing.Size(90, 20);
            this.lInput.TabIndex = 21;
            this.lInput.ValueChanged += new System.EventHandler(this.handleLInputChange);
            // 
            // cInput
            // 
            this.cInput.DecimalPlaces = 2;
            this.cInput.Location = new System.Drawing.Point(285, 150);
            this.cInput.Margin = new System.Windows.Forms.Padding(2);
            this.cInput.Name = "cInput";
            this.cInput.ReadOnly = true;
            this.cInput.Size = new System.Drawing.Size(90, 20);
            this.cInput.TabIndex = 20;
            this.cInput.ValueChanged += new System.EventHandler(this.handleCInputChange);
            // 
            // vInput
            // 
            this.vInput.DecimalPlaces = 2;
            this.vInput.Location = new System.Drawing.Point(42, 150);
            this.vInput.Margin = new System.Windows.Forms.Padding(2);
            this.vInput.Name = "vInput";
            this.vInput.ReadOnly = true;
            this.vInput.Size = new System.Drawing.Size(90, 20);
            this.vInput.TabIndex = 19;
            this.vInput.ValueChanged += new System.EventHandler(this.handleVInputChange);
            // 
            // xInput
            // 
            this.xInput.DecimalPlaces = 2;
            this.xInput.Location = new System.Drawing.Point(758, 64);
            this.xInput.Margin = new System.Windows.Forms.Padding(2);
            this.xInput.Name = "xInput";
            this.xInput.ReadOnly = true;
            this.xInput.Size = new System.Drawing.Size(90, 20);
            this.xInput.TabIndex = 18;
            this.xInput.ValueChanged += new System.EventHandler(this.handleXInputChange);
            // 
            // wInput
            // 
            this.wInput.DecimalPlaces = 2;
            this.wInput.Location = new System.Drawing.Point(449, 54);
            this.wInput.Margin = new System.Windows.Forms.Padding(2);
            this.wInput.Name = "wInput";
            this.wInput.ReadOnly = true;
            this.wInput.Size = new System.Drawing.Size(90, 20);
            this.wInput.TabIndex = 17;
            this.wInput.ValueChanged += new System.EventHandler(this.handleWInputChange);
            // 
            // mInput
            // 
            this.mInput.DecimalPlaces = 2;
            this.mInput.Location = new System.Drawing.Point(42, 54);
            this.mInput.Margin = new System.Windows.Forms.Padding(2);
            this.mInput.Name = "mInput";
            this.mInput.ReadOnly = true;
            this.mInput.Size = new System.Drawing.Size(90, 20);
            this.mInput.TabIndex = 16;
            this.mInput.ValueChanged += new System.EventHandler(this.handleMInputChange);
            // 
            // aInput
            // 
            this.aInput.DecimalPlaces = 2;
            this.aInput.Location = new System.Drawing.Point(266, 54);
            this.aInput.Margin = new System.Windows.Forms.Padding(2);
            this.aInput.Name = "aInput";
            this.aInput.ReadOnly = true;
            this.aInput.Size = new System.Drawing.Size(90, 20);
            this.aInput.TabIndex = 15;
            this.aInput.ValueChanged += new System.EventHandler(this.handleAInputChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(446, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Кутова швидкість обертання (рад/с)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(39, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Початкова лінійна швидкість (м\\с)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(277, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кут нахилу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(39, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Маса (кг)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(506, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Довжина недеформованої пружини (м)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(739, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Початкова координата (м)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(277, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коефіцієнт жорсткості пружини (Н/м)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Значення за замовченням";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handleDefaultButtonClick);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(401, 69);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(646, 354);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(686, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Частота коливань: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 301);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.1",
            "0.01",
            "0.001",
            "0.0001",
            "0.00001"});
            this.comboBox1.Location = new System.Drawing.Point(28, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Частота коливань: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 651);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Моделювання руху матеріальної точки";
            this.Load += new System.EventHandler(this.onLoadForm);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown aInput;
        private System.Windows.Forms.NumericUpDown lInput;
        private System.Windows.Forms.NumericUpDown cInput;
        private System.Windows.Forms.NumericUpDown vInput;
        private System.Windows.Forms.NumericUpDown xInput;
        private System.Windows.Forms.NumericUpDown wInput;
        private System.Windows.Forms.NumericUpDown mInput;
        private System.Windows.Forms.NumericUpDown rInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


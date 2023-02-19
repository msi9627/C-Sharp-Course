namespace UgadayChislo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.spinner = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Я загадал четырёхзначное число!\r\nПопробуй отгадать с трёх попыток!";
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.CadetBlue;
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCheck.ForeColor = System.Drawing.Color.White;
            this.btCheck.Location = new System.Drawing.Point(240, 153);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(174, 60);
            this.btCheck.TabIndex = 2;
            this.btCheck.Text = "ПРОВЕРИТЬ";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введи предполагаемое число:";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(263, 75);
            this.trackBar.Maximum = 9999;
            this.trackBar.Minimum = 1000;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(302, 69);
            this.trackBar.TabIndex = 4;
            this.trackBar.Value = 1000;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // spinner
            // 
            this.spinner.Location = new System.Drawing.Point(572, 85);
            this.spinner.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spinner.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(91, 26);
            this.spinner.TabIndex = 5;
            this.spinner.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinner.ValueChanged += new System.EventHandler(this.spinner_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 225);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Угадай число";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.NumericUpDown spinner;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


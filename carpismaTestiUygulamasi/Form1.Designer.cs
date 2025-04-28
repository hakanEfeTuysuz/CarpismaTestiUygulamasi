namespace NesneyeDayalıProgramlamaOdev2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nokta-Dörtgen", "Nokta-Çember", "Dörtgen-Dörtgen", "Dörtgen-Çember", "Çember-Çember", "Nokta-Küre", "Nokta-Dikdörtgen Prizma", "Silindir-Silindir", "Dikdörtgen Prizma-Dikdörtgen Prizma", "Yüzey-Silindir" });
            comboBox1.Location = new Point(12, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 65);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 1;
            label1.Text = "Çarpışma Deneyini Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 28);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 2;
            label2.Text = "Çarpışma Denetimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1029, 82);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 3;
            label3.Text = "Şekillerin Verileri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1029, 422);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 4;
            label4.Text = "Çarpışma Durumu";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(266, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(597, 513);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(869, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(869, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(440, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(882, 461);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(418, 27);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 606);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serbest Çarpıştırma Denetimi Uygulaması";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}

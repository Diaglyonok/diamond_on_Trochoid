namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.button_draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_of_graphics = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.a_tag = new System.Windows.Forms.TextBox();
            this.b_tag = new System.Windows.Forms.TextBox();
            this.diam_width = new System.Windows.Forms.TextBox();
            this.diam_heigth = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.TextBox();
            this.B_color = new System.Windows.Forms.TextBox();
            this.G_color = new System.Windows.Forms.TextBox();
            this.R_color = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.Location = new System.Drawing.Point(12, 12);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(612, 377);
            this.drawBox.TabIndex = 0;
            this.drawBox.TabStop = false;
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(520, 405);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(103, 63);
            this.button_draw.TabIndex = 1;
            this.button_draw.Text = "Рисовать";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цвет контура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ширина ромба";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Длина ромба";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Шаг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Параметр b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Параметр a";
            // 
            // num_of_graphics
            // 
            this.num_of_graphics.FormattingEnabled = true;
            this.num_of_graphics.Location = new System.Drawing.Point(432, 452);
            this.num_of_graphics.Name = "num_of_graphics";
            this.num_of_graphics.Size = new System.Drawing.Size(42, 21);
            this.num_of_graphics.TabIndex = 8;
            this.num_of_graphics.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Количество трохоид";
            // 
            // a_tag
            // 
            this.a_tag.Location = new System.Drawing.Point(432, 426);
            this.a_tag.Name = "a_tag";
            this.a_tag.Size = new System.Drawing.Size(42, 20);
            this.a_tag.TabIndex = 10;
            this.a_tag.Text = "30";
            // 
            // b_tag
            // 
            this.b_tag.Location = new System.Drawing.Point(432, 407);
            this.b_tag.Name = "b_tag";
            this.b_tag.Size = new System.Drawing.Size(42, 20);
            this.b_tag.TabIndex = 11;
            this.b_tag.Text = "40";
            // 
            // diam_width
            // 
            this.diam_width.Location = new System.Drawing.Point(256, 407);
            this.diam_width.Name = "diam_width";
            this.diam_width.Size = new System.Drawing.Size(42, 20);
            this.diam_width.TabIndex = 12;
            this.diam_width.Text = "30";
            // 
            // diam_heigth
            // 
            this.diam_heigth.Location = new System.Drawing.Point(256, 430);
            this.diam_heigth.Name = "diam_heigth";
            this.diam_heigth.Size = new System.Drawing.Size(42, 20);
            this.diam_heigth.TabIndex = 13;
            this.diam_heigth.Text = "40";
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(256, 452);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(42, 20);
            this.step.TabIndex = 14;
            this.step.Text = "0,1";
            // 
            // B_color
            // 
            this.B_color.Location = new System.Drawing.Point(105, 453);
            this.B_color.Name = "B_color";
            this.B_color.Size = new System.Drawing.Size(42, 20);
            this.B_color.TabIndex = 15;
            this.B_color.Text = "0";
            // 
            // G_color
            // 
            this.G_color.Location = new System.Drawing.Point(57, 453);
            this.G_color.Name = "G_color";
            this.G_color.Size = new System.Drawing.Size(42, 20);
            this.G_color.TabIndex = 16;
            this.G_color.Text = "0";
            // 
            // R_color
            // 
            this.R_color.Location = new System.Drawing.Point(9, 453);
            this.R_color.Name = "R_color";
            this.R_color.Size = new System.Drawing.Size(42, 20);
            this.R_color.TabIndex = 17;
            this.R_color.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 484);
            this.Controls.Add(this.R_color);
            this.Controls.Add(this.G_color);
            this.Controls.Add(this.B_color);
            this.Controls.Add(this.step);
            this.Controls.Add(this.diam_heigth);
            this.Controls.Add(this.diam_width);
            this.Controls.Add(this.b_tag);
            this.Controls.Add(this.a_tag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_of_graphics);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_draw);
            this.Controls.Add(this.drawBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox num_of_graphics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox a_tag;
        private System.Windows.Forms.TextBox b_tag;
        private System.Windows.Forms.TextBox diam_width;
        private System.Windows.Forms.TextBox diam_heigth;
        private System.Windows.Forms.TextBox step;
        private System.Windows.Forms.TextBox B_color;
        private System.Windows.Forms.TextBox G_color;
        private System.Windows.Forms.TextBox R_color;
    }
}


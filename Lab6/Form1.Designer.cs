namespace Lab4
{
    partial class Main
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
            this.paint_box = new System.Windows.Forms.Panel();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.button_deletestorage = new System.Windows.Forms.Button();
            this.button_clear_paintbox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Line = new System.Windows.Forms.RadioButton();
            this.rb_Square = new System.Windows.Forms.RadioButton();
            this.rb_Circle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Red = new System.Windows.Forms.RadioButton();
            this.rb_Green = new System.Windows.Forms.RadioButton();
            this.rb_Yellow = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // paint_box
            // 
            this.paint_box.BackColor = System.Drawing.Color.Honeydew;
            this.paint_box.ForeColor = System.Drawing.Color.Transparent;
            this.paint_box.Location = new System.Drawing.Point(13, 13);
            this.paint_box.Name = "paint_box";
            this.paint_box.Size = new System.Drawing.Size(602, 505);
            this.paint_box.TabIndex = 0;
            this.paint_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paint_box_MouseClick);
            this.paint_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paint_box_MouseMove);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(622, 13);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(17, 13);
            this.label_x.TabIndex = 1;
            this.label_x.Text = "X:";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(622, 41);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(17, 13);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "Y:";
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.DeepPink;
            this.button_show.Location = new System.Drawing.Point(622, 57);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(166, 56);
            this.button_show.TabIndex = 3;
            this.button_show.Text = "Вывод из хранилища";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            this.button_show.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // button_deletestorage
            // 
            this.button_deletestorage.BackColor = System.Drawing.Color.HotPink;
            this.button_deletestorage.Location = new System.Drawing.Point(622, 119);
            this.button_deletestorage.Name = "button_deletestorage";
            this.button_deletestorage.Size = new System.Drawing.Size(166, 56);
            this.button_deletestorage.TabIndex = 4;
            this.button_deletestorage.Text = "Очистка хранилища";
            this.button_deletestorage.UseVisualStyleBackColor = false;
            this.button_deletestorage.Click += new System.EventHandler(this.button_deletestorage_Click);
            this.button_deletestorage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // button_clear_paintbox
            // 
            this.button_clear_paintbox.BackColor = System.Drawing.Color.Pink;
            this.button_clear_paintbox.Location = new System.Drawing.Point(622, 181);
            this.button_clear_paintbox.Name = "button_clear_paintbox";
            this.button_clear_paintbox.Size = new System.Drawing.Size(166, 56);
            this.button_clear_paintbox.TabIndex = 5;
            this.button_clear_paintbox.Text = "Очистка панели";
            this.button_clear_paintbox.UseVisualStyleBackColor = false;
            this.button_clear_paintbox.Click += new System.EventHandler(this.button_clear_paintbox_Click);
            this.button_clear_paintbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Line);
            this.groupBox1.Controls.Add(this.rb_Square);
            this.groupBox1.Controls.Add(this.rb_Circle);
            this.groupBox1.Location = new System.Drawing.Point(625, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру:";
            // 
            // rb_Line
            // 
            this.rb_Line.AutoSize = true;
            this.rb_Line.Location = new System.Drawing.Point(7, 68);
            this.rb_Line.Name = "rb_Line";
            this.rb_Line.Size = new System.Drawing.Size(57, 17);
            this.rb_Line.TabIndex = 2;
            this.rb_Line.TabStop = true;
            this.rb_Line.Text = "Линия";
            this.rb_Line.UseVisualStyleBackColor = true;
            // 
            // rb_Square
            // 
            this.rb_Square.AutoSize = true;
            this.rb_Square.Location = new System.Drawing.Point(7, 44);
            this.rb_Square.Name = "rb_Square";
            this.rb_Square.Size = new System.Drawing.Size(67, 17);
            this.rb_Square.TabIndex = 1;
            this.rb_Square.TabStop = true;
            this.rb_Square.Text = "Квадрат";
            this.rb_Square.UseVisualStyleBackColor = true;
            // 
            // rb_Circle
            // 
            this.rb_Circle.AutoSize = true;
            this.rb_Circle.Location = new System.Drawing.Point(7, 20);
            this.rb_Circle.Name = "rb_Circle";
            this.rb_Circle.Size = new System.Drawing.Size(48, 17);
            this.rb_Circle.TabIndex = 0;
            this.rb_Circle.TabStop = true;
            this.rb_Circle.Text = "Круг";
            this.rb_Circle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Red);
            this.groupBox2.Controls.Add(this.rb_Green);
            this.groupBox2.Controls.Add(this.rb_Yellow);
            this.groupBox2.Location = new System.Drawing.Point(625, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите цвет:";
            // 
            // rb_Red
            // 
            this.rb_Red.AutoSize = true;
            this.rb_Red.Location = new System.Drawing.Point(7, 68);
            this.rb_Red.Name = "rb_Red";
            this.rb_Red.Size = new System.Drawing.Size(70, 17);
            this.rb_Red.TabIndex = 2;
            this.rb_Red.TabStop = true;
            this.rb_Red.Text = "Красный";
            this.rb_Red.UseVisualStyleBackColor = true;
            // 
            // rb_Green
            // 
            this.rb_Green.AutoSize = true;
            this.rb_Green.Location = new System.Drawing.Point(7, 44);
            this.rb_Green.Name = "rb_Green";
            this.rb_Green.Size = new System.Drawing.Size(70, 17);
            this.rb_Green.TabIndex = 1;
            this.rb_Green.TabStop = true;
            this.rb_Green.Text = "Зеленый";
            this.rb_Green.UseVisualStyleBackColor = true;
            // 
            // rb_Yellow
            // 
            this.rb_Yellow.AutoSize = true;
            this.rb_Yellow.Location = new System.Drawing.Point(7, 20);
            this.rb_Yellow.Name = "rb_Yellow";
            this.rb_Yellow.Size = new System.Drawing.Size(67, 17);
            this.rb_Yellow.TabIndex = 0;
            this.rb_Yellow.TabStop = true;
            this.rb_Yellow.Text = "Желтый";
            this.rb_Yellow.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(625, 447);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(163, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(625, 473);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(163, 45);
            this.trackBar1.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(803, 535);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_clear_paintbox);
            this.Controls.Add(this.button_deletestorage);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.paint_box);
            this.Name = "Main";
            this.Text = "Lab6";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paint_box;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_deletestorage;
        private System.Windows.Forms.Button button_clear_paintbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Line;
        private System.Windows.Forms.RadioButton rb_Square;
        private System.Windows.Forms.RadioButton rb_Circle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Red;
        private System.Windows.Forms.RadioButton rb_Green;
        private System.Windows.Forms.RadioButton rb_Yellow;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}


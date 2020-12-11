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
            this.SuspendLayout();
            // 
            // paint_box
            // 
            this.paint_box.BackColor = System.Drawing.Color.Honeydew;
            this.paint_box.ForeColor = System.Drawing.Color.Transparent;
            this.paint_box.Location = new System.Drawing.Point(13, 13);
            this.paint_box.Name = "paint_box";
            this.paint_box.Size = new System.Drawing.Size(602, 425);
            this.paint_box.TabIndex = 0;
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
            this.button_show.Location = new System.Drawing.Point(622, 76);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(166, 56);
            this.button_show.TabIndex = 3;
            this.button_show.Text = "Вывод из хранилища";
            this.button_show.UseVisualStyleBackColor = false;
            // 
            // button_deletestorage
            // 
            this.button_deletestorage.BackColor = System.Drawing.Color.HotPink;
            this.button_deletestorage.Location = new System.Drawing.Point(622, 138);
            this.button_deletestorage.Name = "button_deletestorage";
            this.button_deletestorage.Size = new System.Drawing.Size(166, 56);
            this.button_deletestorage.TabIndex = 4;
            this.button_deletestorage.Text = "Очистка хранилища";
            this.button_deletestorage.UseVisualStyleBackColor = false;
            // 
            // button_clear_paintbox
            // 
            this.button_clear_paintbox.BackColor = System.Drawing.Color.Pink;
            this.button_clear_paintbox.Location = new System.Drawing.Point(622, 200);
            this.button_clear_paintbox.Name = "button_clear_paintbox";
            this.button_clear_paintbox.Size = new System.Drawing.Size(166, 56);
            this.button_clear_paintbox.TabIndex = 5;
            this.button_clear_paintbox.Text = "Очистка панели";
            this.button_clear_paintbox.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clear_paintbox);
            this.Controls.Add(this.button_deletestorage);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.paint_box);
            this.Name = "Main";
            this.Text = "Lab4";
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
    }
}


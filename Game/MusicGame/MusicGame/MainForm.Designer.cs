namespace MusicGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Play = new System.Windows.Forms.Button();
            this.Params = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.Play.FlatAppearance.BorderSize = 3;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.SlateGray;
            this.Play.Location = new System.Drawing.Point(187, 155);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(139, 41);
            this.Play.TabIndex = 0;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Params
            // 
            this.Params.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Params.Image = ((System.Drawing.Image)(resources.GetObject("Params.Image")));
            this.Params.Location = new System.Drawing.Point(12, 12);
            this.Params.Name = "Params";
            this.Params.Size = new System.Drawing.Size(42, 40);
            this.Params.TabIndex = 1;
            this.Params.UseVisualStyleBackColor = true;
            this.Params.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(451, 329);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 36);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(518, 392);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Params);
            this.Controls.Add(this.Play);
            this.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Угадай мелодию";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Params;
        private System.Windows.Forms.Button Exit;
    }
}


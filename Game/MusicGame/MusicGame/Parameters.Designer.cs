namespace MusicGame
{
    partial class Params
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Params));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Select = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AllDirectory = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomStart = new System.Windows.Forms.CheckBox();
            this.musicDuration = new System.Windows.Forms.ComboBox();
            this.gameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 147);
            this.listBox1.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(40, 182);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(98, 23);
            this.Select.TabIndex = 1;
            this.Select.Text = "Выбрать папку";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(40, 211);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Очистить ";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // AllDirectory
            // 
            this.AllDirectory.AutoSize = true;
            this.AllDirectory.Location = new System.Drawing.Point(209, 186);
            this.AllDirectory.Name = "AllDirectory";
            this.AllDirectory.Size = new System.Drawing.Size(118, 17);
            this.AllDirectory.TabIndex = 3;
            this.AllDirectory.Text = "Вложенные папки";
            this.AllDirectory.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(338, 357);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(338, 386);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.randomStart);
            this.groupBox1.Controls.Add(this.musicDuration);
            this.groupBox1.Controls.Add(this.gameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // randomStart
            // 
            this.randomStart.AutoSize = true;
            this.randomStart.Location = new System.Drawing.Point(0, 128);
            this.randomStart.Name = "randomStart";
            this.randomStart.Size = new System.Drawing.Size(133, 17);
            this.randomStart.TabIndex = 4;
            this.randomStart.Text = "Со случайного места";
            this.randomStart.UseVisualStyleBackColor = true;
            // 
            // musicDuration
            // 
            this.musicDuration.FormattingEnabled = true;
            this.musicDuration.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.musicDuration.Location = new System.Drawing.Point(143, 81);
            this.musicDuration.Name = "musicDuration";
            this.musicDuration.Size = new System.Drawing.Size(67, 21);
            this.musicDuration.TabIndex = 3;
            this.musicDuration.Text = "20";
            // 
            // gameDuration
            // 
            this.gameDuration.FormattingEnabled = true;
            this.gameDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "50",
            "60"});
            this.gameDuration.Location = new System.Drawing.Point(143, 53);
            this.gameDuration.Name = "gameDuration";
            this.gameDuration.Size = new System.Drawing.Size(67, 21);
            this.gameDuration.TabIndex = 2;
            this.gameDuration.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры";
            // 
            // Params
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.AllDirectory);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Params";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Params_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private new System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox AllDirectory;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox randomStart;
        private System.Windows.Forms.ComboBox musicDuration;
        private System.Windows.Forms.ComboBox gameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
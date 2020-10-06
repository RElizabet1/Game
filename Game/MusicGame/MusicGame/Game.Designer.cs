namespace MusicGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Counter1 = new System.Windows.Forms.Label();
            this.Counter2 = new System.Windows.Forms.Label();
            this.PauseFirstPlayer = new System.Windows.Forms.Button();
            this.melodyCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resume = new System.Windows.Forms.Button();
            this.PauseSecondPlayer = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(32, 331);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(252, 47);
            this.Player.TabIndex = 0;
            this.Player.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(228, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок 2";
            // 
            // Counter1
            // 
            this.Counter1.AutoSize = true;
            this.Counter1.Location = new System.Drawing.Point(124, 106);
            this.Counter1.Name = "Counter1";
            this.Counter1.Size = new System.Drawing.Size(13, 13);
            this.Counter1.TabIndex = 4;
            this.Counter1.Text = "0";
            // 
            // Counter2
            // 
            this.Counter2.AutoSize = true;
            this.Counter2.Location = new System.Drawing.Point(435, 106);
            this.Counter2.Name = "Counter2";
            this.Counter2.Size = new System.Drawing.Size(13, 13);
            this.Counter2.TabIndex = 5;
            this.Counter2.Text = "0";
            // 
            // PauseFirstPlayer
            // 
            this.PauseFirstPlayer.Location = new System.Drawing.Point(110, 139);
            this.PauseFirstPlayer.Name = "PauseFirstPlayer";
            this.PauseFirstPlayer.Size = new System.Drawing.Size(75, 23);
            this.PauseFirstPlayer.TabIndex = 6;
            this.PauseFirstPlayer.Text = "Я знаю!";
            this.PauseFirstPlayer.UseVisualStyleBackColor = true;
            this.PauseFirstPlayer.Click += new System.EventHandler(this.PauseFirstPlayer_Click);
            // 
            // melodyCount
            // 
            this.melodyCount.AutoSize = true;
            this.melodyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.melodyCount.Location = new System.Drawing.Point(287, 106);
            this.melodyCount.Name = "melodyCount";
            this.melodyCount.Size = new System.Drawing.Size(24, 25);
            this.melodyCount.TabIndex = 8;
            this.melodyCount.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.Location = new System.Drawing.Point(84, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 30);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(253, 253);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(90, 23);
            this.resume.TabIndex = 10;
            this.resume.Text = "Продолжить";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // PauseSecondPlayer
            // 
            this.PauseSecondPlayer.Location = new System.Drawing.Point(410, 139);
            this.PauseSecondPlayer.Name = "PauseSecondPlayer";
            this.PauseSecondPlayer.Size = new System.Drawing.Size(75, 23);
            this.PauseSecondPlayer.TabIndex = 11;
            this.PauseSecondPlayer.Text = "Я знаю!";
            this.PauseSecondPlayer.UseVisualStyleBackColor = true;
            this.PauseSecondPlayer.Click += new System.EventHandler(this.PauseSecondPlayer_Click);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(538, 353);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 30);
            this.Exit.TabIndex = 12;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 395);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PauseSecondPlayer);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.melodyCount);
            this.Controls.Add(this.PauseFirstPlayer);
            this.Controls.Add(this.Counter2);
            this.Controls.Add(this.Counter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Counter1;
        private System.Windows.Forms.Label Counter2;
        private System.Windows.Forms.Button PauseFirstPlayer;
        private System.Windows.Forms.Button @continue;
        private System.Windows.Forms.Label melodyCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button PauseSecondPlayer;
        private System.Windows.Forms.Button Exit;
    }
}
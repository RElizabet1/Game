using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGame
{
    public partial class Game : Form
    {
        Random randomMusic = new Random();
        public Game()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            int music = randomMusic.Next(0, Quiz.list.Count);
            Player.URL = Quiz.list[music];
            Player.Ctlcontrols.play();
           // Quiz.list.RemoveAt(music);
            melodyCount.Text = Quiz.list.Count.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Quiz.gameDuration;
            melodyCount.Text = Quiz.list.Count.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                Player.Ctlcontrols.stop();
                MessageBox.Show("","Время вышло", MessageBoxButtons.OK);
            }
        }


        void GameResume()
        {
            timer1.Start();
            Player.Ctlcontrols.play();
        }

        void GamePause()
        {
            timer1.Stop();
            Player.Ctlcontrols.pause();
           
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            GameResume();
        }
        private void PauseFirstPlayer_Click(object sender, EventArgs e)
        {
            GamePause();
            if (MessageBox.Show("Правильный ответ?", "Игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Counter1.Text = Convert.ToString(Convert.ToInt32(Counter1.Text) + 1);
            }
        }

        private void PauseSecondPlayer_Click(object sender, EventArgs e)
        {
            GamePause();
            if (MessageBox.Show("Правильный ответ?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Counter2.Text = Convert.ToString(Convert.ToInt32(Counter2.Text) + 1);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

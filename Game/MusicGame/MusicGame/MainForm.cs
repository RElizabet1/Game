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
    public partial class MainForm : Form
    {
        Params parameters = new Params();
        public MainForm()
        {
            InitializeComponent();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
          
            parameters.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Quiz.ReadParam();
            Quiz.ReadMusic();
        }
    }
}

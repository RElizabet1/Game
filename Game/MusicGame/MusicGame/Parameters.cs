using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGame
{
    public partial class Params : Form
    {
        public Params()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Quiz.allDirectories = AllDirectory.Checked;
            Quiz.gameDuration = Convert.ToInt32(gameDuration.Text);
            Quiz.musicDuration = Convert.ToInt32(musicDuration.Text);
            Quiz.randomStart = randomStart.Checked;
            this.Hide();
            Quiz.WtiteParam();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                string[] music_list = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3", AllDirectory.Checked? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Quiz.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
                Quiz.list.Clear();
                Quiz.list.AddRange(music_list);   
            }

        }

        void Set()
        {
            AllDirectory.Checked = Quiz.allDirectories;
            gameDuration.Text = Quiz.gameDuration.ToString();
            musicDuration.Text = Quiz.musicDuration.ToString();
            randomStart.Checked = Quiz.randomStart;
        }

            private void Params_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Quiz.list.ToArray());
        }
    }
}

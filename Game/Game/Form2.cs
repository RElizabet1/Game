using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void start()
        {
            Point point = Start.Location;
            point.Offset(Start.Width / 2, Start.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            start();
        }


        private void finishGame()
        {
            DialogResult dr = MessageBox.Show("Пам пам", "Message", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                start();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
    
        }


        private void Finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            finishGame();
        }
    }


}

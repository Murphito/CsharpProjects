using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceBattle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int p1 = rnd.Next(1, 7);
            int p2 = rnd.Next(1, 7);
            switch (p1)
            {
                case 1:
                    PicBox1.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    PicBox1.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    PicBox1.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    PicBox1.Image = Properties.Resources.Dice4;
                    break;
                case 5:
                    PicBox1.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    PicBox1.Image = Properties.Resources.Dice6;
                    break;
            }
            switch (p2)
            {
                case 1:
                    PicBox2.Image = Properties.Resources.Dice1;
                    break;
                case 2:
                    PicBox2.Image = Properties.Resources.Dice2;
                    break;
                case 3:
                    PicBox2.Image = Properties.Resources.Dice3;
                    break;
                case 4:
                    PicBox2.Image = Properties.Resources.Dice4;
                    break;
                case 5:
                    PicBox2.Image = Properties.Resources.Dice5;
                    break;
                case 6:
                    PicBox2.Image = Properties.Resources.Dice6;
                    break;
            }
            if (p1 > p2) 
            {
                LbWinner.Text = "p1 has won!";
            } else if (p1 < p2)
            {
                LbWinner.Text = "p2 has won!";
            } else if (p1 == p2)
            {
                LbWinner.Text = "Tie!";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LbWinner.Text = "";
            PicBox1.Image = null;
            PicBox2.Image = null;
        }

        
    }
}

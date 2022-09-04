using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuesser
{
    public partial class Form1 : Form
    {
        int Num;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerateNum_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Num = rnd.Next(0, 100);
            LbOutput.Text = "Number has been generated!";
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            int UserInput = int.Parse(TxtInput.Text);
            if (UserInput < Num)
            {
                LbOutput.Text = "Too low!";
            } else if (UserInput > Num)
            {
                LbOutput.Text = "Too high!";
            } else if (UserInput == Num)
            {
                string message = "you won!";
                MessageBox.Show(message);
            }
        }
    }
}

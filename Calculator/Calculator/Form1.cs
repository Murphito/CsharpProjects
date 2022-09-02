using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string Operator;
        int input1;
        int input2;
        float Output;
        bool check1;
        bool check2;
        string error;
        public Form1()
        {
            InitializeComponent();
        }

        // all Operator select buttons
        private void Plus_Click(object sender, EventArgs e)
        {
            Operator = "+";
            InOperator.Text = Operator;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Operator = "-";
            InOperator.Text = Operator;
        }

        private void Times_Click(object sender, EventArgs e)
        {
            Operator = "*";
            InOperator.Text = Operator;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Operator = "/";
            InOperator.Text = Operator;
        }

        // calculate button
        private void Calculate_Click(object sender, EventArgs e)
        {
            //checks input 1 and 2 if it is a int
            check1 = int.TryParse(In1.Text, out input1);
            check2 = int.TryParse(In2.Text, out input2);
            if (InOperator.Text != "?") // if operator is not empty go on
            {
                if (In1.TextLength > 0)
                {                               // checks if input 1 and 2 are empty
                    if (In2.TextLength > 0)
                    {
                        if (check1 == true)
                        {                           // checks var check 1 and check 2
                            if (check2 == true)
                            {
                                input1 = Int32.Parse(In1.Text);
                                input2 = Int32.Parse(In2.Text);
                                switch (Operator)                 // switch case for operator check and the calculation
                                {
                                    case "+":
                                        Output = input1 + input2;
                                        Awnser.Text = Output.ToString();
                                        break;
                                    case "-":
                                        Output = input1 - input2;
                                        Awnser.Text = Output.ToString();
                                        break;
                                    case "*":
                                        Output = input1 * input2;
                                        Awnser.Text = Output.ToString();
                                        break;
                                    case "/":
                                        Output = input1 / input2;
                                        Awnser.Text = Output.ToString();
                                        break;
                                }
                                // error logging
                            } else {
                                error = "Field 2 is not a number!";
                                Awnser.Text = error;
                            }
                        } else {
                            error = "Field 1 is not a number";
                            Awnser.Text = error;
                        }
                    } else {
                        error = "Field 2 is empty!";
                        Awnser.Text = error;
                    }
                } else {
                    error = "Field 1 is empty!";
                    Awnser.Text = error;
                }
            } else {
                error = "No Operator selected!";
                Awnser.Text = error;
            }
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            In1.Text = "";
            In2.Text = "";
            input1 = 0;
            input2 = 0;
            Awnser.Text = "";
            Operator = "?";
            InOperator.Text = Operator;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathOperators
{ //this program is done now 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            outputLabel.ForeColor = Color.DarkTurquoise;
            outputLabel.Text = "TV\n";
            double numberOne, numberTwo, Answer;

            numberOne = 8.8;
            numberTwo = 2.2;

            Answer = numberOne + numberTwo;
            
            outputLabel.Text += Answer + "";

            Answer++;

            outputLabel.Text += "\n" + Answer;

            int numberThree = 13;
            int modValue = numberThree % 3;

            outputLabel.Text += "\n" + modValue; 
        }


    }
}

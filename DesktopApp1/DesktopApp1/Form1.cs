using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void D20button_Click(object sender, EventArgs e)
        {
            Random D20 = new Random();
            Resultsbox.Text = D20.Next(1, 21).ToString();
        }

        private void D100button_Click(object sender, EventArgs e)
        {
            Random D100 = new Random();
            Resultsbox.Text = D100.Next(1, 101).ToString();
        }

        private void D12button_Click(object sender, EventArgs e)
        {
            Random D12 = new Random();
            Resultsbox.Text = D12.Next(1, 13).ToString();
        }

        private void D10button_Click(object sender, EventArgs e)
        {
            Random D10 = new Random();
            Resultsbox.Text = D10.Next(1, 11).ToString();
        }

        private void D8button_Click(object sender, EventArgs e)
        {
            Random D8 = new Random();
            Resultsbox.Text = D8.Next(1, 9).ToString();
        }

        private void D6button_Click(object sender, EventArgs e)
        {
            Random D6 = new Random();
            Resultsbox.Text = D6.Next(1, 7).ToString();
        }

        private void D4button_Click(object sender, EventArgs e)
        {
            Random D4 = new Random();
            Resultsbox.Text = D4.Next(1, 5).ToString();
            //Resultsbox.Text += D4.Next(1, 5).ToString() + " ,";
        }

        private void D3button_Click(object sender, EventArgs e)
        {
            Random D3 = new Random();
            Resultsbox.Text = D3.Next(1, 4).ToString();
        }

        private void D66button_Click(object sender, EventArgs e)
        {
            Random D66 = new Random();
            Resultsbox.Text = D66.Next(1, 7).ToString() + D66.Next(1, 7).ToString();
        }
    }
}

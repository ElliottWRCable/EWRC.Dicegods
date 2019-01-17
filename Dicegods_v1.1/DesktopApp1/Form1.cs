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

        private void BtnMultiD6_Click(object sender, EventArgs e)
        {
            int numt;
            int tot = 0;
            int subtot = 0;
            int low, high;
            high = 0;
            int mins = 0;
            int maxs = 0;
            int audits = 0;
            int mod = Convert.ToInt32(Nudmod01.Value);
            if(mod != 0)
            {
                audits++;
            }
            string die = Cbtype.Text;
            numt = Convert.ToInt32(NudMultiD6.Value);
            //Convert the value input into the NumericalUpDown into an integer value and set it as the variable numt.
            Random XD6 = new Random();
            //Needs to be outside of the loop so that a NEW random number is generayed each time to loop iterates.
            if(Cbad.Checked == true)
            {
                numt++;
                audits++;
            }
            if (Cbdisad.Checked == true)
            {
                numt++;
                audits++;
            }
            Resultsbox.Text = "";
            Tbtotal.Text = "";
            //Clear the results box before starting the loop, so that it is easier to see the new ste of results.
            if (die == "D6")
            {
                low = 6;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 7);
                        if(subtot > high)
                        {
                            high = subtot;
                        }
                        if(subtot < low)
                        {
                            low = subtot;
                        }
                        if(subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 7);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                    
                }
                if(audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if(Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }
                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D100")
            {
                low = 100;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 101);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 101);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }
                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D20")
            {
                low = 20;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 21);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 21);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D12")
            {
                low = 12;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 13);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 13);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D10")
            {
                low = 10;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 11);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 11);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D8")
            {
                low = 8;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 9);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 9);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D4")
            {
                low = 4;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 5);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 5);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D3")
            {
                low = 3;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, 4);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, 4);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
            else if (die == "D66")
            {
                low = 66;
                for (int i = numt; i > 0; i--)
                {
                    string subtxt;
                    if (i == 1)
                    {
                        subtxt = XD6.Next(1, 7).ToString() + XD6.Next(1, 7).ToString();
                        Resultsbox.Text += subtxt;
                        subtot = Convert.ToInt32(subtxt);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 11)
                        {
                            mins++;
                        }
                        tot += subtot;
                    }
                    else
                    {
                        subtxt = XD6.Next(1, 7).ToString() + XD6.Next(1, 7).ToString();
                        Resultsbox.Text += subtxt + " + ";
                        subtot = Convert.ToInt32(subtxt);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 11)
                        {
                            mins++;
                        }
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
            else if (die == "Custom")
            {
                int ctm = Convert.ToInt32(Nudcustom.Value);
                low = ctm;
                int tctm = ctm + 1;
                for (int i = numt; i > 0; i--)
                {
                    if (i == 1)
                    {
                        subtot = XD6.Next(1, tctm);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        if (subtot == 1)
                        {
                            mins++;
                        }
                        Resultsbox.Text += subtot.ToString();
                        tot += subtot;
                    }
                    else
                    {
                        subtot = XD6.Next(1, tctm);
                        if (subtot > high)
                        {
                            high = subtot;
                        }
                        if (subtot < low)
                        {
                            low = subtot;
                        }
                        Resultsbox.Text += subtot.ToString() + " + ";
                        tot += subtot;
                    }
                }
                if (audits != 0)
                {
                    Resultsbox.Text += " (";
                }
                if (mod < 0)
                {
                    Resultsbox.Text += " " + mod.ToString();
                }
                else if (mod == 0)
                {
                    //Oh look, Nothing.
                }
                else
                {
                    Resultsbox.Text += " + " + mod.ToString();
                }
                tot += mod;

                if (Cbad.Checked == true)
                {
                    tot -= low;
                    Resultsbox.Text += " - " + low.ToString();
                }
                if (Cbdisad.Checked == true)
                {
                    tot -= high;
                    Resultsbox.Text += " - " + high.ToString();
                }
                if (audits != 0)
                {
                    Resultsbox.Text += ")";
                }
                if (Cbtmin.Checked == true)
                {
                    Resultsbox.Text += " (" + mins.ToString() + " 1s rolled)";
                }

                Tbtotal.Text = tot.ToString();
            }
        } 

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            Resultsbox.Text = "";
            Tbtotal.Text = "";
        }

    }
}

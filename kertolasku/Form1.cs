using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kertolasku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,syote;
            int[] luvut = new int[3];


                try {

                    for (i = 0; i < 3; i++)

                        syote = Convert.ToInt32(textBox1.Text);
                    for (i = 1; i < 11; i++) { }
                    tulosL.ForeColor = System.Drawing.Color.Black;
                    tulosL.Text = i + "*" + syote + " = " + i * syote;
                    tulosL.Update();
                }
                

                catch (System.FormatException)
                {
                    tulosL.ForeColor = System.Drawing.Color.Red;
                    tulosL.Text = "Ohjelmassa tapahtui virhe!";
                }
        }
    }
}

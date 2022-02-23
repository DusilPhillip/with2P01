using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random cis = new Random();
            int soucet = 0;
            int pocet = 0;
            foreach ( Control ctrl in panel1.Controls)
            {

                if( ctrl is TextBox )
                {
                    
                    int cislo = cis.Next(5, 21);
                    (ctrl as TextBox).Text = cislo.ToString();

                    if ( cislo % 7 == 0)
                    {
                        soucet += cislo;
                        pocet++;

                    }
                }
            }
            double a_prumer = (double)(soucet) / pocet;
            label1.Text = " Aritmetický půměr je:" + a_prumer;
        }
    }
}

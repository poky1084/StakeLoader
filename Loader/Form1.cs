using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keno;
using Limbo;
using Rouletee;

namespace Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limbo.Form1 limbo = new Limbo.Form1();
            limbo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Keno.Form1 keno = new Keno.Form1();
            keno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rouletee.Form1 roulette = new Rouletee.Form1();
            roulette.Show();
        }
    }
}

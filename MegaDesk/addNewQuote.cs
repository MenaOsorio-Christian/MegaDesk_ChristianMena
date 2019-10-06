using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class addNewQuote : Form
    {
        public addNewQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegaDesk megaDesk = (MegaDesk)Tag;
            megaDesk.Show();
            Close();
        }

    }
}

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
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            addNewQuote addNewQuote = new addNewQuote();
            addNewQuote.Tag = this;
            addNewQuote.Show(this);
            this.Hide();
        }

        private void MegaDesk_Load(object sender, EventArgs e)
        {

        }
    }
}

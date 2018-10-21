using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_1._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAllQuotesForm = new ViewAllQuotes { Tag = this };
            ViewAllQuotesForm.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote AddQuoteForm = new AddQuote { Tag = this };
            AddQuoteForm.Show(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotesForm = new SearchQuotes { Tag = this };
            SearchQuotesForm.Show(this);
        }

        private void button4_Click(object sender, FormClosingEventArgs e)
        {
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

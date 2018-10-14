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
    public partial class ViewQuote : Form
    {
      

            public ViewQuote(string text, string width, string depth, string option, string material, string rush)
            {
                InitializeComponent();

                nameReceived.Text = text;
                widthReceived.Text = width;
            depthReceived.Text = depth;
            drawerReceived.Text = option;
            materialReceived.Text = material;
            rushReceived.Text = rush ;

           

        }

        private void ViewQuote_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

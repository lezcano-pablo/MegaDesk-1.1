using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_1._0
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> desktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            materialOption.DataSource = desktopMaterialList;


        }

        public int Width { get; set; }
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        private void button1_Click(object sender, EventArgs e)
        {

            var MainMenuForm = (MainMenu)Tag;
            MainMenuForm.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {


            try
            {

                string name = NameBox.Text;
                int width = Convert.ToInt32(widthBox.Text);
                int depth = Convert.ToInt32(DepthBox.Text);
                string rush = rushOption.Text;
                string option = numerosOpcion.Text;
                string material = materialOption.Text;

                if (width > MAX_WIDTH|| width<MIN_WIDTH)
                {
                    MessageBox.Show("Width Out of range, acceptable range are between 24 and 96 inches");

                }
                else if( depth<MIN_DEPTH||depth>MAX_DEPTH)
                {
                    MessageBox.Show("Depth Out of range, acceptable range are between 12 and 48 inches");

                }

                else
                {
                    ViewQuote n = new ViewQuote(name, width.ToString(), depth.ToString(), option, material, rush);

                    n.Show();

                    string tempurl = "C:\\test\\" + name + ".txt";

                    if (File.Exists(tempurl))
                    {
                        MessageBox.Show("Impossible to create the file, the name is already in use");

                    }

                    else
                    {
                        File.WriteAllText(tempurl, name + "- " + width + " - " + depth + " - " + option + " - " + material + "- " + rush);
                        MessageBox.Show("File saved succesfully");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error, you must fill all the fiel");

            }
        }
    


        private void NameBox_TextChanged(KeyPressEventArgs e, object sender)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;


            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show(" Solo se admiten letras", "validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;


            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }

            else
            {
                e.Handled = true;
                MessageBox.Show(" Only letters are allowed", "validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthBox_KeyPress(object sender, KeyPressEventArgs e)
        {




            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;


            }

            
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }

          
            else
            {
                e.Handled = true;
                MessageBox.Show(" Only numbers Alloweds", "validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DepthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;


            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }


            else
            {
                e.Handled = true;
                MessageBox.Show(" Only numbers Allowed", "validación de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void none_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rushDay1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepthBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
       
       
            
        
    


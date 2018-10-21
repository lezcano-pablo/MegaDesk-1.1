using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_1._0
{
    class DeskQuote
    {

        private string CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();
        public int RushDays= 0;


        private const int PRICE_BASE = 200;

        public static int Rushdays { get; internal set; }

      

        int[,] extraCharges = new int[3, 3];

      




        public int[,] getRushOrder(string fileName)
        {

            int[,] extraCarges = new int[3, 3];

            try
            {
                string[] lines = File.ReadAllLines(fileName);

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        extraCarges[i, j] = int.Parse(lines[j + (3 * i)]);
                    }
                }
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("There was a problem while trying to read the file" + e);
            }
            catch (NullReferenceException ne)
            {
                System.Windows.Forms.MessageBox.Show("Null point exception " + ne);
            }

            return extraCarges;
        }
    }
}

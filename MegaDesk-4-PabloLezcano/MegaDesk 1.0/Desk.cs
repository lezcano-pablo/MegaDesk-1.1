using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1._0
{
    class Desk
    {
        public int Width { get; set; }
        public const int MIN_WIDTH = 25;
        public const int MAX_WIDTH = 97;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
    }


    public enum DesktopMaterial
    {
        Pine = 50,
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 150,

    }

    public enum RushDays
    {
       option1= 3, 
       option2= 5,
       option3= 7

    }



}

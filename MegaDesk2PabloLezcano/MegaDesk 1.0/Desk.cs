using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1._0
{
    struct Desk
    {
        public int Width { get; set; }
        public const int MIN_WIDTH = 25;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public int width;
        public int depth;
        public int drawers;
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


    public enum drawers
    {
        option1= 1,
        option2=2,
        option3= 3,
        option4=4,
        option5=5,
        option6=6,
        option7=7
    }



}

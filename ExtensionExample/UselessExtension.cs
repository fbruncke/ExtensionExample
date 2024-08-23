using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample
{
    static class UselessExtension
    {

        public static string ConvertToHex(this int number, int addNo)
        {
            string myHex = (number+addNo).ToString("X");
            return myHex;
        }

        public static String ThisIsCool(this Object theObject)
        {
            return "Cool";
        }

        public static String GetPointX(this Point p)
        {
            return p.X.ToString();
        }


    }
}

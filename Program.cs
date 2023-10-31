using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitveDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
                
        }
        public static void doApp() 
        {
            bool msg = true;
            byte xbyte = 250;
            sbyte xsbyte = -100;
            char xchar = 'a';
            decimal xdecimal = 87.9M;
            double xdouble = 651.09;
            float xfloat = 465.1f;
            int xint = -8909;
            uint xuint = 91881;
            long xlong = -1313131312;
            ulong xulong = 01919181;
            object xobject = new object();
            short xshort = -19;
            ushort xushort = 19;
            string xstring = "name";

            if (msg == true && xbyte < 100)
                Console.WriteLine("This expression evaluates to true");
            else
                Console.WriteLine("This expression evaluates to false");
            if (xshort > 6 || xint > -9000)
                Console.WriteLine("This expression evaluates to false");
            else
                Console.WriteLine("This expression evaluates to true");
            if (xuint == 91881 && xulong < 0)
                Console.WriteLine("This expression evaluates to true");
            else
               Console.WriteLine("This expression evaluates to false");
        }
    }
}
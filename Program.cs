using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmetods2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            stringmetods2 myString = new stringmetods2();
            string str = "vesige Aze7629298792 dir 00000";
            string data = "!!!Ele!!kber!!";
            string check= " ramazan";
            myString.Str = str;
            myString.Data = data;
           
            
            Console.WriteLine(myString.GetLength());

            Console.WriteLine(myString.Substring(15, 3));
            Console.WriteLine(myString.indexOf("ir"));
            Console.WriteLine(myString.Contains("dir"));
            Console.WriteLine(myString.Insert(10,"Ramazan"));
            Console.WriteLine(myString.RemoveChar(10));
            Console.WriteLine(myString.Remove(10,5));
            Console.WriteLine(myString.Padleft(33,'0'));
            Console.WriteLine(myString.PadRight(33, '0'));
            Console.WriteLine(myString.StartWith("ves"));
            Console.WriteLine(myString.EndsWith("Aze"));
            Console.WriteLine(myString.Replace("Aze","Geo"));
            //Console.WriteLine(myString.LastIndexOf("e"));
           // Console.WriteLine(myString.TrimEnds('!'));
            //Console.WriteLine(myString.FirstIndexOf("e"));
           // Console.WriteLine(myString.TrimEnds("0"));
            Console.WriteLine(myString.Trim('!'));

            string netice = "";
            foreach (char i in check)
            {
                int z = (int)i;
                if (z >= 97 && z <= 122)
                {
                    z -= 32;
                    netice += (char)z;
                    


                }
            }
            Console.WriteLine(netice);



            Console.ReadLine();

        }
    }
}

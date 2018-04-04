using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitString
{
    class Program
    {

        static void Main(string[] args)
        {
            char dell = ',';
            string name = "Azor Ahai,Jordan,Lockhart";
            var printlist = splinter(name, dell);
            for (int i = 0; i < printlist.Count; i++)
            {
                Console.WriteLine(printlist[i]);
            }
            Console.ReadLine();

        }
        static List<string> splinter(string name, char dell)
        {
            List<string> splitnames = new List<string>();


            string newstring = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ',')
                {
                    newstring = newstring + name[i];
                }
                else if (name[i] == ',')
                {
                    splitnames.Add(newstring);
                    newstring = "";
                }

            }
            splitnames.Add(newstring);
            return splitnames;
        }
    }
}
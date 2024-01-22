using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class John
    {
        private static string name = "Gabe"; // when specified as 'static', one instance is created in memory and
                                         // not created when instance of class is created. Static methods 
                                         // can't modify non static objects

        public void setName(string n)
        {
            name = n;
        }

        public string getName() // getter
        {
            return name;
        }

        private string test { get; set; } // creates a getter and setter
    }
}
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_Farner
{
    internal class Farmer
    {
        public string = FirstName { get; set; }
        public string = LastName { get; set; }

        public Dog? MyDog {  get; set; }        // ?: Datenkomponente oder Property kann irgendwann null werden.

        public Cat MyCat {  get; set; }

        public Farmer(string firstName, string lastName)
{
        FristName = firstName;
        LastName = lastName;
        MyDog = null;               // My Dog hat keinen Wert
        MyCat = myCat
}

    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Farner
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Cat(string name, string color)
        {
            Name = name;        // setter des Proporties
            Color = color;
        }

        public GetInfo()
        {
            return $"{this.Name}:{this.Color}";
        }
 

        public string Info        //Read-Only Property
        {
            get
            {
                return $"{this.Name}:{this.Color}";
            }
        }
        }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Farner
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Bread {  get; set; }

        public Dog(string name, string breed)
        {
            Name = name;
            Bread = breed;
        }

        public string Info
        {
            get
            {
                return $"{this.Name}:{this.Breed}";
    }
}

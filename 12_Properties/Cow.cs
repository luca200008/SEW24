using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Properties
{
    internal class Cow
    {
        private string name;
        private int age;
        private double weight;

        public Cow(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public string Breed { get; set; }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }

        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this.age = value;
                if (age > 0)

            }

        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this.weight = value;
            }

        }
    }
}

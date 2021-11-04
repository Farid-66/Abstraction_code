using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask3
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string SetName(string name);
        public abstract string GetName();
        public abstract void Eat();
    }
}

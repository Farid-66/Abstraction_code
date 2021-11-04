using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask3
{
    class Dog : Animal
    {
        public override string Name { get ; set ; }

        public override void Eat()
        {
            Console.WriteLine("Eating");
        }

        public override string GetName()
        {
            return $"{this.Name}";
        }

        public override string SetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}

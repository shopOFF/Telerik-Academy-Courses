using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Composition
{
    public class CatComposition
    {
        private AnimalComposition animalComposition;

        public CatComposition(AnimalComposition animal)
        {
            this.AnimalComposition = animal;
        }

        public AnimalComposition AnimalComposition
        {
            get { return this.animalComposition; }
            private set { this.animalComposition = value; }
        }

        public override string ToString()
        {
            return $"Myauuu - {base.ToString()}";
        }
    }
}

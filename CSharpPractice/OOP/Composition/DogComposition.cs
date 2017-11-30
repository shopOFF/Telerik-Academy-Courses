using OOP.Composition.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Composition
{
    public class DogComposition
    {
        private readonly AnimalComposition animalComposition;
        private readonly IWalk walkingComposition;

        public DogComposition(AnimalComposition animal, IWalk walking)
        {
            this.animalComposition = animal;
            this.walkingComposition = walking;
        }


        public override string ToString()
        {
            return $"Bau Baiu - {this.animalComposition.Name} - {this.animalComposition.Age} - {this.walkingComposition.Walking()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    public abstract class Herbivore<TFood>: Creatures<TFood>
        where TFood : FoodForCreatures
    { 
        public Herbivore(int x, int y, Map map): base (x, y, map)
        {

        }

        public override void ChangeColor()
        {
            if (degreeOfSatiety >= (int)State.Good)
                color = Brushes.Olive;
            else if (degreeOfSatiety >= (int)State.Bad)
                color = Brushes.OliveDrab;
            else if (degreeOfSatiety > (int)State.Madness)
                color = Brushes.DarkOliveGreen;
            else color = Brushes.Gray;
        }
                
    }

}


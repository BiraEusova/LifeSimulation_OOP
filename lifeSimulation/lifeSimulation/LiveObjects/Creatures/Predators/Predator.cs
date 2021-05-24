using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    public abstract class Predator <TFood> : Creatures<TFood>
        where TFood : FoodForCreatures
    {
        public Predator(int x, int y, Map map) : base(x, y, map)
        {

        }
        
        public override void ChangeColor()
        {
            if (degreeOfSatiety >= (int)State.Good)
                color = Brushes.Peru;
            else if (degreeOfSatiety >= (int)State.Bad)
                color = Brushes.Sienna;
            else if (degreeOfSatiety > (int)State.Madness)
                color = Brushes.SaddleBrown;
            else color = Brushes.Gray;
        }

    }
}

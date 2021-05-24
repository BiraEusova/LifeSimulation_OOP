using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{

    public abstract class Omnivore<TFood> : Creatures<TFood>
        where TFood: FoodForCreatures
    {
        public Omnivore(int x, int y, Map map) : base(x, y, map)
        {

        }

        public override void ChangeColor()
        {
            if (degreeOfSatiety >= (int)State.Good)
                color = Brushes.MediumOrchid;
            else if (degreeOfSatiety >= (int)State.Bad)
                color = Brushes.DarkOrchid;
            else if (degreeOfSatiety > (int)State.Madness)
                color = Brushes.Purple;
            else color = Brushes.Gray;
        }

    }
}

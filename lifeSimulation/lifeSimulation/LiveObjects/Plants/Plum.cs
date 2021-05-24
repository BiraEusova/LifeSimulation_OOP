using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    public class Plum : Plant, BunnysFood, KoalasFood, CowsFood, BearsFood, RaccoonsFood, HedgehogsFood, HumansFood
    {
        public Plum(int x, int y, Map map) : base (x, y, map){}

        public override void setColor(bool venomous)
        {
            if (venomous)
                Color = Brushes.Violet;
            else
                Color = Brushes.Plum;
        }
    }
}

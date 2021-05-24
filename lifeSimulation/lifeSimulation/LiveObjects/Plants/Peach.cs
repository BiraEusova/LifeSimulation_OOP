using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Peach : Plant, BunnysFood, KoalasFood, CowsFood, HedgehogsFood, RaccoonsFood, HumansFood
    {
        public Peach(int x, int y, Map map) : base(x, y, map) { }

        public override void setColor(bool venomous)
        {
            if (venomous)
                Color = Brushes.BurlyWood;
            else
                Color = Brushes.PeachPuff;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Strawberry : Plant, BunnysFood, KoalasFood, CowsFood, BearsFood, HedgehogsFood, HumansFood
    {
        public Strawberry(int x, int y, Map map) : base(x, y, map) { }

        public override void setColor(bool venomous)
        {
            if (venomous)
                Color = Brushes.LightPink;
            else
                Color = Brushes.Pink;
        }
    }
}

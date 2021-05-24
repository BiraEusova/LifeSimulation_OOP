using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Cow : Herbivore<CowsFood>, TigersFood, BearsFood, HumansFood
    {
        public Cow(int x, int y, Map map) : base(x, y, map) { }
        public override void Birth()
        {
            AbilityToBirth = false;
            CurFromBirth = 100;
            Cow baby = new Cow(x, y, map);
            baby.CurFromBirth = 100;
            baby.AbilityToBirth = false;
            map.allLiveObjects.Add(baby);
        }

        public override void setKindAndName()
        {
            KindForDisplay = "Herbivore";
            NameForDisplay = "Cow";
        }
    }
}

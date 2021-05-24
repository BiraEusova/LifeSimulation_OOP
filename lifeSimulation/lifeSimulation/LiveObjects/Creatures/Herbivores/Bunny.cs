using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Bunny : Herbivore<BunnysFood>, TigersFood, FoxsFood, OttersFood, HedgehogsFood, RaccoonsFood, HumansFood
    {
        public Bunny(int x, int y, Map map) : base(x, y, map) { }

        public override void Birth()
        {
            AbilityToBirth = false;
            CurFromBirth = 100;
            Bunny baby = new Bunny(x, y, map);
            baby.CurFromBirth = 100;
            baby.AbilityToBirth = false;
            map.allLiveObjects.Add(baby);
        }

        public override void setKindAndName()
        {
            KindForDisplay = "Herbivore";
            NameForDisplay = "Bunny";
        }
    }
}

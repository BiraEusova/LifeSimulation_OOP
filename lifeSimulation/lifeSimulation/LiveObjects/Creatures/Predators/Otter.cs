using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Otter : Predator<OttersFood>, BearsFood, HumansFood
    {
        public Otter(int x, int y, Map map) : base(x, y, map)
        {

        }
        public override void Birth()
        {
            AbilityToBirth = false;
            CurFromBirth = 100;
            Otter baby = new Otter(x, y, map);
            baby.CurFromBirth = 100;
            baby.AbilityToBirth = false;
            map.allLiveObjects.Add(baby);
        }

        public override void setKindAndName()
        {
            KindForDisplay = "Predator";
            NameForDisplay = "Otter";
        }
    }
}

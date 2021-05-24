using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Bear : Omnivore<BearsFood>, HumansFood
    {
        public Bear(int x, int y, Map map) : base(x, y, map)
        {

        }
        public override void Birth()
        {
            AbilityToBirth = false;
            CurFromBirth = 100;
            Bear baby = new Bear(x, y, map);
            baby.CurFromBirth = 100;
            baby.AbilityToBirth = false;
            map.allLiveObjects.Add(baby);
        }

        public override void setKindAndName()
        {
            KindForDisplay = "Omnivore";
            NameForDisplay = "Bear";
        }
    }
}

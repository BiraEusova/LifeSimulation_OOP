using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Koala : Herbivore<KoalasFood>, TigersFood, FoxsFood, HumansFood
    {
        public Koala(int x, int y, Map map) : base(x, y, map) { }
        public override void Birth()
        {
            AbilityToBirth = false;
            CurFromBirth = 100;
            Koala baby = new Koala(x, y, map);
            baby.CurFromBirth = 100;
            baby.AbilityToBirth = false;
            map.allLiveObjects.Add(baby); 
        }

        public override void setKindAndName()
        {
            KindForDisplay = "Herbivore";
            NameForDisplay = "Koala";
        }
    }
}

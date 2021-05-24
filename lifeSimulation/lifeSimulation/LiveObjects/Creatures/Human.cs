using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    public class Human : Creatures<HumansFood>
    {
        public Human(int x, int y, Map map) : base(x, y, map)
        {

        }

        public override void Birth()
        {
            AbilityToBirth = false;
            CurFromBirth = 100;
            Human baby = new Human(x, y, map);
            baby.CurFromBirth = 100;
            baby.AbilityToBirth = false;
            map.allLiveObjects.Add(baby);
        }

        public override void ChangeColor()
        {
            if (degreeOfSatiety >= (int)State.Good)
                color = Brushes.Navy;
            else if (degreeOfSatiety >= (int)State.Bad)
                color = Brushes.MidnightBlue;
            else if (degreeOfSatiety > (int)State.Madness)
                color = Brushes.MidnightBlue;
            else color = Brushes.Gray;
        }

        public override void setKindAndName()
        {
            KindForDisplay = "True omnivore";
            NameForDisplay = "Human";
        }
    }
}

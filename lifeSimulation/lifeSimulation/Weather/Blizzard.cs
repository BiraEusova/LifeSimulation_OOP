using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Blizzard
    {
        public Blizzard()
        {

        }

        public void makeBlizzard(Map map)
        {

            IEnumerable<Creatures<FoodForCreatures>> сreatures = new List<Creatures<FoodForCreatures>>();
            сreatures = map.allLiveObjects.OfType<Creatures<FoodForCreatures>>().Where(creature => creature.Rotten);

            foreach (Creatures<FoodForCreatures> creature in сreatures)            
                if (creature.DegreeOdSatiety < 40) 
                    map.allLiveObjects.Remove(creature);
            
        }
    }
}

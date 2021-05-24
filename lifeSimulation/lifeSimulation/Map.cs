using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    public class Map
    {
        public Random random = new Random();
        private int size = 1000;
        public int Size => size;

        public Weather weather { get; set; }

        public struct Border
        {
            public int top;
            public int bot;
            public int left;
            public int right;
        };

        public List<LiveGameObject> allLiveObjects = new List<LiveGameObject>();
        public List<LiveGameObject> rottenAndEatenAllCreatures = new List<LiveGameObject>();
        public Map()
        {
           
        }

        public Border CheckBorder(int x, int y, int rad)
        {
            Border border;
            border.top = 0;
            border.bot = size - 1;
            border.left = 0;
            border.right = size - 1;


            if (x - rad <= 0)   //вычисление границ право/лево
                border.bot = x + rad;
            else if (x + rad >= size)
                border.top = x - rad;
            else
            {
                border.top = x - rad;
                border.bot = x + rad;
            }

            if (y - rad <= 0)   //вычисление границ верх/низ
                border.right = y + rad;
            else if (y + rad >= size)
                border.left = y - rad;
            else
            {
                border.left = y - rad;
                border.right = y + rad;
            }

            return border;
        }
        public bool JamCheck(int x, int y, int route)
        {
            if (x == 0 && route == (int)Route.Up) return true;
            else if (x == size - 1 && route == (int)Route.Down) return true;
            else if (y == 0 && route == (int)Route.Left) return true;
            else if (y == size - 1 && route == (int)Route.Right) return true;
            else return false;
        }

        public void RebornPlant(Plant plant)
        {
            plant.Overgrowth(this);
        }

        public void RemoveCreature(LiveGameObject creature)
        {
            rottenAndEatenAllCreatures.Add(creature);
        }

        public void RemoveAllAnimal()
        {

            List<Creature> rottenCreatures = allLiveObjects.OfType<Creature>().Where(creature => creature.Rotten).ToList();

            for (int i = rottenCreatures.Count() - 1; i >= 0; i--)
            {
                createNewRandomPlant(rottenCreatures[i].x, rottenCreatures[i].y);
                allLiveObjects.Remove(rottenCreatures[i]);
            }


            List<Creature> eatenCreatures = allLiveObjects.OfType<Creature>().Where(creature => creature.Eaten).ToList();

            for (int i = eatenCreatures.Count() - 1; i >= 0; i--)
                allLiveObjects.Remove(eatenCreatures[i]);

        }

        private void createNewRandomPlant(int x, int y)
        {
            if (random.Next(3) == 0)
            {
                Plum newPlum = new Plum(x, y, this);
                allLiveObjects.Add(newPlum);
            }
            else if (random.Next(3) == 1)
            {
                Peach newPeach = new Peach(x, y, this);
                allLiveObjects.Add(newPeach);
            }
            else if (random.Next(3) == 2)
            {
                Strawberry newStrawberry = new Strawberry(x, y, this);
                allLiveObjects.Add(newStrawberry);
            }
        }
    }
}

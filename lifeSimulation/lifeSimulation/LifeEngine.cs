using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    internal class LifeEngine
    {
        public LifeEngine(int size, int density, Map map)
        {
            Weather weather = new Weather(map);
            Blizzard blizzard = new Blizzard();

            int densityForPlants = density / 3;                        // для баланса травки должно быть изначально больше
            
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (map.random.Next(density) == 0)
                    {
                        if (map.random.Next(25) < 5)
                        {
                            if (map.random.Next(3) == 0)
                            {
                                Bear myBear = new Bear(x, y, map);
                                map.allLiveObjects.Add(myBear);
                            }
                            else if (map.random.Next(3) == 1)
                            {
                                Hedgehog myHedgehog = new Hedgehog(x, y, map);
                                map.allLiveObjects.Add(myHedgehog);
                            }
                            else
                            {
                                Raccoon myRaccoon = new Raccoon(x, y, map);
                                map.allLiveObjects.Add(myRaccoon);
                            }
                        }           // спавн всеядных
                        else if (map.random.Next(25) < 15)
                        {
                            if (map.random.Next(3) == 0)
                            {
                                Bunny myBunny = new Bunny(x, y, map);
                                map.allLiveObjects.Add(myBunny);
                            }
                            else if (map.random.Next(3) == 1)
                            {
                                Koala myKoala = new Koala(x, y, map);
                                map.allLiveObjects.Add(myKoala);
                            }
                            else
                            {
                                Cow myCow = new Cow(x, y, map);
                                map.allLiveObjects.Add(myCow);
                            }
                        }     // спавн травоядных
                        else if (map.random.Next(25) < 20)
                        {
                            if (map.random.Next(3) == 0)
                            {
                                Tiger myTiger = new Tiger(x, y, map);
                                map.allLiveObjects.Add(myTiger);
                            }
                            else if (map.random.Next(3) == 1)
                            {
                                Otter myOtter = new Otter(x, y, map);
                                map.allLiveObjects.Add(myOtter);
                            }
                            else
                            {
                                Fox myFox = new Fox(x, y, map);
                                map.allLiveObjects.Add(myFox);
                            }
                        }     // спавн хищников
                        else if (map.random.Next(25) < 20)
                        {                            
                            Human myHuman = new Human(x, y, map);
                            map.allLiveObjects.Add(myHuman);                            
                        }     // спавн людей
                    }              // рандомный спавн животных
                    if (map.random.Next(densityForPlants) == 0)
                    {
                        if (map.random.Next(3) == 0)
                        {
                            Plum myPlum = new Plum(x, y, map);
                            map.allLiveObjects.Add(myPlum);
                        }
                        else if (map.random.Next(3) == 1)
                        {
                            Peach myPeach = new Peach(x, y, map);
                            map.allLiveObjects.Add(myPeach);
                        }
                        else
                        {
                            Strawberry myStrawberry = new Strawberry(x, y, map);
                            map.allLiveObjects.Add(myStrawberry);
                        }
                    }     // рандомный спавн травки
                }
            }

            //for (int x = 0; x < size; x++)
            //{
            //    for (int y = 0; y < size; y++)
            //    {
            //        // рандомный спавн животных

            //        if (map.random.Next(densityForPlants) == 0)
            //        {
            //            myPlant = new Plants(x, y, map);
            //            map.allCreatures.Add(myPlant);
            //            map.plants.Add(myPlant);
            //        }     // рандомный спавн травки
            //    }
            //}

            //myOmnivore = new Omnivore(4, 4, map);
            //map.allCreatures.Add(myOmnivore);
            //map.omnivores.Add(myOmnivore);

            //myOmnivore = new Omnivore(20, 20, map);
            //map.allCreatures.Add(myOmnivore);
            //map.omnivores.Add(myOmnivore);

            //myOmnivore = new Omnivore(60, 60, map);
            //map.allCreatures.Add(myOmnivore);
            //map.omnivores.Add(myOmnivore);

            //myOmnivore = new Omnivore(50, 20, map);
            //map.allCreatures.Add(myOmnivore);
            //map.omnivores.Add(myOmnivore);

            ////myPredator = new Predator(40, 10, map);
            ////map.allCreatures.Add(myPredator);
            ////map.predators.Add(myPredator);

            //myHerbivore = new Herbivore(20, 20, map);
            //map.allCreatures.Add(myHerbivore);
            //map.herbivores.Add(myHerbivore);

            map.weather = weather;
        }
    
        public void NextGeneration(Map map)
        {
            List<Creature> creatures = new List<Creature>();
            creatures = map.allLiveObjects.OfType<Creature>().ToList();

            for (int i = creatures.Count - 1; i >= 0; i--)
                if (creatures[i].Alive)
                    creatures[i].Live();
                else if (!creatures[i].Alive && !creatures[i].Rotten)
                    creatures[i].Putrefaction();
                else
                {
                    map.rottenAndEatenAllCreatures.Add(creatures[i]);
                }
           
                map.RemoveAllAnimal();
        }
    }
}

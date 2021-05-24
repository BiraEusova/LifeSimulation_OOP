using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;

// Метод рождение частично вынести в класс выше, оставить строчки с создание новго экземпляра
// писать вар там где надо
// Грамотно разместить определение вида


namespace lifeSimulation
{
    abstract public class Creatures<TFood> : Creature
        where TFood : FoodForCreatures
    {
        public Creatures(int x, int y, Map map) : base(x, y, map)
        {
            gender = map.random.Next(21);       //Определение пола
            if (gender == 0)                    //Фригидов должно быть мало, т.к. это аномалия
            {
                gender = (int)Gender.Frigid;
                GenderForDislpay = "Frigid";
            }
            else if (gender < 11)
            {
                gender = (int)Gender.Passive;
                GenderForDislpay = "Passive";
            }
            else if (gender < 21)
            {
                gender = (int)Gender.Active;
                GenderForDislpay = "Active";
            }

            int birth = map.random.Next(2);   // Изначально некоторые особи не могут размножаться для баланса
            if (birth == 0)
            {
                AbilityToBirth = false;
                CurFromBirth = 100;
            }
            else
            {
                AbilityToBirth = true;
            }

            degreeOfSatiety = 200;
            alive = true;
            Rotten = false;
            Eaten = false;
            poisoned = (int)Poisoning.NotPoisoned;
            SearchingRoute = map.random.Next(4);
            TypePoisoning = "Not poisoned";
            this.x = x;
            this.y = y;
            setKindAndName();
            ChangeColor();
        }

        public abstract void setKindAndName();

        protected void InSearching()
        {
            if (map.JamCheck(x, y, SearchingRoute)) SearchingRoute = map.random.Next(4);
            else
            {
                switch (SearchingRoute)
                {
                    case (int)Route.Up:
                        if (x > 0) x--;
                        break;
                    case (int)Route.Down:
                        if (x < map.Size - 1) x++;
                        break;
                    case (int)Route.Left:
                        if (y > 0) y--;
                        break;
                    case (int)Route.Right:
                        if (y < map.Size - 1) y++;
                        break;
                }
            }

            DecreasedSatiety(poisoned);
            ChangeColor();
        }

        private void SearchTarget( string targetOfSearching)
        {

            if (targetOfSearching == "partner")
            {
                IEnumerable<Creature> targetList = map.allLiveObjects.OfType<Creature>()
                    .Where(creature => 
                            Math.Abs(creature.GengerOfCreatures - gender) == 2 &&
                            creature.DegreeOdSatiety > (int)State.Perfect &&
                            AbilityToBirth &&
                            this.GetType() == creature.GetType());

                if (targetList.Count() > 0)
                {
                    Creature nearest = targetList.MinBy(c => Math.Abs(x - c.x) + Math.Abs(y - c.y)).First();
                    MoveToTarget(nearest);
                }
            }
            else if (targetOfSearching == "food")
            {
                IEnumerable<LiveGameObject> targetList = map.allLiveObjects.OfType<LiveGameObject>()
                    .Where(creature => creature is TFood);

                if (targetList.Count() > 0)
                {
                    LiveGameObject nearest = targetList.MinBy(c => Math.Abs(x - c.x) + Math.Abs(y - c.y)).First();
                    MoveToTarget(nearest);
                }
            }

        }
        private void MoveToTarget(LiveGameObject target)
        {

            if (Math.Abs(x - target.x) > Math.Abs(y - target.y))
                if (x < target.x)
                    ++x;
                else
                    --x;
            else
                if (y < target.y)
                ++y;
            else
                --y;

            DecreasedSatiety(poisoned);
            ChangeColor();

            if (x == target.x && y == target.y)
            {
                if (targetOfSearching == "food")
                    Eat(target, map);
                else if (targetOfSearching == "partner")
                    Birth();
            }
                
        }

        public abstract void Birth();
    
        private void Walk(int way) {

            int size = map.Size;
            int oldX = x, oldY = y;

            switch (way)
            {
                case (int)Route.Up:
                    if (y - 1 >= 0)
                        --y;
                    break;
                case (int)Route.Down:
                    if (y + 1 < size)
                        ++y;
                    break;
                case (int)Route.Left:
                    if (x - 1 >= 0)
                        --x;
                    break;
                case (int)Route.Right:
                    if (x + 1 < size)
                        ++x;
                    break;
            }

            DecreasedSatiety(poisoned);
            ChangeColor();

            if (oldX != x || oldY != y) degreeOfSatiety -= 1;
            if (degreeOfSatiety <= 0) alive = false;

        } // бесцельное хождение

        private void Eat(LiveGameObject food, Map map)
        {
            if (food is Plant)
            {
                Plant plantFood = (Plant)food;
                map.RebornPlant(plantFood);

                if (plantFood.Venomous)
                {
                    poisoned = (int)Poisoning.Plant;
                    TypePoisoning = "poisoned by plant";
                    RemoveSatiety((int)Feed.PoisonedPlant);
                }
                else
                {
                    poisoned = (int)Poisoning.NotPoisoned;
                    RemoveSatiety((int)Feed.Plant);
                    TypePoisoning = "not poisoned";
                }
            }
            else
            {
                Creature eatenCreature = food as Creature;
                eatenCreature.Eaten = true;
                eatenCreature.alive = false;
                map.RemoveCreature(food);
                RemoveSatiety((int)Feed.Creature);
            }
            
        }

        private void CheckPoisoning(Creatures<TFood> food)
        {
            if (food.poisoned == (int)Poisoning.Plant)
            {
                poisoned = (int)Poisoning.Сorpse;
                RemoveSatiety((int)Feed.Creature);
                TypePoisoning = "poisoned by creature";
            }
            else if (food.poisoned == (int)Poisoning.Сorpse)
            {
                poisoned = (int)Poisoning.Сorpse;
                RemoveSatiety((int)Feed.Creature);
                TypePoisoning = "poisoned by creature";
            }
            else 
            { 
                poisoned = (int)Poisoning.NotPoisoned;
                RemoveSatiety((int)Feed.Creature);
                TypePoisoning = "not poisoned";
            }
        }

        public override void Putrefaction()
        {
            if (curOfDeathTime > 0) curOfDeathTime--;
            else Rotten = true;
        }  // гниение, после которого сущ-во станет травкой

        public override void Live() 
        {
            RemoveAbilityToBirth();

            if (degreeOfSatiety > (int)State.Perfect) // может размножаться
                if (gender == (int)Gender.Frigid || !AbilityToBirth)
                {
                    targetOfSearching = "nothing";
                    Walk(map.random.Next(6));
                }
                else
                {
                    targetOfSearching = "partner";
                    SearchTarget(targetOfSearching);
                }
            else if (degreeOfSatiety > (int)State.Good)
            {
                targetOfSearching = "nothing";
                Walk(map.random.Next(5));
            }// просто ходит;
            else if (degreeOfSatiety > (int)State.Madness)
            {
                targetOfSearching = "food";
                SearchTarget(targetOfSearching);
            }// ищет еду
                
        }// распределение активностей в зависимости от пола, степени голода и отравления

        private void RemoveSatiety(int factor)
        {
            switch (factor)
            {
                case (int)Feed.Plant:
                    degreeOfSatiety += (int)Feed.Plant;
                    break;
                case (int)Feed.PoisonedPlant:
                    degreeOfSatiety += (int)Feed.PoisonedPlant;
                    break;
                case (int)Feed.Corpse:
                    degreeOfSatiety += (int)Feed.Corpse;
                    break;
                case (int)Feed.Creature:
                    degreeOfSatiety += (int)Feed.Creature;
                    break;
            }


        }
        private void DecreasedSatiety(int factor)
        {
            switch (factor)
            {
                case (int)Poisoning.Plant:
                    degreeOfSatiety -= 2;
                    break;
                case (int)Poisoning.Сorpse:
                    degreeOfSatiety -= 4;
                    break;
                case(int)Poisoning.NotPoisoned:
                    degreeOfSatiety -= 1;
                    break;
            }

            if (degreeOfSatiety <= 0)
            {
                alive = false;
                curOfDeathTime = 80;
            }
            
        }
        
        public void RemoveAbilityToBirth()
        {
            if (CurFromBirth > 0) CurFromBirth--;
            else
                AbilityToBirth = true;
        }

        public abstract void ChangeColor();
    
    }
}


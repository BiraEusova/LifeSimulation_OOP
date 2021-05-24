using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lifeSimulation
{
    public abstract class Plant: LiveGameObject
    {

        private int breedingArea = 30;
        public bool Venomous { get; }
        public Brush Color;

        public Plant(int x, int y, Map map) : base(x, y, map)
        {
            int ven = map.random.Next(20);      // определение типа травки
            if (ven == 0)                       // для баланса ядовитой травки меньше
            {
                Venomous = true;
                setColor(true);
            }
            setColor(false);
        }

        public abstract void setColor(bool venomous); //устанвока цвета в зависимости от ядовитости

        public void Overgrowth(Map map)  // разрастание растений
        {

            var plants = map.allLiveObjects.OfType<Plant>().ToList();
            int randomNum = map.random.Next(plants.Count);
            int plantX = plants[randomNum].x;
            int plantY = plants[randomNum].y;

            Map.Border border = map.CheckBorder(plantX, plantY, breedingArea);

            int newSpawnX = map.random.Next(border.top, border.bot);    //рандомные координаты в кругу разрастания
            int newSpawnY = map.random.Next(border.left, border.right);
            int count = 0;

            x = newSpawnX;
            y = newSpawnY;
        }        

    }
}

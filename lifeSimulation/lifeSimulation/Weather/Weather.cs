using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    public class Weather
    {
        private int type;
        private Color color;
        public Color Color => color;
        private string weatherForDisplay;
        public string WeatherForDisplay => weatherForDisplay;
      
        public Weather(Map map)
        {
            type = map.random.Next(11);   // плохая погода должна выпадать реже, а то грустно будет(
            if (type < 4) type = (int)TypeOfWeather.Bad; 
            else type = (int)TypeOfWeather.Good;
            ChangeParameters(type);
        }

        public void ChangeWeather(Map map)
        {
            type = map.random.Next(11);
            if (type < 5)
            {
                type = (int)TypeOfWeather.Bad;
                if (map.random.Next(3) == 0)
                    type = (int)TypeOfWeather.Blizzard;
            }
            else type = (int)TypeOfWeather.Good;
            ChangeParameters(type);
        }

        public void ChangeParameters(int type)
        {
            switch (type)
            {
                case (int)TypeOfWeather.Good:
                    weatherForDisplay = "Good";
                    color = Color.LightCyan;
                    break;
                case (int)TypeOfWeather.Bad:
                    weatherForDisplay = "Bad";
                    color = Color.Lavender;
                    break;
                case (int)TypeOfWeather.Blizzard:
                    weatherForDisplay = "Blizzard";
                    color = Color.LightSteelBlue;
                    break;
            }
        }
    }
}

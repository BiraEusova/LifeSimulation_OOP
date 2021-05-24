using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    abstract public class LiveGameObject
    {
        public int x;
        public int y;
        public Map map;

        public LiveGameObject (int x, int y, Map map){
            this.x = x;
            this.y = y;
            this.map = map;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace lifeSimulation
{
    public abstract class Creature : LiveGameObject
    {
        protected int degreeOfSatiety;
        public bool alive;
        protected int gender;
        protected int curOfDeathTime;
        public string GenderForDislpay;
        protected int poisoned;
        public string TypePoisoning;
        protected int numOfPartner;
        protected int numOfFood;
        public int SearchingRoute;
        public bool Eaten;
        protected string targetOfSearching;
        public bool Rotten;
        protected bool AbilityToBirth;
        public string NameForDisplay;
        public string KindForDisplay;
        protected int CurFromBirth;
        protected int viewingCircle = 17;
        public Brush color;
        public int DegreeOdSatiety => degreeOfSatiety;
        public bool Alive => alive;
        public int GengerOfCreatures => gender;
        public Brush Color => color;
        public Creature(int x, int y, Map map) : base(x, y, map)
        {

        }

        public abstract void Live();
        public abstract void Putrefaction();

    }
}

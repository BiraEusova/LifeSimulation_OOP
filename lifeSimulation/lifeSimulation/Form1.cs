using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lifeSimulation
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        private int resolution;
        private LifeEngine lifeEngine;
        private Map map;
        Creature creatureForDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void startLife()
        {
            if (timer1.Enabled)
                return;

            nudDensity.Enabled = false;

            resolution = (int)nudResolution.Value;
            map = new Map();

            pictureBox1.Height = map.Size * resolution;
            pictureBox1.Width = pictureBox1.Height;

            lifeEngine = new LifeEngine
                (
                    size: map.Size,
                    density: (int)nudDensity.Value/2 * 200 + 300,
                    map: map
                );

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(map.weather.Color);

            if (map.weather.WeatherForDisplay == "Bad")
                timer1.Interval = 80;

            timer1.Start();
            timer2.Start();
        }
        private void stopLife()
        {
            if (!timer1.Enabled)
                return;

            timer1.Stop();
            timer2.Stop();
            nudDensity.Enabled = true;
            nudResolution.Enabled = true;
        }

        private void DrawNextGenerationOfPlants()
        {
            graphics.Clear(map.weather.Color);

            IEnumerable<Plant> plants = map.allLiveObjects.OfType<Plant>();

            foreach (Plant plant in plants)
            {
                    graphics.FillEllipse
                    (
                        plant.Color,
                        plant.x * resolution,
                        plant.y * resolution,
                        resolution,
                        resolution
                    );
            }
        }
        private void DrawNextGenerationOfCreatures()
        {

            IEnumerable<Creature> creatures  = map.allLiveObjects.OfType<Creature>();
            
            int degreeOfSatiety;
            int x, y;

            foreach(Creature creature in creatures)
            {
                degreeOfSatiety = creature.DegreeOdSatiety;
                x = creature.x;
                y = creature.y;

                if (creature == creatureForDisplay)
                {
                    Display();
                    graphics.FillRectangle
                    (
                        Brushes.Red,
                        x * resolution,
                        y * resolution,
                        resolution,
                        resolution
                    );
                }
                else   
                    graphics.FillRectangle
                    (
                        creature.Color,
                        x * resolution,
                        y * resolution,
                        resolution,
                        resolution
                    );

               
            }

            pictureBox1.Refresh();
            lifeEngine.NextGeneration(map);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGenerationOfPlants();
            DrawNextGenerationOfCreatures();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            startLife();
        }
        private void bStop_Click(object sender, EventArgs e)
        {
            stopLife();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void nupNenujno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            IEnumerable<Creature> creatures = new List<Creature>();
            creatures = map.allLiveObjects.OfType<Creature>();

            if (!timer1.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                int x = e.Location.X / resolution;
                int y = e.Location.Y / resolution;

                Creature myCreature = null;

                foreach (Creature creature in creatures)
                {
                    if (x == creature.x && y == creature.y)
                    {
                        myCreature = creature;
                        creatureForDisplay = myCreature;
                        
                        break;
                    }
                }
                
                if (creatureForDisplay != null)
                    Display();
            }
        }

        private void Display()
        {
            if (creatureForDisplay != null)
            {
                Kind.Text = $"Kind : {creatureForDisplay.KindForDisplay}";
                NameOfCreature.Text = $"Name : {creatureForDisplay.NameForDisplay}";
                Health.Text = $"Health : {creatureForDisplay.DegreeOdSatiety}";
                Gender.Text = $"Gender: {creatureForDisplay.GenderForDislpay}";
                Coordinates.Text = $"Coordinates : ({creatureForDisplay.x}, {creatureForDisplay.y})";
                Poisoning.Text = $"Poisoning : {creatureForDisplay.TypePoisoning}";
            }
            else
            {
                Kind.Text = $"Kind";
                NameOfCreature.Text = $"Name";
                Health.Text = $"Health";
                Gender.Text = $"Gender";
                Coordinates.Text = $"Coordinates";
                Poisoning.Text = $"Poisoning";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            resolution = (int)nudResolution.Value;

            pictureBox1.Height = map.Size * resolution;
            pictureBox1.Width = pictureBox1.Height;

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(map.weather.Color);

            DrawNextGenerationOfPlants();
            DrawNextGenerationOfCreatures();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            map.weather.ChangeWeather(map);
            if (map.weather.WeatherForDisplay == "Bad" || map.weather.WeatherForDisplay == "Blizzard")
            {
                timer1.Interval = 300;
                timer2.Interval = 3000;
            }
            else
            {
                timer1.Interval = 80;
                timer2.Interval = 7000;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

        

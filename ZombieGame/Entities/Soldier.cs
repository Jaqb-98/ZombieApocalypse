using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieGame
{
    public class Soldier : PictureBox, IEntity
    {
        public decimal Money { get; set; }
        public int Resistance { get; set; }

        private Random random = new Random();

        public Soldier(int x, int y, decimal money)
        {
            Location = new Point(x, y);
            Money = money;
            Height = 10;
            Width = 10;
            Image = ZombieGame.Properties.Resources.Soldier;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Resistance = GameForm.random.Next(50, 100);

        }

        public string Info()
        {
            return $"Soldier\n" +
                $"Resistance: {Resistance}";
        }


        public IEntity MeetsZombie(Zombie zombie)
        {
            if (Resistance > zombie.Strength)
            {
                return new Human(zombie.Location.X, zombie.Location.Y, zombie.Money);
            }
            else
            {
                return new Zombie(Location.X, Location.Y, Money);
            }
        }

        public IEntity MeetsSoldier(Soldier soldier)
        {
            return null;
        }

        public IEntity MeetsHuman(Human human)
        {
            if (human.Money >= 100)
            {
                human.Money -= 100;
            }
            else
            {
                return new Soldier(human.Location.X, human.Location.Y, human.Money);
            }
            return null;
        }
    }
}

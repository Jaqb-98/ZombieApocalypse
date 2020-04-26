using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieGame
{
    public class Human : PictureBox, IEntity
    {
        public decimal Money { get; set; }

        public Human(int x, int y, decimal money)
        {

            Location = new Point(x, y);
            Money = money;
            Height = 10;
            Width = 10;
            Image = ZombieGame.Properties.Resources.Human;
            SizeMode = PictureBoxSizeMode.StretchImage;

        }

        public virtual string Info()
        {
            return $"Human\n" +
                $"Money: {Money}";
        }


        public IEntity MeetsZombie(Zombie zombie)
        {
            var newZombie = new Zombie(Location.X, Location.Y, Money);
            return newZombie;
        }

        public IEntity MeetsSoldier(Soldier soldier)
        {
            if (Money >= 100)
            {
                Money -= 100;
            }
            else
            {
                return new Soldier(Location.X, Location.Y, Money);
            }
            return null;
        }

        public IEntity MeetsHuman(Human human)
        {
            return null;
        }
    }
}

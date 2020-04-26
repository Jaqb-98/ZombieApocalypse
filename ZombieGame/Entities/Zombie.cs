using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieGame
{
    public class Zombie : PictureBox, IEntity
    {
        public decimal Money { get; set; }
        public int RoundsAsZombie { get; set; }
        public int Strength { get; set; }


        public Zombie(int x, int y, decimal money)
        {
            RoundsAsZombie = GameForm.random.Next(10, 25);
            Location = new Point(x, y);
            Money = money;
            Height = 10;
            Width = 10;
            Strength = GameForm.random.Next(50, 100);
            Image = ZombieGame.Properties.Resources.Zombie;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public string Info()
        {
            return $"Zombie\n" +
                $"Rounds as zombie: {RoundsAsZombie}\n" +
                $"Strength: {Strength}";
        }

        public IEntity MeetsZombie(Zombie zombie)
        {
            return null;
        }

        public IEntity MeetsSoldier(Soldier soldier)
        {
            if (Strength > soldier.Resistance)
            {
                return new Zombie(soldier.Location.X, soldier.Location.Y, soldier.Money);
            }
            else
            {
                return new Human(Location.X, Location.Y, Money);
            }
        }

        public IEntity MeetsHuman(Human human)
        {
            return new Zombie(human.Location.X, human.Location.Y, human.Money);
        }
    }
}

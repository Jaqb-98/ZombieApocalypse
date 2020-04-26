using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieGame
{
    public interface IEntity: IDisposable
    {
        Point Location { get; set; }
        decimal Money { get; set; }
        Rectangle Bounds { get; set; }
        Control Parent { get; set; }
        IEntity MeetsZombie(Zombie zombie);
        IEntity MeetsSoldier(Soldier soldier);
        IEntity MeetsHuman(Human human);
        string Info();


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ZombieGame
{
    public partial class GameForm : Form
    {
        public List<IEntity> Entities { get; set; }

        public int Turn { get; set; }

        public static Random random = new Random();
        public GameForm()
        {
            InitializeComponent();
            Turn = 1;
            Entities = new List<IEntity>();

        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_NumberOfHumans.Text, out int numberOfHumans)) { } else numberOfHumans = 0;
            if (int.TryParse(txt_NumberOfZombies.Text, out int numberOfZombies)) { } else numberOfZombies = 0;
            if (int.TryParse(txt_NumberOfSoldiers.Text, out int numberOfSoldiers)) { } else numberOfSoldiers = 0;

            for (int i = 0; i < numberOfHumans; i++)
            {
                int x = random.Next(0, GamePanel.Width - 20);
                int y = random.Next(0, GamePanel.Height - 20);
                int money = random.Next(0, 1000);
                var newHuman = new Human(x, y, money) { Parent = GamePanel };
                Entities.Add(newHuman);

            }

            for (int i = 0; i < numberOfZombies; i++)
            {
                int x = random.Next(0, GamePanel.Width - 20);
                int y = random.Next(0, GamePanel.Height - 20);
                int money = random.Next(100, 1000);
                var newZombie = new Zombie(x, y, money) { Parent = GamePanel };
                Entities.Add(newZombie);
            }

            for (int i = 0; i < numberOfSoldiers; i++)
            {
                int x = random.Next(0, GamePanel.Width - 20);
                int y = random.Next(0, GamePanel.Height - 20);
                int money = random.Next(100, 1000);
                var newSoldier = new Soldier(x, y, money) { Parent = GamePanel };
                Entities.Add(newSoldier);
            }

            btn_StartGame.Enabled = false;
            txt_NumberOfHumans.Enabled = false;
            txt_NumberOfSoldiers.Enabled = false;
            txt_NumberOfZombies.Enabled = false;
            btn_NewGame.Enabled = true;
            btn_NextTurn.Enabled = true;


            lbl_Turns.Text = $"Turn: {Turn}";
            SetTooltip();
            CheckIntersections();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            GamePanel.Controls.Clear();
            txt_NumberOfHumans.Clear();
            txt_NumberOfSoldiers.Clear();
            txt_NumberOfZombies.Clear();

            btn_StartGame.Enabled = true;
            txt_NumberOfHumans.Enabled = true;
            txt_NumberOfSoldiers.Enabled = true;
            txt_NumberOfZombies.Enabled = true;
            btn_NewGame.Enabled = false;
            btn_NextTurn.Enabled = false;
            Entities.Clear();
            Turn = 1;
            lbl_Turns.Text = $"Round: {Turn}";
        }

        private void btn_NextRound_Click(object sender, EventArgs e)
        {
            MoveEntities();
            SetTooltip();
            CheckIntersections();
            UpdateEntities();
            Turn++;
            lbl_Turns.Text = $"Round: {Turn}";

        }


        private void CheckIntersections()
        {
            var intersecting = new List<Tuple<IEntity, IEntity>>();

            for (int i = 0; i != Entities.Count; ++i)
            {
                for (int j = i + 1; j != Entities.Count; ++j)
                {
                    if (Entities[i].Bounds.IntersectsWith(Entities[j].Bounds))
                        intersecting.Add(Tuple.Create(Entities[i], Entities[j]));
                }
            }

            foreach (var pair in intersecting)
            {
                Meeting(pair.Item1, pair.Item2);
            }
        }



        private void SetTooltip()
        {
            foreach (var entity in Entities)
            {
                tooltip.SetToolTip((Control)entity, entity.Info());
            }
        }

        private void Meeting(IEntity e1, IEntity e2)
        {
            IEntity newEntity = null;
            switch (e2)
            {
                case Human h:
                    newEntity = e1.MeetsHuman((Human)e2);
                    if (newEntity != null)
                    {
                        ReplaceEntity(newEntity);
                    }
                    break;
                case Zombie z:
                    newEntity = e1.MeetsZombie((Zombie)e2);
                    if (newEntity != null)
                    {
                        ReplaceEntity(newEntity);
                    }
                    break;
                case Soldier s:
                    newEntity = e1.MeetsSoldier((Soldier)e2);
                    if (newEntity != null)
                    {
                        ReplaceEntity(newEntity);
                    }
                    break;
            }
        }

        private void ReplaceEntity(IEntity x)
        {
            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i].Location == x.Location)
                {
                    Entities[i].Dispose();
                    x.Parent = GamePanel;
                    Entities[i] = x;
                }
            }
        }

        private void MoveEntities()
        {
            foreach (var entity in Entities)
            {
                if (entity.Money > 0)
                {
                    bool canMove = true;
                    int newX = 0;
                    int newY = 0;
                    while (canMove)
                    {
                        int currentX = entity.Location.X;
                        int currentY = entity.Location.Y;

                        newX = currentX + random.Next(-10, 10);
                        newY = currentY + random.Next(-10, 10);

                        if (newX < GamePanel.Width - 10 && newX > 0 && newY < GamePanel.Height - 10 && newY > 0)
                            canMove = false;
                    }

                    entity.Location = new Point(newX, newY);


                    if (entity is Zombie z)
                    {
                        z.RoundsAsZombie--;
                    }
                }


            }

        }

        private void UpdateEntities()
        {
            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i] is Zombie z)
                {
                    if (z.RoundsAsZombie == 0)
                    {
                        var location = z.Location;
                        Entities[i].Dispose();
                        Entities[i] = new Human(location.X, location.Y, z.Money) { Parent = GamePanel };
                    }
                }
            }
        }



    }
}

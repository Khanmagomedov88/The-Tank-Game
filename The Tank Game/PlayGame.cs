using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace The_Tank_Game
{
    public partial class PlayGame : Form
    {
        Tank tank1 = new Tank();
        Rocket[] rocket = {
            new Rocket (),
            new Rocket (),
            new Rocket ()
        };


        public PlayGame()
        {
            InitializeComponent();
            Controls.Add(tank1.CreateTank(Properties.Resources.TankUpGreen, 420, 465));
            Controls.Add(rocket[0].CreateOpponent(Properties.Resources.Rocket));
            Controls.Add(rocket[1].CreateOpponent(Properties.Resources.Rocket));
            Controls.Add(rocket[2].CreateOpponent(Properties.Resources.Rocket));



            this.KeyDown += new KeyEventHandler(tank1.Movement);

            init();
        }

        int score = 0;
        public void init()
        {


            timer1.Interval = 60;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randX;
            score++;
            label1.Text = Convert.ToString($"Score: {score}");

            randX = rand.Next(0, 900);
            rocket[0].StartMovement(2, randX);

            randX = rand.Next(0, 900);
            if (score > 200)
                rocket[1].StartMovement(20, randX);

            randX = rand.Next(0, 900);
            if (score > 400)
                rocket[2].StartMovement(10, randX);

            if (rocket[0].Crash(tank1.LocationX, tank1.LocationY, rocket[0].LocationX, rocket[0].LocationY) ||
                rocket[1].Crash(tank1.LocationX, tank1.LocationY, rocket[1].LocationX, rocket[1].LocationY) ||
                rocket[2].Crash(tank1.LocationX, tank1.LocationY, rocket[2].LocationX, rocket[2].LocationY))
            {
                FinishGame();
            }
        }

        private void button_Replay_Click(object sender, EventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinishGame()
        {
            button_Exit.Visible = true;
            button_Replay.Visible = true;
            BackColor = Color.Gray;
            timer1.Stop();
            Thread.Sleep(50);
            MessageBox.Show($"Танк взорван! \nВаш счет: {score}", "Tank Game");
        }
    }

    public class Tank
    {
        PictureBox pictureTank = new PictureBox();
        public int LocationX { get; private set; } = 0;

        public int LocationY { get; private set; } = 0;
        public Tank()
        {

        }

        public PictureBox CreateTank(Image imageTank, int x, int y)
        {
            LocationX = x; LocationY = y;
            pictureTank.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTank.Location = new Point(x, y);
            pictureTank.Size = new Size(39, 80);
            pictureTank.Image = imageTank;

            return pictureTank;
        }

        private void GoLeft()
        {
            if (LocationX > 0)
                LocationX -= 10;
            pictureTank.Location = new Point(LocationX, LocationY);
        }
        private void GoRight()
        {
            if (LocationX < 890)
                LocationX += 10;
            pictureTank.Location = new Point(LocationX, LocationY);
        }
        private void GoUp()
        {
            if (LocationY > 0)
                LocationY -= 10;
            pictureTank.Location = new Point(LocationX, LocationY);
        }
        private void GoDown()
        {
            if (LocationY < 460)
                LocationY += 10;
            pictureTank.Location = new Point(LocationX, LocationY);
        }

        public void Movement(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":
                    GoUp();
                    break;
                case "A":
                    GoLeft();
                    break;
                case "S":
                    GoDown();
                    break;
                case "D":
                    GoRight();
                    break;
            }
        }
    }

    interface OpponentFinction
    {
        PictureBox CreateOpponent(Image imageOpponent); 
        bool Crash(int TankX, int TankY, int OpponentX, int OpponentY);
    }
    abstract class Opponent
    {
        public abstract PictureBox CreateOpponent(Image imageOpponent);
        public abstract void StartMovement(int speedDrop, int Lx);
        public abstract bool Crash(int TankX, int TankY, int OpponentX, int OpponentY);
    }

    class Rocket : Opponent, OpponentFinction
    {
        PictureBox pictureBomb = new PictureBox();
        Random rand = new Random();

        public int LocationX { get; private set; } = 0;
        public int LocationY { get; private set; } = 560; // Присвоено 560, чтобы в методе StartMovement сразу сработал if


        public override PictureBox CreateOpponent(Image imageOpponent)
        {

            pictureBomb.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBomb.Location = new Point(LocationX, LocationY);
            pictureBomb.Size = new Size(29, 50);
            pictureBomb.Image = imageOpponent;

            return pictureBomb;
        }

        public override void StartMovement(int speedDrop, int Lx)
        {

            pictureBomb.Location = new Point(LocationX, LocationY += speedDrop);

            if (LocationY > 550)
            {
                int x = rand.Next(0, 900);

                LocationY = -40;
                LocationX = Lx;
            }
        }
        public override bool Crash(int TankX, int TankY, int OpponentX, int OpponentY)
        {
            int TouchX;
            TouchX = TankX - OpponentX;

            if (Math.Abs(TankX - OpponentX) < 25 && TankY - OpponentY > 0 && TankY - OpponentY < 40)
            {
                if (TouchX < 0)
                    return true;
                else if (Math.Abs(TankX - OpponentX) < 15)
                    //MessageBox.Show("Танк взорван!\n" + "Ваш счет: " + Score, "Tank Game");
                    return true;
                else { return false; }
            }
            else
                return false;
        }
    }

}

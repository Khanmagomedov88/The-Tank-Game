using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using The_Tank_Game;

namespace Гонки
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {


            InitializeComponent();

            string path = @"..\..\InfoRec.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("0\n0\n0\n0\n0");
                }
            }

            Ariazs.Parent = pictureBox1;
            Button_Start.FlatAppearance.BorderSize = 0;
            Button_Start.FlatStyle = FlatStyle.Flat;

            Button_KnowledgeBase.FlatAppearance.BorderSize = 0;
            Button_KnowledgeBase.FlatStyle = FlatStyle.Flat;


            Button_Develop.FlatAppearance.BorderSize = 0;
            Button_Develop.FlatStyle = FlatStyle.Flat;

            Button_Record.FlatAppearance.BorderSize = 0;
            Button_Record.FlatStyle = FlatStyle.Flat;

            Button_Exit.FlatAppearance.BorderSize = 0;
            Button_Exit.FlatStyle = FlatStyle.Flat;
        }

        private void Button_StartGame_Click(object sender, EventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Вы уверены что хотите выйти из игры?", "Выход из игры", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Button_Develop_Click(object sender, EventArgs e)
        {
            Develop develop = new Develop();
            develop.Show();
        }


        private void Button_KnowledgeBase_Click(object sender, EventArgs e)
        {
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            knowledgeBase.Show();
        }
    }
}

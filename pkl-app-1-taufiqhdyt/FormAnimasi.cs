using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkl_app_1_taufiqhdyt
{
    public partial class FormAnimasi : Form
    {
        private const int BOARD_SIZE = 25;
        private const int SQUARE_SIZE = 20;

        private Bitmap kanvas = null;
        private int actorX = 0;
        private int actorY = 0;

        private int lastX = 0;
        private int lastY = 0;

        private int[] bodyX = new int[300];
        private int[] bodyY = new int[300];

        private string arah = "kanan";

        private int foodX = 21;
        private int foodY = 15;

        private int score = 0;
        private int panjang = 0;

        int life;

        public FormAnimasi()
        {
            InitializeComponent();
            DrawBoard();
            pictureBox1.Invalidate();
        }

        private void DrawBoard()
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                for (int x = 0; x < BOARD_SIZE; x++)
                    for (int y = 0; y < BOARD_SIZE; y++)
                    {
                        var brush = new SolidBrush(Color.DarkGreen);
                        grafik.FillRectangle(brush, y * SQUARE_SIZE, x * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);

                        //var pen = new Pen(Color.PowderBlue);// (Color.PowderBlue);
                        //grafik.DrawRectangle(pen, y * SQUARE_SIZE, x * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);
                    }
            }
        }



        private void DrawActor()
        {
            if (kanvas is null) return;
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brushBody = new SolidBrush(Color.CornflowerBlue);

                bodyX[0] = lastX;
                bodyY[0] = lastY;
                for (var i = panjang; i > 0; i--)
                {
                    if (i == 0) break;

                    bodyX[i] = bodyX[i - 1];
                    bodyY[i] = bodyY[i - 1];
                    grafik.DrawImage(Tubuh.Image, bodyX[i] * SQUARE_SIZE-0, bodyY[i] * SQUARE_SIZE-0, 20, 20);
                }
                //var brushHead = new SolidBrush(Color.DarkRed);
                //grafik.FillRectangle(brushHead, actorX * SQUARE_SIZE, actorY * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);
                //var brushHead = new SolidBrush(Color.DarkRed);
                grafik.DrawImage(Kepala.Image, actorX * SQUARE_SIZE -0, actorY * SQUARE_SIZE -0, 20, 20);
            }
        }

        private void DrawFood()
        {
            if (kanvas is null) return;
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.MediumSeaGreen);
                grafik.DrawImage(food.Image, foodX * SQUARE_SIZE - 0, foodY * SQUARE_SIZE - 0, 20, 20);
            }
        }

      

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (kanvas is null) return;
            e.Graphics.DrawImage(kanvas, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lastX = actorX;
            lastY = actorY;

            switch (arah)
            { 
                
                case "Atas":
                    actorY--;
                    break;
                case "Kiri":
                    actorX--; 
                    break;
                case "Bawah":
                    actorY++;
                    break;
                case "Kanan":
                    actorX++;
                    break;
               
               
            }

            if (actorX > BOARD_SIZE - 1)
                actorX = 0;
            if (actorX < 0)
                actorX = BOARD_SIZE - 1;

            if (actorY > BOARD_SIZE - 1)
                actorY = 0;
            if (actorY < 0)
                actorY = BOARD_SIZE - 1;

            label2.Text = $"{arah}: {actorX}, {actorY}";
            label3.Text = $"Score = {score}";
            DrawBoard();

            if (ApakahNabrakBody())
            {
                Life_index();
            }

            if (ApakahActorMakanFood())
            {
                RandomFood();
                score++;
                panjang++;
            }
            DrawActor();
            DrawFood();
            Game_Update();
            arah_snake();

            pictureBox1.Invalidate();
        }

        void Life_index()
        {
            if (life == 1)
            {
                life_1.Image = Properties.Resources.life_white;
            }
            if (life == 2)
            {
                life_2.Image = Properties.Resources.life_white;
            }
            if (life == 3)
            {
                life_3.Image = Properties.Resources.life_white;
                GameOver();
            }
        }

        void arah_snake()
        {

            if (arah == "Atas")
            {
                Kepala.Image = Properties.Resources.Atas;
            }
            if (arah == "Kiri")
            {
                Kepala.Image = Properties.Resources.kiri;
            }
            if (arah == "Bawah")
            {
                Kepala.Image = Properties.Resources.Bawah;
            }
            if (arah == "kanan")
            {
                Kepala.Image = Properties.Resources.kanan;
            }




        }

        void Game_Update()
        {
            if (ApakahNabrakBody())
            {
              
                life += 1;
                Life_index();
            }
        }


        private bool ApakahNabrakBody()
        {
            for (var i = 0; i <= panjang; i++)
            {
                if (bodyX[i] != actorX) continue;
                if (bodyY[i] != actorY) continue;
                return true;
            }
            return false;
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.DarkRed);
                grafik.DrawString("Game Over!", new Font("Latin", 30, FontStyle.Bold), brush, new Point(150, 150));
            }

        }

       

        private bool ApakahActorMakanFood()
        {
            if (actorX == foodX && actorY == foodY)
                return true;
            return false;
        }

        private void RandomFood()
        {
            Random randomX = new Random();
            foodX = randomX.Next(0, BOARD_SIZE);

            Random randomY = new Random();
            foodY = randomY.Next(0, BOARD_SIZE);
            timer2.Stop();
            timer2.Start();
        }

        private void FormAnimasi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    arah = "atas";
                    break;
                case Keys.A:
                    arah = "kiri";
                    break;
                case Keys.S:
                    arah = "bawah";
                    break;      
                case Keys.D:
                    arah = "kanan";
                    break;
            }
        }

        private void FormAnimasi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RandomFood();
            DrawBoard();
            DrawActor();
            DrawFood();
            pictureBox1.Invalidate();
        }  
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormAnimasi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

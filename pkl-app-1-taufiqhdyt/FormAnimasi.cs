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
        private const int UKURANPAPAN = 30;
        private const int UKURANKOTAK = 10;

        private Bitmap kanvas = null;
        private int actorX = 0;
        private int actorY = 0;

        private string arah = "kanan";

        private int foodX = 21;
        private int foodY = 15;

        private int score = 0;

        public FormAnimasi()
        {
            InitializeComponent();
            DrawPapan();
            pictureBox1.Invalidate();
        }
        private void DrawPapan()
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                for (int x = 0; x < UKURANPAPAN; x++)
                    for (int y = 0; y < UKURANPAPAN; y++)
                    {
                        var brush = new SolidBrush(Color.Azure);
                        grafik.FillRectangle(brush, y * UKURANKOTAK, x * UKURANKOTAK, UKURANKOTAK, UKURANKOTAK);

                    }
            }
        }

        private void DrawActor()
        {
            if (kanvas is null) return;
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.Navy);
                grafik.FillRectangle(brush, actorX * UKURANKOTAK, actorY * UKURANKOTAK, UKURANKOTAK, UKURANKOTAK);
            }
        }
        private void DrawFood()
        {
            if (kanvas is null) return;
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.Red);
                grafik.FillEllipse(brush, foodX * UKURANKOTAK, foodX * UKURANKOTAK, UKURANKOTAK, UKURANKOTAK);
            }
        }






        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (kanvas is null) 
                return;
            e.Graphics.DrawImage(kanvas, 20, 20);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (arah)
            {
                case "kiri":
                    actorX--;
                    break;
                case "kanan":
                    actorX++;
                    break;
                case "atas":
                    actorY--;
                    break;
                case "bawah":
                    actorY++;
                    break;
            }

            if (actorX > UKURANPAPAN - 1)
                actorX = 0;
            if (actorX < 0)
                actorX = UKURANPAPAN - 1;

            if (actorY > UKURANPAPAN - 1)
                actorY = 0;
            if (actorY < 0)
                actorY = UKURANPAPAN - 1;

            label1.Text = $"{arah}: {actorX}, {actorY}";
            label2.Text = $"{score}";
            label3.Text = $"Score:";


            DrawPapan();
            DrawActor();

            if (ApakahActorMakanFood())
            {
                RandomFood();
                score++;
            }

            DrawFood();

            pictureBox1.Invalidate();
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
            foodX = randomX.Next(0, UKURANPAPAN);

            Random randomY = new Random();
            foodY = randomY.Next(0, UKURANPAPAN);
            timer2.Stop();
            timer2.Start();
        }


        private void FormAnimasi_KeyDown(object sender, KeyEventArgs e)
        {
            var x = e.KeyCode;
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
            DrawPapan();
            DrawActor();
            DrawFood();
            pictureBox1.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

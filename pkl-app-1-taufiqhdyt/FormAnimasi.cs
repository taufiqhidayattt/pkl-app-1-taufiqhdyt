﻿using System;
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
        private Bitmap kanvas = null;
        private const int JUMLAH_KOTAK = 40;
        private const int UKURAN_KOTAK = 8;

        private int actorX = 0;
        private int actorY = 0;

        private string arah = "kanan";
        public FormAnimasi()
        {
            InitializeComponent();
            DrawKotak();
            DrawAktor();
            DrawMakanan();
        }
        private void DrawKotak()
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                for (var i = 0; i < JUMLAH_KOTAK; i++)
                {
                    for (var j = 0; j < JUMLAH_KOTAK; j++)
                    {
                        var brush = new SolidBrush(Color.Azure);
                        grafik.FillRectangle(brush, i * UKURAN_KOTAK, j * UKURAN_KOTAK, UKURAN_KOTAK, UKURAN_KOTAK);

                        var pen = new Pen(Color.Azure);
                        grafik.DrawRectangle(pen, i * UKURAN_KOTAK, j * UKURAN_KOTAK, UKURAN_KOTAK, UKURAN_KOTAK);
                    }
                }
            }
        }
        private void DrawAktor()
        {
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.DarkTurquoise);
                grafik.FillRectangle(brush, actorX * UKURAN_KOTAK, actorY * UKURAN_KOTAK, UKURAN_KOTAK, UKURAN_KOTAK);
            }
        }

        private void DrawMakanan()
        {
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.DarkTurquoise);
                grafik.FillRectangle(brush, actorX * UKURAN_KOTAK, actorY * UKURAN_KOTAK, UKURAN_KOTAK, UKURAN_KOTAK);
            }

        }
     

     

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (kanvas == null)
                return;

            e.Graphics.DrawImage(kanvas, 10, 10);
        }

    
        

       



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (arah)
            {
                case "kanan":
                    actorX++;
                    break;
                case "kiri":
                    actorX--;
                    break;
                case "atas":
                    actorY--;
                    break;
                case "bawah":
                    actorY++;
                    break;
            }

            if (actorX > JUMLAH_KOTAK - 1)
                actorX = 0;
            if (actorX < 0)
                actorX = JUMLAH_KOTAK;
            if (actorY == JUMLAH_KOTAK)
                actorY = 0;
            if (actorY < 0)
                actorY = JUMLAH_KOTAK;

            DrawKotak();
            DrawAktor();
            pictureBox1.Invalidate();
        }

        private void FormAnimasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                arah = "kanan";
            if (e.KeyCode == Keys.A)
                arah = "kiri";
            if (e.KeyCode == Keys.W)
                arah = "atas";
            if (e.KeyCode == Keys.S)
                arah = "bawah";
        }

        private void FormAnimasi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;

        }
    }
}

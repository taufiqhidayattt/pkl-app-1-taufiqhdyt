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
    public partial class FormArray2Dimensi : Form
    {
        private const int UkuranPapan = 8;
        private const int UkuranKotak = 30;

        private Color terang = Color.FromArgb(240, 200, 217);
        private Color gelap = Color.FromArgb(64, 64, 64);
        private Color[,] kotakCatur = new Color[8, 8];
        private Bitmap kanvas = null;

        public FormArray2Dimensi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setwarnakotak();
            drawpapancatur();
            panelPapanCatur.Invalidate();

        }
        private void setwarnakotak()
        {
            for (int x = 0; x < UkuranPapan; x++)
            {
                for (int y = 0; y < UkuranPapan; y++)
                {
                    Color warna = terang;
                    if (IsGanjil(x) && IsGanjil(y))
                        warna = terang;
                    if (IsGenap(x) && IsGanjil(y))
                        warna = gelap;
                    if (IsGanjil(x) && IsGenap(y))
                        warna = gelap;
                    if (IsGenap(x) && IsGenap(y))
                        warna = terang;


                    kotakCatur[x, y] = warna;


                }
            }

        }
        private void drawpapancatur()
        {
            kanvas = new Bitmap(panelPapanCatur.Width, panelPapanCatur.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                for (int x = 0; x < UkuranPapan; x++)
                {
                    for(int y = 0; y < UkuranPapan; y++)
                    {
                        Brush brush = new SolidBrush(kotakCatur[x, y]);
                        grafik.FillRectangle(brush, y * UkuranKotak, x * UkuranKotak, UkuranKotak, UkuranKotak);
                    }
                }
            }

        }
        private bool IsGanjil(int x)
        {
            if (x % 2 == 0)
                return false;
            else
                return true;
        }

        private bool IsGenap (int y)
        {
            if (y % 2 == 0)
                return true;
            else
                return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (kanvas != null)
                e.Graphics.DrawImage(kanvas, 0, 0);
        }
    }
}

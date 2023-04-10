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
    public partial class FormAlurPercabangan : Form
    {
        private int waktu = 0;
        private int score = 0;
        private int[] kodeWarna = { 0, 1, 2, 3 };
        private string[] namaWarna = { "Merah", "kuning", "Hijau", "Biru" };
        private int kodeWarnaSkrg = 1;

        public FormAlurPercabangan()
        {
            InitializeComponent();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            waktu--;
            label3.Text = waktu.ToString();
            if (waktu <= 0)
            {
                label3.Text = "Game Over";
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

            if (waktu <= 5)
            {
                label4.Text = "Waktu Hampir Habis";

            }

            
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AcakWarna();
            waktu = 30;
            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        private void AcakWarna()
        {
            Random random = new Random();
            int randomValue = random.Next(0, 4);
            label1.Text = namaWarna[randomValue];
            label2.Text = $" Score anda   {score.ToString()}";
            kodeWarnaSkrg = randomValue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (kodeWarnaSkrg == 0)
            {
                score++;
                AcakWarna();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (kodeWarnaSkrg == 1)
            {
                score++;
                AcakWarna();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kodeWarnaSkrg == 2)
                score++;
            AcakWarna();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kodeWarnaSkrg == 3)
                score++;
            AcakWarna();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormAlurPercabangan_Load(object sender, EventArgs e)
        {

        }
    }
}

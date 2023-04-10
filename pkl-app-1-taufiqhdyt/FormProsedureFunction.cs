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
    public partial class FormProsedureFunction : Form
    {
        public FormProsedureFunction()
        {
            InitializeComponent();
        }
        //Prosedure//
        private void button1_Click(object sender, EventArgs e)
        {
            var hasil = "Fiks";
            UcapSelamatPagi(hasil);
        }
        private void UcapSelamatPagi(String nama)

        {
            MessageBox.Show($"Selamat pagi {nama}");

        }
        //Function//
        private void button2_Click(object sender, EventArgs e)
        {
            var umur = pengurangan(2023, 2006);
            MessageBox.Show($"Umur Kamu Adalah {umur.ToString()}");
        }

        private int pengurangan(int tahunsekarang, int tahunlahir)
        {
        var result = tahunsekarang - tahunlahir;
        return result;

}

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Start")
            {
                timer1.Enabled = true; 
                button3.Text = "Stop";
            }
            else
            {
                button3.Text = "Start";
                timer1.Enabled = false;
                var hasil = BisaBerhasil(progressBar.Value);
                TampilHasil(hasil);
            }
        }
        private int counter = -1;

       

        private bool BisaBerhasil(int score)
        {
            if (score == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TampilHasil(bool berhasil)
        {
            if (berhasil)
            {
                Hasil.Text = "WINNN!!!";
                Hasil.ForeColor = Color.Green;
            }
            else
            {
                Hasil.Text = "LOSEE!!";
                Hasil.ForeColor = Color.Red;
               
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar.Value == 20 || progressBar.Value == 0)
                counter = -counter;
            progressBar.Value += counter;
            label1.Text = progressBar.Value.ToString();
        }

        private void FormProsedureFunction_Load(object sender, EventArgs e)
        {

        }
    }
    }


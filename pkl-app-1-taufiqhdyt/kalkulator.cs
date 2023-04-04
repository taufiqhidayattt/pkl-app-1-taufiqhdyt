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
    public partial class kalkulator : Form
    {
        private double angkaTamp = 0;
        private double angkaMem = 0;
        private string op = "";
        public kalkulator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            SimpanTampilan();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            angkaMem = angkaTamp;
            angkaTamp = 0;
            op = "kali";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            SimpanTampilan();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (op == "tambah")
                angkaMem = angkaTamp + angkaMem;

            if (op == "kurang")
                angkaMem = angkaMem - angkaTamp;

            if (op == "kali")
                angkaMem = angkaTamp * angkaMem;

            if (op == "bagi")
                angkaMem = angkaTamp / angkaMem;

            textBox1.Text = angkaMem.ToString("0.##");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            angkaMem = angkaTamp;
            angkaTamp = 0;
            op = "bagi";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            angkaMem = angkaTamp;
            angkaTamp = 0;
            op = "kurang";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            angkaMem = angkaTamp;
            angkaTamp = 0;
            op = "tambah";
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var angka = textBox1.Text;
            var angkaPotong = angka.Substring(0, angka.Length - 1);
            textBox1.Text = angkaPotong;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void SimpanTampilan()
        {
            angkaTamp = Convert.ToDouble(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            SimpanTampilan();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            SimpanTampilan();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            SimpanTampilan();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            SimpanTampilan();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            SimpanTampilan();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            SimpanTampilan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            SimpanTampilan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            SimpanTampilan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            SimpanTampilan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            SimpanTampilan();
        }
    }
}

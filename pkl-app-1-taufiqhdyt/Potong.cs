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
    public partial class Potong : Form
    {
        public Potong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            label2.Text = $"Halo {nama}";
        }

        private void Potong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kata = textBox1.Text;
            var awal = Convert.ToInt16(textBox2.Text);
            var jumlah = Convert.ToInt16(textBox3.Text);
            var hasilPotong = kata.Substring(awal, jumlah);
            label6.Text = $"Hasil potong dari kata {kata} adalah:";
            label7.Text =  $"{hasilPotong}";
        }
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

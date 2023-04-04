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
    public partial class FormAlurSequential : Form
    {
        public FormAlurSequential()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qtyappel = 7;
            var qtymangga = 5;
            var hargaappel = 1500;
            var hargamangga = 1300;
            var ktgplastik = 200;
            var uangbudi = 50000;

            var seluruhapel = qtyappel * hargaappel;
            var seluruhmangga = qtymangga * hargamangga;
            var seluruhbelanjaan = seluruhapel + seluruhmangga;
            var Totalharga = seluruhbelanjaan + ktgplastik;
            var kembalian = uangbudi - Totalharga;




            

            textBox1.Text =$"Harga seluruh belanjaan Budi = {seluruhbelanjaan}" +
                           $"   Total Harga = {Totalharga}" +
                           $"   Uang Budi = {uangbudi}" +
                           $"   Kembalian = {kembalian}";





        }

        private void sequential_Load(object sender, EventArgs e)
        {

        }
    }
}

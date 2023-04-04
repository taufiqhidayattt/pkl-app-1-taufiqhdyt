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
    public partial class FormUmur : Form
    {
        public FormUmur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tanggallahir = dateTimePicker1.Value;
            var tanggalsekarang = DateTime.Now;

            var umursekarang = tanggalsekarang.Date - tanggallahir.Date;
            var umurHari = umursekarang.TotalDays;
            label2.Text = $"Umur anda Sekarang adalah {umurHari:n0} hari";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

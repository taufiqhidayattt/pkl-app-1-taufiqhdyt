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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void latihanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Latihanutama_Load(object sender, EventArgs e)
        {

        }

        private void stringNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormString();
            form.MdiParent = this;
            form.Show();
        
       
        }

        private void numerikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Formnumerik();
        form.MdiParent = this;
            form.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void umurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Umur();
            form.MdiParent = this;
            form.Show();
        }

        private void potongStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Potong();
            form.MdiParent = this;
            form.Show();
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new kalkulator();
            from.MdiParent = this;
            from.Show();
        }

        private void stopwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new stopwatch();
            from.MdiParent = this;
            from.Show();
        }

        private void alurSequentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new sequential();
            from.MdiParent = this;
            from.Show();
        }

        private void percabanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new percabangan();
            from.MdiParent = this;
            from.Show();
        }
    }
}

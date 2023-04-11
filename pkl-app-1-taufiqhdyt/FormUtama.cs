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
            var form = new FormNumerik();
        form.MdiParent = this;
            form.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void umurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUmur();
            form.MdiParent = this;
            form.Show();
        }

        private void potongStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPotong();
            form.MdiParent = this;
            form.Show();
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new FormKalkulator();
            from.MdiParent = this;
            from.Show();
        }

       
        

        private void alurSequentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new FormAlurSequential();
            from.MdiParent = this;
            from.Show();
        }

        private void percabanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new FormAlurPercabangan();
            from.MdiParent = this;
            from.Show();
        }

        private void formProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new FormProsedureFunction();
            from.MdiParent = this;
            from.Show();
        }

        private void formArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new FormArray();
            from.MdiParent = this;
            from.Show();
        }
    }
}

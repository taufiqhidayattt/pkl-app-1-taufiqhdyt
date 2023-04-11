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
    public partial class FormArray : Form
    {
        public FormArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] bilGanjil = new int [10];
            var index = 0;

            for (var bilangan = numericUpDown1.Value; bilangan <= numericUpDown2.Value; bilangan++)

            {
                if (bilangan % 2 == 1)

                {
                    bilGanjil[index] = (int)bilangan;
                    index++;

                    if (index >= 10) 
                    break;
                }
            }
                textBox1.Text = string.Join(",",bilGanjil);
            }
        }
    }


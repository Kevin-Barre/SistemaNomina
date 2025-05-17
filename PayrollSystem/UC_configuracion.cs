using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class UC_configuracion : UserControl
    {
        public UC_configuracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_areas_trabajo aat = new PayrollSystem.Add_areas_trabajo())
            {
                aat.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_bonus ab = new PayrollSystem.Add_bonus())
            {
                ab.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Add_cargo ac = new PayrollSystem.Add_cargo())
            {
                ac.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(Add_usuariocs aa = new PayrollSystem.Add_usuariocs())
            {
                aa.ShowDialog();
            }
        }
    }
}

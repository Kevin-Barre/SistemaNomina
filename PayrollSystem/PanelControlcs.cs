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
    public partial class PanelControlcs : Form
    {
        public PanelControlcs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_Empleados1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uC_configuracion1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_salario1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}

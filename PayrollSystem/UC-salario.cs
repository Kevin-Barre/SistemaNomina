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
    public partial class UC_salario : UserControl
    {
        public UC_salario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rol_pago rol_Pago = new rol_pago();
            Control control = this.Parent; 
            if (control is Form )
            {
                ((Form)control).Controls.Add(rol_Pago);
            } else
            {
                control.Controls.Add(rol_Pago);
            }
            rol_Pago.BringToFront();
        }
    }
}

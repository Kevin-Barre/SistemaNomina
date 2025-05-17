using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace PayrollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelControlcs panelC = new PayrollSystem.PanelControlcs();
            panelC.ShowDialog();



        }
    }
}

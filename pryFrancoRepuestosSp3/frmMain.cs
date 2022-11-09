using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryFrancoRepuestosSp3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int contador = 0;
        string[] vec = new string[100];

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (contador < 2)
            {
                vec[contador] = txtNumero1.Text;

                MessageBox.Show(vec[contador]);

                contador++;

            }
            else
            {
                MessageBox.Show("vector lleno");
            }
                    
                    
        }
    }
}

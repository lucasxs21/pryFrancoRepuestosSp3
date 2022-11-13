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
        

       
        public struct struRepuestos
        {
            public string Marca;
            public string origen;
            public int Numero;
            public float Precio;
            public string Descripcion;
        }
        struRepuestos[] vec = new struRepuestos[100];
        public frmMain()
        {
            InitializeComponent();
        }
        int contador = 0;
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            if (contador < vec.Length)
            {
                vec[contador].Marca = lstMarca1.Text;
                vec[contador].origen = lstOrigen.Text;
                vec[contador].Numero = Convert.ToInt32(txtNumero1.Text);
                vec[contador].Precio = float.Parse(txtPrecio1.Text);
                vec[contador].Descripcion = rtbDescripcion1.Text;             

                contador++;
                Limpiador();


            }                  
                    
        }
        public void Limpiador()
        {
            lstMarca1.SelectedIndex = -1;
            lstOrigen.SelectedIndex = -1;
            txtNumero1.Text = "";
            txtPrecio1.Text = "";
            rtbDescripcion1.Text = "";
            lstMarca1.Focus();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            rtbDescripcion2.Text = "";

            for (int indice = 0; indice < vec.Length; indice++)
            {
                if (vec[indice].Marca == lstMarca1.Text)
                {
                    if (optImportado.Checked)
                    {
                        if (vec[indice].origen == "I")
                        {
                            rtbDescripcion2.Text = rtbDescripcion2.Text + "Numero: " + vec[indice].Numero.ToString() + " " + "Precio: " + vec[indice].Precio.ToString() +" "+ "Descripcion" + " " + vec[indice].Descripcion.ToString() + "\n";

                        }
                    }
                    if (optNacional.Checked)
                    {
                        if (vec[indice].origen == "N")
                        {
                            rtbDescripcion2.Text = rtbDescripcion2.Text + "Numero: " + vec[indice].Numero.ToString() + " " + "Precio: " + vec[indice].Precio.ToString() + " " + "Descripcion" + " " + vec[indice].Descripcion.ToString() + "\n";

                        }
                    }
                }
            }
        }
    }
}

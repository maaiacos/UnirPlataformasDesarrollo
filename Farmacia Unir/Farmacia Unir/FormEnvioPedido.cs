using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Unir
{
    public partial class FormEnvioPedido : Form
    {
        public FormEnvioPedido()
        {
            InitializeComponent();
        }

        //Para cambiar el titulo del formulario se usa el Text
        public void ObtenerDistribuidor(String distribuidor)
        {
            Text = "Pedido al Distribuidor " + distribuidor;
            
        }

        public void ObtenerMedicamento(String medicamento)
        {
            lblMrdicamento.Text = medicamento;
        }

        public void ObtenerDirecciones(String direcciones)
        {
            lblDireccion.Text = direcciones;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Salida formularioSalida = new Salida();
            formularioSalida.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

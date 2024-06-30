using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Farmacia_Unir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int validar = 0;
            validar = ValidarCampos();

            if (validar == 0)
            {
                enviarPedido();
                
            }
        }

        private int ValidarCampos()
        {
            int valor = 0;


            try
            {
                if (string.IsNullOrWhiteSpace(textNombMed.Text))
                {                                      
                    MessageBox.Show("El Nombre del Medicamento es Requerido", "Control de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valor = 1;
                }


                if (cbTipoMedicamento.SelectedIndex == (-1))
                {                    
                    MessageBox.Show("El Tipo del Medicamento es Requerido", "Control de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valor = 1;
                }               

                if (textCantidad.Text.Equals("0"))
                {
                    MessageBox.Show("La Cantidad de medicamentos debe ser Mayor a Cero", "Control de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valor = 1;
                }

                if (textCantidad.Text.Equals(""))
                {
                    MessageBox.Show("La Cantidad de medicamentos No puede estar vacia", "Control de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valor = 1;
                }


                if ( !rbCemefar.Checked)
                {
                    if (!rbCofarma.Checked)
                    {
                      if (!rbEmpsephar.Checked)
                        {
                            MessageBox.Show("El Distribuidor Farmaceutico es Requerido", "Control de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            valor = 1;
                        }
                    }
                }

                if (!cbPrincipal.Checked)
                {
                    if (!cbSecundaria.Checked)
                    {
                        MessageBox.Show("La Sucursal es Requerida", "Control de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        valor = 1;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
            
            return valor;
        }

        //se ejecuta el metodo validarafanumericos de la clase ValidarDatos cuando se presenta el evento keypress sobre el campo nombre de medicamento
        private void textNombMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.ValidarAlfanumericos(e);  
        }

        //se ejecuta el metodo validaranumeros de la clase ValidarDatos cuando se presenta el evento keypress sobre el Cantidad
        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.Validarnumeros(e);
        }

        private void enviarPedido()
        {

            var distribuidor = "";
            var medicamento = "";
            int tipoMed = cbTipoMedicamento.SelectedIndex;
            String varTipoMedicamento = "";            
            String cadena = "";

            String direccion1 = "Calle de la Rosa n. 28";
            String direccion2 = "Calle Alcazabilla n. 3";

            if (rbCemefar.Checked)
            {
                distribuidor = "Cemefar";
            } else  if (rbCofarma.Checked)
            {
                distribuidor = "Cofarma";
            }
            else if (rbEmpsephar.Checked)
            {
                distribuidor = "Empsephar";
            }

            switch (tipoMed)
            {
                case 1:
                    varTipoMedicamento = "analgésico";
                    break;
                case 2:
                    varTipoMedicamento = "analéptico";
                    break;
                case 3:
                    varTipoMedicamento = "anestésico";
                    break;
                case 4:
                    varTipoMedicamento = "antiácido";
                    break;
                case 5:
                    varTipoMedicamento = "antidepresivo";
                    break;
                case 6:
                    varTipoMedicamento = "antibiótico";
                    break;
            }

            if (cbPrincipal.Checked)
            {
                cadena = direccion1;
            }

            if (cbPrincipal.Checked)
            {
                if (cbSecundaria.Checked)
                {
                    cadena = cadena + " y ";
                }
            }

                if (cbSecundaria.Checked)
            {
                cadena = cadena + direccion2;
            }





            medicamento = textCantidad.Text + " Unidades del " + varTipoMedicamento + " " + textNombMed.Text;


            FormEnvioPedido formulario = new FormEnvioPedido();
            formulario.ObtenerDistribuidor(distribuidor);
            formulario.ObtenerMedicamento(medicamento);
            formulario.ObtenerDirecciones(cadena);
            formulario.Show();
        }

        private void borrarDatos()
        {
            textNombMed.Text = "";
            textCantidad.Text = "0";
            cbTipoMedicamento.SelectedIndex = -1;
            cbPrincipal.Checked = false;
            cbSecundaria.Checked = false;
            rbCemefar.Checked = false;           
            rbCofarma.Checked = false;
            rbEmpsephar.Checked = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrarDatos();
        }
    }
}

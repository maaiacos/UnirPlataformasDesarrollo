using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//esta clase se encarga de centralizar las validaciones de ingreso de datos en los campos y validar que los valores se encuentren diligenciados en su totalidad
namespace Farmacia_Unir
{
    internal class ValidarDatos
    {
        //el metodo se encarga de validar que el caracter enviado sea de tipo numérico
        public static void Validarnumeros(KeyPressEventArgs k)
        {
            //si al validar que el caracter es numerico no dispara el evento, isdigt valida numeros, iscontrol para permitir teclas  como borrar
            if (Char.IsDigit(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else
            {
                //cuando el caracter digitao no es numerico se arroja un mensaje de control de datos con un botton ok y un icono de información
                k.Handled = true;
                MessageBox.Show("solo se permiten Números", "Control de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //el metodo se encarga de validar que el caracter enviado sea de tipo alfanumérico
        public static void ValidarAlfanumericos(KeyPressEventArgs k)
        {
            //si al validar que el caracter es alfanumerico no dispara el evento
            if (Char.IsDigit(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsLetter(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else
            {
                //cuando el caracter digitao no es alfanumerico se arroja un mensaje de control de datos con un botton ok y un icono de información
                k.Handled = true;
                MessageBox.Show("solo se permiten caraceteres Alfanumericos","Control de Datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }


    }
}

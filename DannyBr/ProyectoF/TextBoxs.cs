using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoF
{
    class TextBoxs
    {   
        
        //No Controles Vacios
        public static void NoControlesVacios(Form formulario)
        {

            foreach (Control controls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (controls is TextBox)
                {
                    if (String.IsNullOrEmpty(controls.Text))
                        controls.Text = "Hola";
                }
            }//fin si es TextBox

        }
    }
}

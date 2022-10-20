using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaston_Migone_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            int variableEntera = 20;
            double variableDouble = variableEntera;       // Casteo automático

            Imprimir("Se define la siguiente variable: int variableEntera = 20");
            Imprimir(variableEntera +  " es de tipo " + variableEntera.GetType());
            Imprimir("Se realiza un casteo automático: double variableDouble = variableEntera");
            Imprimir(variableDouble +  " es de tipo " + variableDouble.GetType());
             
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double variableDouble = 20.10;
            int variableEntera = (int)variableDouble;    // Casteo manual

            Imprimir("Se define la siguiente variable: double variableDouble = 20.10");
            Imprimir(variableDouble +  " es de tipo " + variableDouble.GetType());
            Imprimir("Se realiza un casteo manual:  int variableEntera = (int)variableDouble  (Al pasar de Double a int, deberá redondear el valor)");
            Imprimir(variableEntera +  " es de tipo " + variableEntera.GetType());      
        }


        private void btnMet_Click(object sender, EventArgs e)
        {
            int variableEntera = 14;
            double variableDouble = 6.66;
            bool variableBooleana = false;

            Imprimir("Se define la siguiente variable: int variableEntera = 14");
            Imprimir("Se utiliza Convert.ToString(variableEntera) para convertirla en String");
            Imprimir(Convert.ToString(variableEntera));    // Convierte entero en String
            Imprimir("Se utiliza Convert.ToDouble(variableEntera) para convertirla en Double");
            Imprimir(Convert.ToDouble(variableEntera));    // Convierte entero en Double
            Imprimir("Se define la siguiente variable: double variableDouble = 6.66;");
            Imprimir("Se utiliza Convert.ToInt32(variableDouble) para convertirla en Entero");
            Imprimir(Convert.ToInt32(variableDouble));  // Convierte Double en int
            Imprimir("Se define la siguiente variable: bool variableBooleana = false");
            Imprimir("Se utiliza Convert.ToString(variableBooleana) para convertirla en String");
            Imprimir(Convert.ToString(variableBooleana));   // Convierte Booleano en String
        }


        public void Imprimir(string texto)
        {
            MessageBox.Show(texto);
        }

        public void Imprimir(double texto)
        {
            MessageBox.Show(texto.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_y_longitud_de_un_circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Circulo()
        {
            //Declaramos las variables
            double area, area2, longitud, radio;
            //Obtenemos el datos ingresado
            radio = Convert.ToDouble(TextBox_Radio.Text);
            //Formula para calcular el área del círculo
            area = Math.Pow(radio, 2);
            area2 = Math.PI * area;
            //Formula para calcular la longitud del círculo
            longitud = 2 * Math.PI * radio;
            //Mostramos los resultados en las label
            Label_Area.Text = area2.ToString() + " cm";
            Label_Longitud.Text = longitud.ToString() + " cm";
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            Circulo();
        }
    }
}
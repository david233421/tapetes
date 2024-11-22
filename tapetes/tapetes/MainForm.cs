/*
 * Created by SharpDevelop.
 * User: CC2-CP03
 * Date: 21/11/2024
 * Time: 02:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncalClick(object sender, EventArgs e)
		{
			string tam;
		    int tamNum, tamResultado;
		    tam = txttam.Text;
		    if (int.TryParse(tam, out tamNum))
		    {
		        tamResultado = tamNum * 100;
		        txt1.Text = tamResultado.ToString();
		    }
		    else
		    {
		        txt1.Text = "Error: Ingrese un número válido.";
		    }

			try
            {

                int cantidad = int.Parse(txtbul.Text);
                int kilos = cantidad * 10;    


                double precioPorKilo = 19.50;
                double presupuesto = kilos * precioPorKilo;


                txt2.Text = presupuesto.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }	
	
			try
            {

                int cantidad = int.Parse(txtlipin.Text); 
                int litros = cantidad * 5;      

                double precioPorLitro = 150.0;
                double presupuesto = litros * precioPorLitro;


                txt3.Text = presupuesto.ToString("F2"); // Formateado con 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  

			try
            {

                int cantidad = int.Parse(txtfru.Text); 


                double precioPorKilo = 120.0;


                double costoTotal = cantidad * precioPorKilo;


                txt4.Text = costoTotal.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   


			try
            {

                int cantidad = int.Parse(txtflo.Text); 

                double precioPorDocena = 200.0;


                double costoTotal = cantidad * precioPorDocena;


                txt5.Text = costoTotal.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   


			  try
            {

                int cantidadPersonas = int.Parse(txtnumper.Text); 


                double pagoPorPersona = 200.0;


                double pagoTotal = cantidadPersonas * pagoPorPersona;


                txt6.Text = pagoTotal.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   


			 try
            {
                // Leer la cantidad ingresada en txtagu
                int cantidadLitros = int.Parse(txtagu.Text); // Cantidad de litros ingresada


                double precioPorLitro = 12.0;


                double costoTotal = cantidadLitros * precioPorLitro;


                txt7.Text = costoTotal.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 


			try
            {

                int cantidadHoras = int.Parse(txttiem.Text); 

                double pagoPorHora = 50.0;


                double costoTotal = cantidadHoras * pagoPorHora;


                txt8.Text = costoTotal.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            try
            {
                // Leer la cantidad ingresada en txtmano
                int cantidadPersonas = int.Parse(txtmano.Text); // Cantidad de personas ingresada

                // Pago por persona
                double pagoPorPersona = 180.0;

                // Calcular el costo total
                double costoTotal = cantidadPersonas * pagoPorPersona;

                // Mostrar el resultado en txt9
                txt9.Text = costoTotal.ToString("F2"); // Formato con 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
		}
		void BtncalfinClick(object sender, EventArgs e)
		{
			try
            {
                // Leer los valores de los campos
                double valor1 = double.Parse(txt1.Text);
                double valor2 = double.Parse(txt2.Text);
                double valor3 = double.Parse(txt3.Text);
                double valor4 = double.Parse(txt4.Text);
                double valor5 = double.Parse(txt5.Text);
                double valor6 = double.Parse(txt6.Text);
                double valor7 = double.Parse(txt7.Text);
                double valor8 = double.Parse(txt8.Text);
                double valor9 = double.Parse(txt9.Text);

                // Sumar todos los valores
                double sumaTotal = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8 + valor9;

                // Mostrar el resultado en txtfi
                txtfi.Text = sumaTotal.ToString("F2"); // Formato con 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos tengan valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}

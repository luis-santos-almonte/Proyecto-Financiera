using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_Financiera
{
    public partial class Prestamos2 : MetroFramework.Forms.MetroForm
    {
       
        public int plazowe;
        public int cobroplasito;
        bool edit = true;
        public Prestamos2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_RT_FinancieraDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
            //   this.prestamosTableAdapter1.Fill(this._RT_FinancieraDataSet.Prestamos);
            // TODO: esta línea de código carga datos en la tabla '_RT_FinancieraDataSet1.TCuotas' Puede moverla o quitarla según sea necesario.
            //  this.tCuotasTableAdapter1.Fill(this._RT_FinancieraDataSet1.TCuotas);
            // TODO: esta línea de código carga datos en la tabla '_RT_FinancieraDataSet.TCuotas' Puede moverla o quitarla según sea necesario.
            //  this.tCuotasTableAdapter.Fill(this._RT_FinancieraDataSet.TCuotas);
            // TODO: esta línea de código carga datos en la tabla '_RT_FinancieraDataSet1.Prestamos' Puede moverla o quitarla según sea necesario.
            //  this.prestamosTableAdapter.Fill(this._RT_FinancieraDataSet1.Prestamos);


          

            DateTime Fecha = DateTime.Today.AddDays(0);
            fecha_PedidoDateTimePicker.Text = Fecha.ToString();

          

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
         

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            plazowe = Convert.ToInt32(cobro_PlazoTextBox.Text);

            int pago = Convert.ToInt32(textBox3.Text);
            int sobrante = 0;
            int variablenumerodecuota = Convert.ToInt32(textBox1.Text);


            if (variablenumerodecuota == 0)
            {
                MessageBox.Show("No hay cuotas pendientes");



            }
            else
            {

                while (pago != 0)
                {

                    if (pago >= plazowe && Convert.ToInt32(textBox1.Text) > 1)

                    {

                        sobrante = pago - plazowe;
                        pago = sobrante;

                        variablenumerodecuota--;
                        textBox1.Text = Convert.ToString(variablenumerodecuota);
                        cobro_PlazoTextBox.Text = Convert.ToString(cobroplasito - sobrante);

                        break;
                    }


                    if (pago > Convert.ToInt32(cobro_PlazoTextBox.Text) && Convert.ToInt32(textBox1.Text) == 1)
                    {

                        MessageBox.Show("excede la cantidad que debe");
                        pago = 0;
                        break;
                    }
                    if (pago < plazowe)
                    {

                        sobrante = Convert.ToInt32(cobro_PlazoTextBox.Text) - pago;

                        //cobro_PlazoTextBox.Text = Convert.ToString(plazowe);
                        cobro_PlazoTextBox.Text = Convert.ToString(sobrante);
                        pago = 0;


                        if (Convert.ToInt32(textBox1.Text) == 1)
                        {
                            cobro_PlazoTextBox.Text = Convert.ToString(sobrante);
                            break;
                        }

                        if (variablenumerodecuota == 0)
                        {
                            cobro_PlazoTextBox.Text = Convert.ToString(0);
                            MessageBox.Show("no tiene mas pago");
                        }
                    }
                    else if (Convert.ToInt32(textBox1.Text) == 1 && pago == Convert.ToInt32(cobro_PlazoTextBox.Text))
                    {
                        cobro_PlazoTextBox.Text = Convert.ToString(0);
                        textBox1.Text = Convert.ToString(0);
                        pago = 0;



                    }
                }

            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(iD_PrestamoTextBox.Text)) || (string.IsNullOrWhiteSpace(iD_EmpleadoTextBox.Text)) || (string.IsNullOrWhiteSpace(iD_ClienteTextBox.Text)) || (string.IsNullOrWhiteSpace(montoTextBox.Text)) || (string.IsNullOrWhiteSpace(textBox1.Text)) || (string.IsNullOrWhiteSpace(taza_InteresTextBox1.Text))  )
            {
                MessageBox.Show("Debe llenar los datos faltantes");
                return;
            }
            int variabledenumerodecuota = Convert.ToInt32(textBox1.Text);
            int variapordos = variabledenumerodecuota * 2;
            int tazatext = Convert.ToInt32(taza_InteresTextBox1.Text);
            int montotext = Convert.ToInt32(montoTextBox.Text);
            int montotext2 = montotext;

            int rawr4 = 0;
            int rawr3 = 12;

            cobro_PlazoTextBox.Text = Convert.ToString(montotext / variabledenumerodecuota);
            cobroplasito = montotext / variabledenumerodecuota;
            textBox2.Text = Convert.ToString(montotext / 100 * tazatext);
            int interestotal = Convert.ToInt32(textBox2.Text);
            monto_TotalTextBox1.Text = Convert.ToString(montotext + interestotal);
            do
            {

                if (comboBox1.Text == "Quincenal")
                {
                    DateTime fecha = DateTime.Today.AddDays(15 * variabledenumerodecuota);
                    dateTimePicker1.Text = fecha.ToString();
                }
                else if (comboBox1.Text == "Semanal")
                {
                    DateTime fecha = DateTime.Today.AddDays(7 * variabledenumerodecuota);
                    dateTimePicker1.Text = fecha.ToString();
                }
                else if (comboBox1.Text == "Mensual")
                {
                    DateTime fecha = DateTime.Today.AddMonths(1 * variabledenumerodecuota);
                    dateTimePicker1.Text = fecha.ToString();
                }
                else if (comboBox1.Text == "Anual")
                {
                    DateTime fecha = DateTime.Today.AddYears(1 * variabledenumerodecuota);
                    dateTimePicker1.Text = fecha.ToString(); ;
                }
                rawr4++;
            }
            while (rawr4 <= rawr3);


          

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(iD_PrestamoTextBox.Text)) || (string.IsNullOrWhiteSpace(iD_EmpleadoTextBox.Text)) || (string.IsNullOrWhiteSpace(iD_ClienteTextBox.Text)) || (string.IsNullOrWhiteSpace(montoTextBox.Text)) || (string.IsNullOrWhiteSpace(textBox1.Text)) || (string.IsNullOrWhiteSpace(textBox2.Text)) || (string.IsNullOrWhiteSpace(taza_InteresTextBox1.Text)) || (string.IsNullOrWhiteSpace(cobro_PlazoTextBox.Text)) || (string.IsNullOrWhiteSpace(monto_TotalTextBox1.Text)))
            {
                MessageBox.Show("Debe llenar los datos faltantes");
            }
            else
            {

                OleDbConnection conexion = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =C:\Proyecto Financiera\Proyecto Financiera\Proyecto Financiera\RT-Financiera.mdb");
                OleDbCommand comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                /*comando.CommandText = 
                    "INSERT INTO Prestamos" +
                    "(ID_Prestamo, " +
                    "ID_Cliente, " +
                    "ID_Empleado, " +
                    "Monto, " +
                    "Fecha_Pedido, " +
                    "No_Cuotas, " +
                    "Plazos, " +
                    "Cobro_Plazo, " +
                    "Taza_Interes, " +
                    "Monto_Total) " +
                    "VALUES(55," 
+ iD_ClienteTextBox
+ ","+ iD_EmpleadoTextBox
+ "," + montoTextBox
+ ",'" + dateTimePicker1.Text
+ "'," + textBox1
+ ",'"+ comboBox1
+ "'," + cobro_PlazoTextBox 
+ "," +taza_InteresTextBox1
+ "," +monto_TotalTextBox1 + ");";
*/

                DateTime fecha = DateTime.Today.AddDays(0);
                dateTimePicker1.Text = fecha.ToString();
                
               
                comando.CommandText = "INSERT INTO Prestamos (ID_Prestamo, ID_Cliente, ID_Empleado, Monto, Fecha_Pedido, No_Cuotas, Plazos, Cobro_Plazo, Taza_Interes, Monto_Total) VALUES (" + iD_PrestamoTextBox.Text+","+iD_ClienteTextBox.Text+"," +iD_EmpleadoTextBox.Text+ "," +montoTextBox.Text+ ",'"+ Convert.ToString(fecha) + "',"+ textBox1.Text+",'" +comboBox1.Text+ "'," +cobro_PlazoTextBox.Text +","+ taza_InteresTextBox1.Text+ ","+ monto_TotalTextBox1.Text+")";
                comando.ExecuteNonQuery();
                conexion.Close();
                
                MessageBox.Show("Guardado Exitosamente");
            }
        }

        private void iD_PrestamoTextBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void iD_ClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


}


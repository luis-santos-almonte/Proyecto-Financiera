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
    public partial class FEmpleados : MetroFramework.Forms.MetroForm
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\A19B84262\Documents\C#\Proyecto Financiera\Proyecto Financiera\RT-Financiera.mdb");
        OleDbCommand comando = new OleDbCommand();
        bool edit = true;
        public FEmpleados()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_RT_FinancieraDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this._RT_FinancieraDataSet.Empleado);
            // TODO: esta línea de código carga datos en la tabla '_RT_FinancieraDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this._RT_FinancieraDataSet.Cliente);

        }

        private void iD_EmpleadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(DNI_Emp.Text)) || (string.IsNullOrWhiteSpace(DNI_Emp.Text)) || (string.IsNullOrWhiteSpace(Nom_Emp.Text)) || (string.IsNullOrWhiteSpace(Ape_Emp.Text)) || (string.IsNullOrWhiteSpace(Direc_Emp.Text)) || (string.IsNullOrWhiteSpace(Tel_Emp.Text)) || (string.IsNullOrWhiteSpace(Mov_Emp.Text)) || (string.IsNullOrWhiteSpace(Cor_Emp.Text)) || (string.IsNullOrWhiteSpace(Fecha_Emp.Text)))
            {
                MessageBox.Show("Debe llenar los datos faltantes");
            }
            else
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Empleado (DNI, Nombre, Apellido, Direccion, Telefono, Celular, Correo_Electronico, Fecha_Ingreso) VALUES ('" + DNI_Emp.Text + "','" + Nom_Emp.Text + "' ,'" + Ape_Emp.Text + "','" + Direc_Emp.Text + "','" + Tel_Emp.Text + "','" + Mov_Emp.Text + "','" + Cor_Emp.Text + "','" + Fecha_Emp.Value + "')";
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Guardado Exitosamente");
            }        
        }

        private void iD_EmpleadoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if(edit == true)
            {
                edit = false;
                DNI_Emp.Enabled = true;
                Nom_Emp.Enabled = true;
                Ape_Emp.Enabled = true;
                Direc_Emp.Enabled = true;
                Tel_Emp.Enabled = true;
                Mov_Emp.Enabled = true;
                Cor_Emp.Enabled = true;
                Fecha_Emp.Enabled = true; 
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            DNI_Emp.Text = "";
            Nom_Emp.Text = "";
            Ape_Emp.Text = "";
            Direc_Emp.Text = "";
            Tel_Emp.Text = "";
            Mov_Emp.Text = "";
            Cor_Emp.Text = "";
            if(edit == false)
            {
                edit = true;
                DNI_Emp.Enabled = false;
                Nom_Emp.Enabled = false;
                Ape_Emp.Enabled = false;
                Direc_Emp.Enabled = false;
                Tel_Emp.Enabled = false;
                Mov_Emp.Enabled = false;
                Cor_Emp.Enabled = false;
                Fecha_Emp.Enabled = false;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}

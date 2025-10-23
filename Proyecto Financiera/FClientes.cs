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
    public partial class FClientes : MetroFramework.Forms.MetroForm
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Proyecto Financiera\Proyecto Financiera\Proyecto Financiera\RT-Financiera.mdb");
        OleDbCommand comando = new OleDbCommand();
        //DataTable dt;
        //OleDbDataAdapter oda;

        bool klk = true;
        public FClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = "INSERT INTO Cliente (Nombre, Apellido, Tipo_Identificacion, Identificacion, Dirección, Telefono, Celular, Correo_Electronico, Fecha_Ingreso, Lugar_Trabajo, Puesto_Trabajo, Sueldo, Telefono_Trabajo) VALUES ('" + nombreTextBox.Text + "', '" + apellidoTextBox.Text + "', '" + tipo_IdentificacionTextBox.Text + "', '" + identificacionTextBox.Text + "', '" + direcciónTextBox.Text + "', '" + telefonoTextBox.Text + "', '" + celularTextBox.Text + "', '" + correo_ElectronicoTextBox.Text + "','" + fecha_IngresoDateTimePicker.Value + "', '" + lugar_TrabajoTextBox.Text + "', '" + lugar_TrabajoTextBox.Text + "', '" + decimal.Parse(sueldoTextBox.Text) + "', '" + telefono_TrabajoTextBox.Text + "')";
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro Guardado Correctamente");
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            if (klk == true)
            {
                klk = false;
                nombreTextBox.Enabled = true;
                apellidoTextBox.Enabled = true;
                tipo_IdentificacionTextBox.Enabled = true;
                identificacionTextBox.Enabled = true;
                direcciónTextBox.Enabled = true;
                telefonoTextBox.Enabled = true;
                celularTextBox.Enabled = true;
                correo_ElectronicoTextBox.Enabled = true;
                fecha_IngresoDateTimePicker.Enabled = true;
                lugar_TrabajoTextBox.Enabled = true;
                lugar_TrabajoTextBox.Enabled = true;
                sueldoTextBox.Enabled = true;
                telefono_TrabajoTextBox.Enabled = true;


            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            tipo_IdentificacionTextBox.Text = "";
            identificacionTextBox.Text = "";
            direcciónTextBox.Text = "";
            telefonoTextBox.Text = "";
            celularTextBox.Text = "";
            correo_ElectronicoTextBox.Text = "";
            lugar_TrabajoTextBox.Text = "";
            puesto_TrabajoTextBox.Text = "";
            sueldoTextBox.Text = "";
            telefono_TrabajoTextBox.Text = "";


            if (klk == false)
            {
                klk = true;
                nombreTextBox.Enabled = false;
                apellidoTextBox.Enabled = false;
                tipo_IdentificacionTextBox.Enabled = false;
                identificacionTextBox.Enabled = false;
                direcciónTextBox.Enabled = false;
                telefonoTextBox.Enabled = false;
                celularTextBox.Enabled = false;
                correo_ElectronicoTextBox.Enabled = false;
                fecha_IngresoDateTimePicker.Enabled = false;
                lugar_TrabajoTextBox.Enabled = false;
                lugar_TrabajoTextBox.Enabled = false;
                sueldoTextBox.Enabled = false;
                telefono_TrabajoTextBox.Enabled = false;
            }
        }
    }
}

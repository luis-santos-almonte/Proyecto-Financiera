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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = userwe.Text;
            OleDbConnection rawr = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Proyecto Financiera\Proyecto Financiera\Proyecto Financiera\RT-Financiera.mdb");
            
            rawr.Open();

           
            String Consulta = "select ID,Usuario,Contraseña from Login where  Usuario='" + userwe.Text + "' and Contraseña ='" + contrawe.Text + "';";
        
            OleDbCommand comm = new OleDbCommand(Consulta, rawr);

            OleDbDataReader LectorDatos;

            LectorDatos = comm.ExecuteReader();

            Boolean ExistenciaRegistros = LectorDatos.HasRows;

            if (ExistenciaRegistros)
            {
                MessageBox.Show("Bienvenido al sistema " + userwe.Text, "Usuario autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Proyecto_Financiera.FMenu menu = new Proyecto_Financiera.FMenu(nombre);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Accesso denegado" + userwe.Text, "Usuario No Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rawr.Close();
        }

        private void userwe_TextChanged(object sender, EventArgs e)
        {

            userwe.Focus();
        }
    }
}

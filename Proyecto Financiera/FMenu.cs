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
    public partial class FMenu : MetroFramework.Forms.MetroForm
    {
        public FMenu()
        {
            InitializeComponent();
        }

        public FMenu(String nombre)
        {
            InitializeComponent();
            label5.Text = nombre;
        }


        private void FMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Proyecto_Financiera.FEmpleados Empleados = new Proyecto_Financiera.FEmpleados();
            Empleados.Show();
        }

        private void Btnclientes_Click(object sender, EventArgs e)
        {
            Proyecto_Financiera.FClientes Clientes = new Proyecto_Financiera.FClientes();
            Clientes.Show();
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lblhora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void FMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnprestamos(object sender, EventArgs e)
        {
            Proyecto_Financiera.Prestamos2 Prestamos = new Proyecto_Financiera.Prestamos2();
            Prestamos.Show();
        }
    }
}

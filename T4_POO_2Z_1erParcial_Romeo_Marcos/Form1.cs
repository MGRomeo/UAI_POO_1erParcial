using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using T4_POO_2Z_1erParcial_Romeo_Marcos.Empleados;

namespace T4_POO_2Z_1erParcial_Romeo_Marcos
{
    public partial class Form1 : Form
    {
        Operario operario = new Operario();
        Administrativo administrativo = new Administrativo();
        Directivo directivo = new Directivo();

        List<Operario> Lista_Operario = new List<Operario>();
        List<Administrativo> Lista_Administrativo = new List<Administrativo>();
        List<Directivo> Lista_Directivo = new List<Directivo>();
        List<Empleado> Lista_Empleado = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnCarga_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbOperario.Checked == true)
                {
                    Operario empleado = new Operario();
                    empleado.Apellido = Interaction.InputBox("Ingrese Apellido del Empleado");
                    empleado.Nombre = Interaction.InputBox("Ingrese Nombre del Empleado");
                    empleado.Sueldo = decimal.Parse(Interaction.InputBox("Ingrese Sueldo del Empleado"));
                    empleado.Legajo = ValidaLegajo(Interaction.InputBox("Ingrese Legajo del Empleado"));
                    empleado.SetBeneficio();
                    Lista_Operario.Add(empleado);
                    dgvEmpleado.DataSource = null;
                    dgvEmpleado.DataSource = Lista_Operario;
                }
                else if (rdbAdministrativo.Checked == true)
                {
                    Administrativo empleado = new Administrativo();
                    empleado.Apellido = Interaction.InputBox("Ingrese Apellido del Empleado");
                    empleado.Nombre = Interaction.InputBox("Ingrese Nombre del Empleado");
                    empleado.Sueldo = decimal.Parse(Interaction.InputBox("Ingrese Sueldo del Empleado"));
                    empleado.Legajo = ValidaLegajo(Interaction.InputBox("Ingrese Legajo del Empleado"));
                    empleado.SetBeneficio();
                    Lista_Administrativo.Add(empleado);
                    dgvEmpleado.DataSource = null;
                    dgvEmpleado.DataSource = Lista_Administrativo;

                }
                else if (rdbDirectivo.Checked == true)
                {
                    Directivo empleado = new Directivo();
                    empleado.Apellido = Interaction.InputBox("Ingrese Apellido del Empleado");
                    empleado.Nombre = Interaction.InputBox("Ingrese Nombre del Empleado");
                    empleado.Sueldo = decimal.Parse(Interaction.InputBox("Ingrese Sueldo del Empleado"));
                    empleado.Legajo = ValidaLegajo(Interaction.InputBox("Ingrese Legajo del Empleado"));
                    empleado.SetBeneficio();
                    Lista_Directivo.Add(empleado);
                    dgvEmpleado.DataSource = null;
                    dgvEmpleado.DataSource = Lista_Directivo;
                }
                else
                {
                    throw new IngresoVacio();

                }
            }
            catch (IngresoVacio) { MessageBox.Show("Debe seleccionar un tipo de Empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            //catch (IngresoVacio) { }
            //catch (IngresoVacio) { }
            //catch (IngresoVacio) { }
        }


        private void btnAsignar_Click(object sender, EventArgs e)
        {


        }
        private string ValidaLegajo(string pLegajo)
        {
            string Legajo = pLegajo;

            foreach (var l in Lista_Operario)
            {
                if (l.Legajo == Legajo)
                {
                    MessageBox.Show("Legajo existente","Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            foreach (var l in Lista_Administrativo)
            {
                if (l.Legajo == Legajo)
                {
                    MessageBox.Show("Legajo existente");

                }
            }
            foreach (var l in Lista_Directivo)
            {
                if (l.Legajo == Legajo)
                {
                    MessageBox.Show("Legajo existente");

                }
            }
            return Legajo;
        }

        private string ValidaLegajoAd(string pLegajo)
        {
            string Legajo = pLegajo;

            foreach (var l in Lista_Administrativo)
            {
                if (l.Legajo == Legajo)
                {
                    MessageBox.Show("Legajo existente");

                }
            }
            foreach (var l in Lista_Directivo)
            {
                if (l.Legajo == Legajo)
                {
                    MessageBox.Show("Legajo existente");

                }
            }
            return Legajo;
        }
        private string ValidaLegajoDir(string pLegajo)
        {
            string Legajo = pLegajo;

            foreach (var l in Lista_Directivo)
            {
                if (l.Legajo == Legajo)
                {
                    MessageBox.Show("Legajo existente");

                }
            }
            return Legajo;
        }

        public class IngresoVacio : Exception
        {
            public override string Message => "Error por campo vacio";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

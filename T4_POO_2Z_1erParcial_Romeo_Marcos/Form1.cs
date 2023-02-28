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
        //Operario operario = new Operario();
        //Administrativo administrativo = new Administrativo();
        //Directivo directivo = new Directivo();

        //List<Operario> Lista_Operario = new List<Operario>();
        //List<Administrativo> Lista_Administrativo = new List<Administrativo>();
        //List<Directivo> Lista_Directivo = new List<Directivo>();
        List<Empleado> Lista_Empleados = new List<Empleado>();

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
                    Lista_Empleados.Add(empleado);
                    dgvEmpleado.DataSource = null;
                    dgvEmpleado.DataSource = Lista_Empleados;
                }
                else if (rdbAdministrativo.Checked == true)
                {
                    Administrativo empleado = new Administrativo();
                    empleado.Apellido = Interaction.InputBox("Ingrese Apellido del Empleado");
                    empleado.Nombre = Interaction.InputBox("Ingrese Nombre del Empleado");
                    empleado.Sueldo = decimal.Parse(Interaction.InputBox("Ingrese Sueldo del Empleado"));
                    empleado.Legajo = ValidaLegajo(Interaction.InputBox("Ingrese Legajo del Empleado"));
                    empleado.SetBeneficio();
                    Lista_Empleados.Add(empleado);
                    dgvEmpleado.DataSource = null;
                    dgvEmpleado.DataSource = Lista_Empleados;

                }
                else if (rdbDirectivo.Checked == true)
                {
                    Directivo empleado = new Directivo();
                    empleado.Apellido = Interaction.InputBox("Ingrese Apellido del Empleado");
                    empleado.Nombre = Interaction.InputBox("Ingrese Nombre del Empleado");
                    empleado.Sueldo = decimal.Parse(Interaction.InputBox("Ingrese Sueldo del Empleado"));
                    empleado.Legajo = ValidaLegajo(Interaction.InputBox("Ingrese Legajo del Empleado"));
                    empleado.SetBeneficio();
                    Lista_Empleados.Add(empleado);
                    dgvEmpleado.DataSource = null;
                    dgvEmpleado.DataSource = Lista_Empleados;
                }
                else
                {
                    throw new IngresoVacio();

                }
            }
            catch (FormatException) { MessageBox.Show("Debe Ingresar un monto para el Sueldo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            catch (IngresoVacio) when (rdbDirectivo.Checked==false|| rdbOperario.Checked==false|| rdbAdministrativo.Checked==false) { MessageBox.Show("Debe seleccionar un tipo de Empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            catch (IngresoVacio) when ((Interaction.InputBox("Ingrese Apellido del Empleado")).Length == 0) { MessageBox.Show("Debe ingresar un Apellido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }


        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado aux = (Empleado)(dgvEmpleado.SelectedRows[0].DataBoundItem);
                CreaAdelanto(aux);
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Debe seleccionar un Empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private string ValidaLegajo(string pLegajo)
        {
            string Legajo = pLegajo;

            foreach (var l in Lista_Empleados)
            {
                if (l.Legajo == Legajo)
                {
                    MessageBox.Show("Legajo existente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            return Legajo;
        }

        private void CreaAdelanto(Empleado pEmpleado)
        {
            try
            {
                if (pEmpleado.SoloTresAdelantos())
                {
                    Adelanto adelanto = new Adelanto();
                    if (adelanto.AsignaMonto(pEmpleado))
                    {
                        pEmpleado.DevuelveListaAdelanto().Add(adelanto);
                        dgvAdelantoEmpleado.DataSource = null;
                        dgvAdelantoEmpleado.DataSource = pEmpleado.DevuelveListaAdelanto();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public class IngresoVacio : Exception
        {
            public override string Message => "Error por campo vacio";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdelanto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdelantoEmpleado.ReadOnly = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4_POO_2Z_1erParcial_Romeo_Marcos
{
    internal abstract class Empleado
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo { get; set; }
        public int Beneficio { get; set; }
        List<Adelanto> Lista_Adelantos { get; set;}

        private bool SoloTresAdelantos()
        {
            if (Lista_Adelantos.Count > 3)
            {
                MessageBox.Show("Se excede de los adelantos correspondientes", "Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}

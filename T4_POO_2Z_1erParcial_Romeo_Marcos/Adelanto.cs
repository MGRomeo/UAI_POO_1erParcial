using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4_POO_2Z_1erParcial_Romeo_Marcos
{
    internal class Adelanto
    {
        public string Id { get; set; }
        public DateTime FechaOtorgamiento { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public decimal Monto { get; set; }

        public bool AsignaMonto(Empleado pEmpleado)
        {
            Monto = decimal.Parse(Interaction.InputBox("Ingrese monto del adelanto: "));
            if ((pEmpleado.Sueldo / 2) > Monto)
            {
                return true;  
            }
            MessageBox.Show("No es posible asignar este importe. Supera el 50% del sueldo del empleado");
            return false;
        }
    }
}

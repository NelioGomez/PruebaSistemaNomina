using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSistemaNomina
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        private decimal salario;
        
        public EmpleadoBaseMasComision(string nombre, string apellido, string nss, decimal tarifaComision, decimal ventasBrutas, decimal salarioBase) 
            : base(nombre, apellido, nss, tarifaComision, ventasBrutas)
        {
            salario = salarioBase;
        }

        public override decimal Ingresos()
        {
            return base.Ingresos();
        }


    }
}

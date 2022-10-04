using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSistemaNomina
{
    public class EmpleadoPorComision : Empleado
    {
        private decimal comision;
        private decimal ventas;
        
        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal tarifaComision, decimal ventasBrutas) 
            : base(nombre, apellido, nss)
        {
            comision = tarifaComision;
            ventas = ventasBrutas;
        }

        public decimal TarifaComision
        {
            get { return comision; }
            set { comision = (value >= 0) ? value: 0 ; }
        }
        public decimal VentasBrutas
        { 
            get { return ventas; } 
            set { ventas = (value >= 0) ? value: 0; }
        }


        public override decimal Ingresos()
        {
            return TarifaComision * VentasBrutas;
        }

        public override string ToString()
        {
            return string.Format("empleado por comision: {0}\n{1}: {2:C}; {3}; {4:F2}; {5:C}; {6:C}",
                                base.ToString(), "tarifa por comision", TarifaComision, "ventas brutas", VentasBrutas);
        }

    }
}

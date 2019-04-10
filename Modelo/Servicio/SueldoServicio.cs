using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
namespace Modelo.Servicio
{
    public class SueldoServicio
    {
        public Sueldos sueldo = new Sueldos();

        public SueldoServicio(Sueldos sueldo)
        {
            this.sueldo = sueldo;
        }

        public decimal CalcularSuedoNeto(decimal SueldoBruto)
        {
            this.sueldo.SueldoNeto = SueldoBruto-(SueldoBruto * 17) / 100+CalcularHoraExtra();

            return this.sueldo.SueldoNeto;
        }

        private decimal CalcularHoraExtra()
        {
            decimal costo = 0;
            foreach (var item in sueldo.Empleado.HorasExtras)
            {
                if (item.HoraInicio.Hours>18)
                {
                    costo += CalcularHoraSueldo(sueldo.SueldoBruto) * 2;
                }
                else
                {
                    costo += CalcularHoraSueldo(sueldo.SueldoBruto) * Convert.ToDecimal("1.5");
                }
            }
            return costo;
        }

        public decimal CalcularHoraSueldo(decimal sueldoBruto)
        {
            var hora = sueldoBruto / 160;
            return hora;
        }
    }
}

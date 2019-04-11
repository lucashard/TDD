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

        public decimal CalcularSuedoNeto(decimal SueldoBruto, List<HorasExtras> horasExtras)
        {
            this.sueldo.SueldoNeto = SueldoBruto - (SueldoBruto * 17) / 100;//+CalcularHoraExtra(SueldoBruto,horasExtras);

            return this.sueldo.SueldoNeto;
        }

        public decimal CalcularHoraExtra(decimal sueldoBruto,List<HorasExtras> horasExtras)
        {
            decimal costo = 0;
            foreach (var item in horasExtras)
            {
                int cantidad = item.HoraFin.Hours - item.HoraInicio.Hours;
                if (item.HoraInicio.Hours>=18)
                {
                    costo += (CalcularHoraSueldo(sueldoBruto) * 2)*cantidad;
                }
                else
                {
                    costo += (CalcularHoraSueldo(sueldoBruto) * Convert.ToDecimal("1.5"))*cantidad;
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

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

        public decimal CalcularSuedoNeto()
        {
            this.sueldo.SueldoNeto = sueldo.SueldoBruto-(sueldo.SueldoBruto * 17) / 100;

            return this.sueldo.SueldoNeto;
        }

        public decimal CalcularHoraSueldo()
        {
            var hora = sueldo.SueldoNeto / 160;
            return hora;
        }
    }
}

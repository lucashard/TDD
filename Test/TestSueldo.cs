using System;
using System.Collections.Generic;
using System.Text;
using Modelo.Servicio;
using Xunit;
namespace Test
{
    public class TestSueldo
    {
        public SueldoServicio sueldos;
        public TestSueldo()
        {
            sueldos = new SueldoServicio(new Modelo.Sueldos() { SueldoBruto = 60000, Empleado = new Modelo.Empleado() { Dni = 32638916, Nombre = "Lucas", Id = 1 } });
        }

        [Fact]
        public void CalcularSueldoNeto()
        {
            decimal sueldo=sueldos.CalcularSuedoNeto();
            Assert.True(49800 == sueldo);
        }

        [Fact]
        public void CalcularHora()
        {
            sueldos.CalcularSuedoNeto();
            decimal horasueldo = sueldos.CalcularHoraSueldo();
            decimal hora = decimal.Parse("311.25");
            Assert.True(hora== horasueldo);
        }

    }
}

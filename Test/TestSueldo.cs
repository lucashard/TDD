using System.Collections.Generic;
using Modelo.Servicio;
using Xunit;
namespace Test
{
    public class TestSueldo
    {
        public SueldoServicio sueldos;
        public TestSueldo()
        {
            sueldos = new SueldoServicio(new Modelo.Sueldos() { SueldoBruto = 60000, Empleado = new Modelo.Empleado() { Dni = 32638916, Nombre = "Lucas", Id = 1,
                HorasExtras = new List<Modelo.HorasExtras>() { new Modelo.HorasExtras { HoraInicio=new System.TimeSpan(18,0,0),HoraFin=new System.TimeSpan(23,0,0),EsFeriado=false} }
            } });
        }

        [Fact]
        public void CalcularSueldoNeto()
        {
            decimal sueldo = sueldos.CalcularSuedoNeto(sueldos.sueldo.SueldoBruto, sueldos.sueldo.Empleado.HorasExtras);
            Assert.True(49800 == sueldo);
        }

        [Fact]
        public void CalcularHora()
        {
            decimal horaNeta = sueldos.CalcularSuedoNeto(sueldos.sueldo.SueldoBruto,sueldos.sueldo.Empleado.HorasExtras);
            decimal horasueldo = sueldos.CalcularHoraSueldo(horaNeta);
            decimal hora = decimal.Parse("311.25");
            Assert.True(hora == horasueldo);
        }

        [Fact]
        public void CalcularHorasExtrasDespuesDeLas18ConCargas()
        {
            decimal horaExtra = sueldos.CalcularHoraExtra(sueldos.sueldo.SueldoBruto,sueldos.sueldo.Empleado.HorasExtras);

            Assert.True(horaExtra == decimal.Parse("3750"));

        }

    }
}

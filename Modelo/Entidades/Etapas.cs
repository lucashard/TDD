using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Etapas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Duracion { get; set; }
        public Empleado ListEmpleados;

        public Etapas(Empleado empleados,decimal duracion,string nombre)
        {
            this.ListEmpleados = empleados;
            this.Nombre = nombre;
            this.Duracion = duracion;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Modelo
{
    public class EmpleadoServicio
    {
        private List<Empleado> list;

        public EmpleadoServicio():this(new List<Empleado>())
        {

        }

        public EmpleadoServicio(List<Empleado> list)
        {
            this.list = list;
        }

        public void Add(Empleado empleado)
        {
            list.Add(empleado);
        }

        public void BorrarEmpleado(Empleado empleado)
        {
            list.Remove(list.Find(x => x.Id == empleado.Id));
        }

        public Empleado Get(int id)
        {
            return list.Find(x => x.Id == id);
        }

        public List<Empleado> Get()
        {
            return list;
        }

        public void Delete(int id)
        {
            list.RemoveAt(id);
        }
    }
}

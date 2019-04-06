using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public long Dni { get; set; }
    }
}

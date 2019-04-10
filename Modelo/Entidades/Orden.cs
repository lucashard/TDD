using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Orden
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public List<Etapas> listEtapas { get; set; }
        public List<MateriasPrima> listMateriasPrimas { get; set; }
        public int CantidadOrdenes=999;       

        public Orden(List<Etapas> etapas, List<MateriasPrima> materiasPrimas,DateTime FechaInicio)
        {
            this.listEtapas = etapas;
            this.listMateriasPrimas = materiasPrimas;
            this.FechaInicio = FechaInicio;
        }

        public Orden()
        {
        }
    }
}

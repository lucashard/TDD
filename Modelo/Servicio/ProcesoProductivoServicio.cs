using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.ValueObjects;

namespace Modelo
{
    public class ProcesoProductivoEmpleadosServicio
    {
        public List<Orden> ListOrdenes = new List<Orden>();
  
        Orden orden = new Orden();
        public ProcesoProductivoEmpleadosServicio(List<Orden> orden)
        {
            this.ListOrdenes = orden;
        }
        public ProcesoProductivoEmpleadosServicio()
        {

        }
        public bool SePuedeAgregarOrden()
        {

            if (orden.CantidadOrdenes>ListOrdenes.Count())
            {
                orden.CantidadOrdenes = orden.CantidadOrdenes - ListOrdenes.Count();
                return true;
            }
            else
            { return false; }
            
        }

        public bool AgregarOrden(Orden orden)
        {
            ListOrdenes.Add(orden);

           return true;
        }

        public decimal CalcularDuracionProducto()
        {
            decimal duracion = 0;
            foreach(var item in ListOrdenes)
            {
                foreach(var etapas in item.listEtapas)
                {
                    duracion += etapas.Duracion;
                }
            }
            return duracion;
        }

        public decimal CalcularCostoProducto()
        {
            decimal costo = 0;
            foreach (var item in ListOrdenes)
            {
                foreach (var material in item.listMateriasPrimas)
                {
                    costo += material.Costo*material.Cantidad;
                }
            }
            return costo;
        }

        public DateTime CalcularFechaProducto()
        {
            DateTime fecha=new DateTime();
            fecha = DateTime.Now;
            decimal duracion = 0;
            foreach (var item in ListOrdenes)
            {
                fecha = item.FechaInicio;
                
                foreach (var etapa in item.listEtapas)
                {
                    duracion += etapa.Duracion;
                }
                duracion /= 8;
            }
            fecha=fecha.AddDays(Convert.ToInt32(Math.Round(duracion, MidpointRounding.AwayFromZero)));

            return fecha;
        }

      
    }
}

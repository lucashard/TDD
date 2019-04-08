using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class StockServicio
    {
        private MateriasPrima materiasPrima = new MateriasPrima();
        private int Cantidad;
        private int StockMinimo;
        private List<Stock> lista = new List<Stock>();

        public StockServicio(MateriasPrima materiasPrima, int cantidad, int stockminimo)
        {
            this.materiasPrima = materiasPrima;
            this.Cantidad = cantidad;
            this.StockMinimo = stockminimo;
        }

        public List<Stock> AgregaMateriaPrima(MateriasPrima materiasPrima, int cantidad, int stockminimo)
        {
            lista.Add(new Stock() { Materias = materiasPrima, Cantidad = cantidad, StockMinimo = stockminimo });
            return lista;
        }
    }
}


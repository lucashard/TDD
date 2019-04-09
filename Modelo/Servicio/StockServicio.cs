﻿using System;
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
            lista.Add(new Stock() { Materias = materiasPrima, Cantidad = cantidad, StockMinimo = stockminimo });
        }

        public List<Stock> AgregaMateriaPrima(MateriasPrima materiasPrima, int cantidad, int stockminimo)
        {
            if (!lista.Exists(x => x.Materias.Nombre == materiasPrima.Nombre))
            {
               lista.Add(new Stock() { Materias = materiasPrima, Cantidad = cantidad, StockMinimo = stockminimo });
            }
            return lista;
        }

        public int AgregarMateriaPrimaQueYaExiste(string materiasPrima, int cantidad)
        {
            int cant1 = lista.Find(x => x.Materias.Nombre == materiasPrima).Cantidad + cantidad;
            lista.Find(x => x.Materias.Nombre == materiasPrima).Cantidad = cant1;
            return cant1;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Modelo;
namespace Test
{
    public class TestStock
    {
        private StockServicio stock;
        public TestStock()
        {
            stock = new StockServicio(new MateriasPrima() { Cantidad = 20, Costo = 30, Nombre = "Cerrucho" }, 30, 40);
        }

        [Fact]
        public void AgregarMateriaPrimaNoExistenteEnStock()
        {
            var lista = stock.AgregaMateriaPrima(new MateriasPrima() { Cantidad = 20, Costo = 30, Nombre = "Madera" }, 30, 40);
            Assert.True(lista.Count == 2);
        }

        [Fact]
        public void AgregarStockCantidadMateriaPrima()
        {
            
            int materia = stock.AgregarMateriaPrimaQueYaExiste("Cerrucho" ,10);
            Assert.True(materia == 40);
        }

  




            

    }
}

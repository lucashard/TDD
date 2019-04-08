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
            stock = new StockServicio(new MateriasPrima() { Cantidad = 20, Costo = 30, Nombre = "Cerrucho" },30,40 );
        }

        [Fact]
        public void AgregarMateriaPrima()
        {
            var lista=stock.AgregaMateriaPrima(new MateriasPrima() { Cantidad = 20, Costo = 30, Nombre = "Cerrucho" }, 30, 40);
            Assert.True(lista.Count == 1);
        }
            

    }
}

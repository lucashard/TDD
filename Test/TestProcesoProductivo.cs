using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Modelo;
using Modelo.ValueObjects;
namespace Test
{
    public class TestProcesoProductivo
    {
        ProcesoProductivoEmpleadosServicio ProcesoProductivoGeneral;
     
        public TestProcesoProductivo()
        {
            ProcesoProductivoGeneral = new ProcesoProductivoEmpleadosServicio(new List<Orden>() {new Orden((new List<Etapas>() { new Etapas(new Empleado() { Nombre = "lucas", Dni = 32638916, Id = 1 } , 20, "Preparacion") })  ,
                                                                        new List<MateriasPrima>() { new MateriasPrima() { Nombre = "Pintura", Id = 1, Cantidad = 30, Costo = 1000 } },DateTime.Now) });
        }
        [Fact]
        public void SePuedeAgregarOrden()
        {
            ProcesoProductivoEmpleadosServicio ProcesoProductivo = new ProcesoProductivoEmpleadosServicio(new List<Orden>() { new Orden((new List<Etapas>() { new Etapas( new Empleado() { Nombre = "lucas", Dni = 32638916, Id = 1 } , 20, "Preparacion") })  ,
                                                                        new List<MateriasPrima>() { new MateriasPrima() { Nombre = "Pintura", Id = 1, Cantidad = 30, Costo = 1000 } },DateTime.Now) });


            bool opcion = ProcesoProductivo.SePuedeAgregarOrden();
            Assert.True(opcion == true);
        }

        [Fact]
        public void ErrorAlAgregarOrdenErronea()
        {
            ProcesoProductivoEmpleadosServicio proc = new ProcesoProductivoEmpleadosServicio(new List<Orden>() { new Orden((new List<Etapas>() { new Etapas(new Empleado() { Nombre = "lucas", Dni = 32638916, Id = 1 } , 2, "") })  ,
                                                                        new List<MateriasPrima>() { new MateriasPrima() { Nombre = "Pintura", Id = 1, Cantidad = 30, Costo = 1000 } },DateTime.Now) });
            List<String> listaErrores = new List<String>();
            foreach (Orden orden in proc.ListOrdenes)
            {
                foreach (var item in orden.listEtapas)
                    {
                    var ex=Assert.Throws<ExcepcionesDeDominio>(
                    () => new Nombre(item.Nombre)).Message.ToString();
                }
            }
            
        }

        [Fact]
        public void CalcularDuracionEnHorasProceso()
        {
            ProcesoProductivoEmpleadosServicio proc = new ProcesoProductivoEmpleadosServicio(new List<Orden>() { new Orden((new List<Etapas>() { new Etapas(new Empleado() { Nombre = "lucas", Dni = 32638916, Id = 1 } , 2, "Proceso 1") })  ,
                                                                        new List<MateriasPrima>() { new MateriasPrima() { Nombre = "Pintura", Id = 1, Cantidad = 30, Costo = 1000 } },DateTime.Now) });

            decimal duracion = proc.CalcularDuracionProducto();
            Assert.True(2 == duracion);
        }

        [Fact]
        public void CalcularCostoDelProductoDeMateriales()
        {
            ProcesoProductivoEmpleadosServicio proc = new ProcesoProductivoEmpleadosServicio(new List<Orden>() { new Orden((new List<Etapas>() { new Etapas(new Empleado() { Nombre = "lucas", Dni = 32638916, Id = 1 } , 2, "Proceso 1") })  ,
                                                                        new List<MateriasPrima>() { new MateriasPrima() { Nombre = "Pintura", Id = 1, Cantidad = 30, Costo = 1000 } },DateTime.Now) });

            decimal costo = proc.CalcularCostoProducto();
            Assert.True(30000 == costo);
        }

        [Fact]
        public void CalcularDuracionEnDias()
        {
            DateTime duracion = ProcesoProductivoGeneral.CalcularFechaProducto();
            
            Assert.True(DateTime.Now.AddDays(3).Date == duracion.Date);
        }


    
    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controllers;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalAplicada2.Controllers.Tests
{
    [TestClass()]
    public class FacturaControllerTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //bool paso = false;
            //Facturas Factura = new Facturas();
            //Factura.Fecha = DateTime.Now;

            //paso = FacturaController.Insertar(Factura);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //bool paso = false;
            //Facturas Factura = new Facturas();
            //Factura.FacturaId = 1;
            //Factura.Fecha = DateTime.Now;

            //paso = FacturaController.Modificar(Factura);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Facturas Factura = FacturaController.Buscar(1);

            //Assert.IsNotNull(Factura);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //bool paso = false;

            //paso = FacturaController.Eliminar(1);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            //List<Facturas> Facturas = new List<Facturas>();
            //Facturas = FacturaController.GetList(e => true);

            //Assert.IsNotNull(Facturas);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controller;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalAplicada2.Controller.Tests
{
    [TestClass()]
    public class ProveedoresControllerTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //bool paso = false;
            //Proveedores Proveedor = new Proveedores();
            //Proveedor.Nombre = "ProbandoTest";

            //paso = ProveedoresController.Insertar(Proveedor);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //bool paso = false;
            //Proveedores Proveedor = new Proveedores();
            //Proveedor.ProveedorId = 1;
            //Proveedor.Nombre = "Probando test Modificando";

            //paso = ProveedoresController.Modificar(Proveedor);
            //Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Proveedores Proveedor = ProveedoresController.Buscar(1);

            //Assert.IsNotNull(Proveedor);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //bool paso = false;

            //paso = ProveedoresController.Eliminar(1);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            //List<Proveedores> Proveedors = new List<Proveedores>();
            //Proveedors = ProveedoresController.GetList(e => true);

            //Assert.IsNotNull(Proveedors);
        }

    }
}
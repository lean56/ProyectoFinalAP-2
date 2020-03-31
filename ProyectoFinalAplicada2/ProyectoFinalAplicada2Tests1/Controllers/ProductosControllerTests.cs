using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controllers;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalAplicada2.Controllers.Tests
{
    [TestClass()]
    public class ProductosControllerTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //bool paso = false;
            //Productos Producto = new Productos();
            //Producto.Descripcion = "ProbandoTest";

            //paso = ProductosController.Insertar(Producto);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //bool paso = false;
            //Productos Producto = new Productos();
            //Producto.ProductoId = 1;
            //Producto.Descripcion = "Probando test Modificando";

            //paso = ProductosController.Modificar(Producto);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Productos Producto = ProductosController.Buscar(1);

            //Assert.IsNotNull(Producto);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //bool paso = false;

            //paso = ProductosController.Eliminar(1);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            //List<Productos> Productos = new List<Productos>();
            //Productos = ProductosController.GetList(e => true);

            //Assert.IsNotNull(Productos);
        }
    }
}
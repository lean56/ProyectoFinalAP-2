using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controllers;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalAplicada2.Controllers.Tests
{
    [TestClass()]
    public class EntradasControllerTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //bool paso = false;
            //Entradas Entrada = new Entradas();
            //Entrada.Fecha = DateTime.Now;

            //paso = EntradasController.Insertar(Entrada);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //bool paso = false;
            //Entradas Entrada = new Entradas();
            //Entrada.EntradaId = 1;
            //Entrada.Fecha = DateTime.Now;

            //paso = EntradasController.Modificar(Entrada);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Entradas Entrada = EntradasController.Buscar(1);

            //Assert.IsNotNull(Entrada);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //bool paso = false;

            //paso = EntradasController.Eliminar(1);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            //List<Entradas> Entradas = new List<Entradas>();
            //Entradas = EntradasController.GetList(e => true);

            //Assert.IsNotNull(Entradas);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controllers;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalAplicada2.Controllers.Tests
{
    [TestClass()]
    public class ClientesControllerTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //bool paso = false;
            //Clientes Cliente = new Clientes();
            //Cliente.Nombres = "ProbandoTest";

            //paso = ClientesController.Insertar(Cliente);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //bool paso = false;
            //Clientes Cliente = new Clientes();
            //Cliente.ClienteId = 1;
            //Cliente.Nombres = "ProbandoTestModificar";

            //paso = ClientesController.Modificar(Cliente);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Clientes Cliente = ClientesController.Buscar(1);

            //Assert.IsNotNull(Cliente);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //bool paso = false;

            //paso = ClientesController.Eliminar(1);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            //List<Clientes> Clientes = new List<Clientes>();
            //Clientes = ClientesController.GetList(e => true);

            //Assert.IsNotNull(Clientes);
        }
    }
}
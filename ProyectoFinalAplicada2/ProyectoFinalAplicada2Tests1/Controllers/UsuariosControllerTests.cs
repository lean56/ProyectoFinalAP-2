using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controllers;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalAplicada2.Controllers.Tests
{
    [TestClass()]
    public class UsuariosControllerTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //bool paso = false;
            //Usuarios Usuario = new Usuarios();
            //Usuario.Nombres = "ProbandoTest";

            //paso = UsuariosController.Insertar(Usuario);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //bool paso = false;
            //Usuarios Usuario = new Usuarios();
            //Usuario.UsuarioId = 2;
            //Usuario.Nombres = "Probando test Modificando";

            //paso = UsuariosController.Modificar(Usuario);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Usuarios Usuario = UsuariosController.Buscar(1);

            //Assert.IsNotNull(Usuario);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            //bool paso = false;

            //paso = UsuariosController.Eliminar(1);
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            //List<Usuarios> Usuarios = new List<Usuarios>();
            //Usuarios = UsuariosController.GetList(e => true);

            //Assert.IsNotNull(Usuarios);
        }
    }
}
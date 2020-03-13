using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAplicada2.Controller;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ProyectoFinalAplicada2.Controller;

namespace ProyectoFinalAplicada2.Controller.Tests
{
    [TestClass()]
    public class UsuarioControllerTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            UsuarioController controller = new UsuarioController();

            Usuarios usuario = new Usuarios()
            {
                //UsuarioId = 0,
                Nombres = "Leonardo Emil",
                Email = "Lean56@gmail.com",
                Usuario = "lean56",
                Contraseña = "lean123",
                NivelUsuario = "Administrador",
                FechaIngreso = DateTime.Now
            };
            Assert.IsTrue(controller.Guardar(usuario));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

     
    }
}
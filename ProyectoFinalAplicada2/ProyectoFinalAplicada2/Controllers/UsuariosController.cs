using Microsoft.EntityFrameworkCore;
using ProyectoFinalAplicada2.Data;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProyectoFinalAplicada2.Controllers
{
    public class UsuariosController
    {
        public bool Guardar(Usuarios usuario)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (usuario.UsuarioId == 0)
                {
                    paso = Insertar(usuario);

                }
                else
                {
                    paso = Modificar(usuario);

                }
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return paso;
        }

        private bool Insertar(Usuarios usuario)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Usuarios.Add(usuario);
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return paso;
        }

        private bool Modificar(Usuarios usuario)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                Usuarios UsuarioTemporal = contexto.Usuarios.Find(usuario.UsuarioId);
                if (UsuarioTemporal != null)
                {
                    contexto = new Contexto();
                    contexto.Entry(usuario).State = EntityState.Modified;
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return paso;
        }

        public Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios usuario = new Usuarios();

            try
            {
                usuario = contexto.Usuarios.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return usuario;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Usuarios usuario = new Usuarios();

            try
            {
                usuario = contexto.Usuarios.Find(id);
                contexto.Entry(usuario).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return paso;
        }

        public List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {

            Contexto contexto = new Contexto();
            List<Usuarios> ListadoUsuarios = new List<Usuarios>();

            try
            {
                ListadoUsuarios = contexto.Usuarios.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return ListadoUsuarios;
        }

    }
}
using Microsoft.EntityFrameworkCore;
using ProyectoFinalAplicada2.Data;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProyectoFinalAplicada2.Controllers
{
    public class CategoriasController
    {
        public bool Guardar(Categorias categoria)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (categoria.CategoriaId == 0)
                {
                    paso = Insertar(categoria);

                }
                else
                {
                    paso = Modificar(categoria);

                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Insertar(Categorias categoria)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Categorias.Add(categoria);
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

        private bool Modificar(Categorias categoria)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                Categorias CategoriaTemporal = contexto.Categorias.Find(categoria.CategoriaId);
                if (CategoriaTemporal != null)
                {
                    contexto = new Contexto();
                    contexto.Entry(categoria).State = EntityState.Modified;
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Categorias Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Categorias categoria = new Categorias();

            try
            {
                categoria = contexto.Categorias.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return categoria;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Categorias categoria = new Categorias();

            try
            {
                categoria = contexto.Categorias.Find(id);
                contexto.Entry(categoria).State = EntityState.Deleted;
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

        public List<Categorias> GetList(Expression<Func<Categorias, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Categorias> ListagoCategorias;

            try
            {
                ListagoCategorias = contexto.Categorias.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return ListagoCategorias;
        }
    }
}
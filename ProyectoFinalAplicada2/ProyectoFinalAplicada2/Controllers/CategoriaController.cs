using Microsoft.EntityFrameworkCore;
using ProyectoFinalAplicada2.Data;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Controllers
{
    public class CategoriaController
    {
        public bool Guardar(Categoria categoria)
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

        private bool Insertar(Categoria categoria)
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
            return paso;
        }

        private bool Modificar(Categoria categoria)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Categorias.Add(categoria);
                contexto.Entry(categoria).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Categoria Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Categoria categoria = new Categoria();

            try
            {
                categoria = contexto.Categorias.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return categoria;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Categoria categoria = new Categoria();

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
            return paso;
        }

        public List<Categoria> GetList(Expression<Func<Categoria, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Categoria> lista;

            try
            {
                lista = contexto.Categorias.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}

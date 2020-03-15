using Microsoft.EntityFrameworkCore;
using ProyectoFinalAplicada2.Data;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Controller
{
    public class ProductosController
    {
        public bool Guardar(Productos producto)
        {
			Contexto contexto = new Contexto();
			bool paso = false;
			try
			{
				if (producto.ProductoId ==0)
				{
					paso = Insertar(producto);
				}
				else
				{
					paso = Modificar(producto);
				}
			}
			catch (Exception)
			{
				throw;
			}
			return paso;
        }

        private bool Insertar(Productos producto)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Productos.Add(producto);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Productos producto)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Productos.Add(producto);
                contexto.Entry(producto).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos producto = new Productos();

            try
            {
                producto = contexto.Productos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Productos producto = new Productos();

            try
            {
                producto = contexto.Productos.Find(id);
                contexto.Entry(producto).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<Productos> GetList(Expression<Func<Productos, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Productos> lista;

            try
            {
                lista = contexto.Productos.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}

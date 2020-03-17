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
    public class EntradasController
    {
        public bool Guardar(Entradas Entrada)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (Entrada.EntradaId == 0)
                {
                    paso = Insertar(Entrada);

                }
                else
                {
                    paso = Modificar(Entrada);

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

        private bool Insertar(Entradas Entrada)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entradas.Add(Entrada);
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

        private bool Modificar(Entradas Entrada)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete from EntradasDetalles where EntradaId={Entrada.EntradaId}");

                foreach (var item in Entrada.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;

                }
                contexto.Entradas.Add(Entrada);
                contexto.Entry(Entrada).State = EntityState.Modified;
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

        public Entradas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Entradas Entrada = new Entradas();

            try
            {
                Entrada = contexto.Entradas.Where(e => e.EntradaId == id).Include(d => d.Detalle).FirstOrDefault();

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }
            return Entrada;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Entradas Entrada = new Entradas();

            try
            {
                Entrada = contexto.Entradas.Find(id);
                contexto.Entry(Entrada).State = EntityState.Deleted;
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

        public List<Entradas> GetList(Expression<Func<Entradas, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Entradas> ListaEntradas;

            try
            {
                ListaEntradas = contexto.Entradas.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }
            return ListaEntradas;
        }
    }
}

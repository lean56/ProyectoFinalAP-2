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
    public class ProveedoresController
    {
        public bool Guardar(Proveedores Proveedor)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (Proveedor.ProveedorId == 0)
                {
                    paso = Insertar(Proveedor);

                }
                else
                {
                    paso = Modificar(Proveedor);

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

        private bool Insertar(Proveedores Proveedor)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Proveedores.Add(Proveedor);
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

        private bool Modificar(Proveedores Proveedor)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                Proveedores ProveedorTemporal = contexto.Proveedores.Find(Proveedor.ProveedorId);
                if (ProveedorTemporal != null)
                {
                    contexto = new Contexto();
                    contexto.Entry(Proveedor).State = EntityState.Modified;
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

        public Proveedores Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Proveedores Proveedor = new Proveedores();

            try
            {
                Proveedor = contexto.Proveedores.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return Proveedor;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Proveedores Proveedor = new Proveedores();

            try
            {
                Proveedor = contexto.Proveedores.Find(id);
                contexto.Entry(Proveedor).State = EntityState.Deleted;
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

        public List<Proveedores> GetList(Expression<Func<Proveedores, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Proveedores> ListaProveedores;

            try
            {
                ListaProveedores = contexto.Proveedores.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return ListaProveedores;

        }

    }
}

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
    public class ClientesController
    {
        public bool Guardar(Clientes cliente)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (cliente.ClienteId == 0)
                {
                    paso = Insertar(cliente);

                }
                else
                {
                    paso = Modificar(cliente);

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

        private bool Insertar(Clientes cliente)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Clientes.Add(cliente);
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

        public bool Modificar(Clientes cliente)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                Clientes ClienteTemporal = contexto.Clientes.Find(cliente.ClienteId);
                if (ClienteTemporal != null)
                {
                    contexto = new Contexto();
                    contexto.Entry(cliente).State = EntityState.Modified;
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

        public Clientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Clientes cliente = new Clientes();

            try
            {
                cliente = contexto.Clientes.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return cliente;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Clientes cliente = new Clientes();

            try
            {
                cliente = contexto.Clientes.Find(id);
                contexto.Entry(cliente).State = EntityState.Deleted;
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

        public List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Clientes> ListadoClientes;

            try
            {
                ListadoClientes = contexto.Clientes.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return ListadoClientes;
        }
    }
}

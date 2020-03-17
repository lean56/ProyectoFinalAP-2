using Microsoft.EntityFrameworkCore;
using ProyectoFinalAplicada2.Controllers;
using ProyectoFinalAplicada2.Data;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Controller
{
    public class PagosController
    {
        public bool Guardar(Pagos Pago)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (Pago.PagoId == 0)
                {
                    paso = Insertar(Pago);

                }
                else
                {
                    paso = Modificar(Pago);

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

        private bool Insertar(Pagos Pago)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (contexto.Pagos.Add(Pago) != null)
                {
                    contexto.Clientes.Find(Pago.ClienteId).Deuda -= Pago.MontoPago;
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

        private bool Modificar(Pagos Pago)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            ClientesController clientesController = new ClientesController();

            try
            {
                Pagos PagoTemporal = contexto.Pagos.Find(Pago.PagoId);
                Clientes Cliente = clientesController.Buscar(PagoTemporal.ClienteId);
                Cliente.Deuda += PagoTemporal.MontoPago;
                contexto.Entry(Cliente).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

                if (paso)
                {
                    contexto = new Contexto();
                    contexto.Clientes.Find(Pago.ClienteId).Deuda -= Pago.MontoPago;
                    contexto.Entry(Pago).State = EntityState.Modified;
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

        public Pagos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pagos Pago = new Pagos();

            try
            {
                Pago = contexto.Pagos.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }

            return Pago;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Pagos Pago = new Pagos();

            try
            {
                Pago = contexto.Pagos.Find(id);
                contexto.Clientes.Find(Pago.ClienteId).Deuda += Pago.MontoPago;
                contexto.Entry(Pago).State = EntityState.Deleted;
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

        public List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Pagos> ListaPagos;

            try
            {
                ListaPagos = contexto.Pagos.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }
            return ListaPagos;

        }
    }
}

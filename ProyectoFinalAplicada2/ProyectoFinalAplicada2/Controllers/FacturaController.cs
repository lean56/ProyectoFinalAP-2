using Microsoft.EntityFrameworkCore;
using ProyectoFinalAplicada2.Data;
using ProyectoFinalAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProyectoFinalAplicada2.Controllers
{
    public class FacturaController
    {
        public bool Guardar(Facturas Factura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (Factura.FacturaId == 0)
                {
                    paso = Insertar(Factura);

                }
                else
                {
                    paso = Modificar(Factura);

                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Insertar(Facturas Factura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (contexto.Facturas.Add(Factura) != null)
                {
                    foreach (var item in Factura.Detalle)
                    {
                        contexto.Productos.Find(item.ProductoId).Cantidad -= item.Cantidad;
                    }
                }
                contexto.Clientes.Find(Factura.ClienteId).Deuda += Factura.Total;
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

        private bool Modificar(Facturas Factura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            ClientesController clientesController = new ClientesController();

            try
            {
                Facturas FacturaAnterior = contexto.Facturas.Where(e => e.FacturaId == Factura.FacturaId).Include(d => d.Detalle).FirstOrDefault();
                Clientes Cliente = clientesController.Buscar(FacturaAnterior.ClienteId);
                Cliente.Deuda -= FacturaAnterior.Total;
                clientesController.Guardar(Cliente);

                contexto = new Contexto();
                foreach (var item in FacturaAnterior.Detalle)
                {
                    if (!Factura.Detalle.Any(d => d.FacturaDetalleId == item.FacturaDetalleId))
                    {
                        contexto.Productos.Find(item.ProductoId).Cantidad += item.Cantidad;
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in Factura.Detalle)
                {
                    if (item.FacturaDetalleId == 0)
                    {
                        contexto.Productos.Find(item.ProductoId).Cantidad -= item.Cantidad;
                        contexto.Entry(item).State = EntityState.Added;

                    }
                    else
                    {
                        contexto.Entry(item).State = EntityState.Modified;

                    }
                }
                contexto.Clientes.Find(Factura.ClienteId).Deuda += Factura.Total;
                contexto.Entry(Factura).State = EntityState.Modified;
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

        public Facturas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Facturas Factura = new Facturas();

            try
            {
                Factura = contexto.Facturas.Where(e => e.FacturaId == id).Include(d => d.Detalle).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }
            return Factura;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                Facturas Factura = contexto.Facturas.Where(e => e.FacturaId == id).Include(d => d.Detalle).FirstOrDefault();

                foreach (var item in Factura.Detalle)
                {
                    contexto.Productos.Find(item.ProductoId).Cantidad += item.Cantidad;

                }
                contexto.Clientes.Find(Factura.ClienteId).Deuda -= Factura.Total;
                contexto.Facturas.Remove(Factura);
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

        public List<Facturas> GetList(Expression<Func<Facturas, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Facturas> lista;

            try
            {
                lista = contexto.Facturas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
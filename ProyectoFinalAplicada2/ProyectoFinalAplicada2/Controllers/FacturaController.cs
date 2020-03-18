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
    public class FacturaController
    {
        public bool Guardar(Facturas factura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (factura.FacturaId == 0)
                {
                    paso = Insertar(factura);
                }
                else
                {
                    paso = Modificar(factura);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Insertar(Facturas factura)
        {
            Contexto contexto = new Contexto();
            ClientesController controller = new ClientesController();
            bool paso = false;

            try
            {
               var cliente = controller.Buscar(factura.ClienteId);
                cliente.Deuda += factura.Total;
                controller.Guardar(cliente);
                contexto.Facturas.Add(factura);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Facturas factura)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            ClientesController controller = new ClientesController();

            try
            {
                var cliente = controller.Buscar(factura.ClienteId);
                var anterior = Buscar(factura.FacturaId);

                cliente.Deuda -= anterior.Total; 

                contexto.Database.ExecuteSqlRaw($"Delete from FacturaDetalles where FacturaId={factura.FacturaId}");

                foreach (var item in factura.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                cliente.Deuda += factura.Total;
                controller.Modificar(cliente);

                contexto.Facturas.Add(factura);
                contexto.Entry(factura).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Facturas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Facturas factura = new Facturas();

            try
            {
                factura = contexto.Facturas.Where(e => e.FacturaId == id).Include(d => d.Detalle).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Facturas factura = new Facturas();
            ClientesController controller = new ClientesController();

            try
            {
                factura = contexto.Facturas.Find(id);
                contexto.Clientes.Find(factura.ClienteId).Deuda -= factura.Total;
                contexto.Facturas.Remove(factura);

                contexto.Entry(factura).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
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

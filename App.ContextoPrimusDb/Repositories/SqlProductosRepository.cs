using App.ContextoPrimusDb.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.ContextoPrimusDb.Repositories
{
    public class SqlProductosRepository : IProductosRepository
    {
        private readonly AppDbContext context;

        public SqlProductosRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Productos Add(Productos producto)
        {
            context.Productos.Add(producto);
            context.SaveChanges();
            return producto;
        }

        public Productos Delete(int id)
        {
            Productos producto = context.Productos.Find(id);

            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }

            return producto;
        }

        public IEnumerable<Productos> GetAll()
        {
            return context.Productos;
        }

        public Productos GetProductos(int id)
        {
            return context.Productos.Find(id);
        }

        public Productos Update(Productos productoCambios)
        {
            var empleado = context.Productos.Attach(productoCambios);
            empleado.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return productoCambios;
        }

    }
}

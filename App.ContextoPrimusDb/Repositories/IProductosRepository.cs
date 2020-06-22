using App.ContextoPrimusDb.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.ContextoPrimusDb.Repositories
{
    public interface IProductosRepository
    {
        Productos GetProductos(int id);

        IEnumerable<Productos> GetAll();

        Productos Add(Productos producto);

        Productos Update(Productos productoCambios);

        Productos Delete(int id);
    }
}

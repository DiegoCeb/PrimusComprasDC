using System;
using System.Collections.Generic;
using System.Text;

namespace App.ContextoPrimusDb.Entidades
{
    public class Productos
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public double PrecioProducto { get; set; }

        public Categorias Categoria { get; set; }

        public IEnumerable<Marcas> Marca { get; set; }

    }
}

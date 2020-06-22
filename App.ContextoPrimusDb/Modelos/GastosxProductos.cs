using System;
using System.Collections.Generic;
using System.Text;

namespace App.ContextoPrimusDb.Entidades
{
    public class GastosxProductos
    {
        public int Id { get; set; }

        public int idProducto { get; set; }

        public int idGastos { get; set; }
    }
}

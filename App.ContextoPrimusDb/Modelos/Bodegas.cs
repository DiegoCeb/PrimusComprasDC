using System;
using System.Collections.Generic;
using System.Text;

namespace App.ContextoPrimusDb.Entidades
{
    public class Bodegas
    {
        public int Id { get; set; }

        public IList<Productos> IdProducto { get; set; }

        public int Cantidad { get; set; }
    }
}

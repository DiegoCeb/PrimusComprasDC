using System;
using System.Collections.Generic;
using System.Text;

namespace App.ContextoPrimusDb.Entidades
{
    public class DevolucionxProducto
    {
        public int Id { get; set; }

        public int IdDevolucion { get; set; }

        public int IdProducto { get; set; }
    }
}

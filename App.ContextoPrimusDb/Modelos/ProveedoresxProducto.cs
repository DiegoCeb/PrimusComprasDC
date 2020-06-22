using System;
using System.Collections.Generic;
using System.Text;

namespace App.ContextoPrimusDb.Entidades
{
    public class ProveedoresxProducto
    {
        public int id { get; set; }

        public int IdProveedor { get; set; }

        public int IdProducto { get; set; }
    }
}

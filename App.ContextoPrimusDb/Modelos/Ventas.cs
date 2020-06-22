using System;
using System.Collections.Generic;
using System.Text;

namespace App.ContextoPrimusDb.Entidades
{
    public class Ventas
    {
        public int Id { get; set; }

        public DateTime FechaVenta { get; set; }

        public double TotalVenta { get; set; }

        public Usuarios Usuario { get; set; }
    }
}

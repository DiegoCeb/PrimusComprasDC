using App.ContextoPrimusDb.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ContextoPrimusDb.Repositories
{
    public class MockProductosRepository : IProductosRepository
    {
        private List<Productos> _productosLista;

        public MockProductosRepository()
        {
            _productosLista = new List<Productos>
            {
                new Productos(){Id = 1, Nombre = "Portatil", Categoria = new Categorias(){ Id = 1, NombreCategoria = "Tecnologia" }, Descripcion = "Bonito", Marca = new List<Marcas> { new Marcas { Id = 1, NombreMarca = "Lenovo" } }, PrecioProducto = 2500000},
                new Productos(){Id = 2, Nombre = "Auriculares", Categoria = new Categorias(){ Id = 2, NombreCategoria = "Tecnologia" }, Descripcion = "Bueno", Marca = new List<Marcas> { new Marcas { Id = 2, NombreMarca = "Samsung" } }, PrecioProducto = 80000},
                new Productos(){Id = 3, Nombre = "Mouse", Categoria = new Categorias(){ Id = 3, NombreCategoria = "Tecnologia" }, Descripcion = "Barato", Marca = new List<Marcas> { new Marcas { Id = 3, NombreMarca = "Logitech" } }, PrecioProducto = 200000},
                new Productos(){Id = 4, Nombre = "Camara", Categoria = new Categorias(){ Id = 4, NombreCategoria = "Tecnologia" }, Descripcion = "Brutal", Marca = new List<Marcas> { new Marcas { Id = 4, NombreMarca = "Cannon" } }, PrecioProducto = 3000000}
            };
        }

        public Productos Add(Productos producto)
        {
            producto.Id = _productosLista.Max(e => e.Id) + 1;
            _productosLista.Add(producto);
            return producto;
        }

        public Productos Delete(int id)
        {
            Productos producto = _productosLista.FirstOrDefault(e => e.Id == id);

            if (producto != null)
            {
                _productosLista.Remove(producto);
            }

            return producto;
        }

        public IEnumerable<Productos> GetAll()
        {
            return _productosLista;
        }

        public Productos GetProductos(int id)
        {
            return _productosLista.FirstOrDefault(e => e.Id == id);
        }

        public Productos Update(Productos productoCambios)
        {
            Productos producto = _productosLista.FirstOrDefault(e => e.Id == productoCambios.Id);

            if (producto != null)
            {
                producto.Nombre = productoCambios.Nombre;
                producto.Descripcion = productoCambios.Descripcion;
                producto.Categoria = productoCambios.Categoria;
                producto.Marca = productoCambios.Marca;
                producto.PrecioProducto = productoCambios.PrecioProducto;
            }

            return producto;
        }
    }
}

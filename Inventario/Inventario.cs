public class Inventario
{
    private Dictionary<int, Producto> productos = new Dictionary<int, Producto>();

    // Propiedad pública para acceder a la lista de productos
    public Dictionary<int, Producto> Productos
    {
        get { return productos; }
    }

    public void AgregarProducto(Producto producto)
    {
        if (productos.ContainsKey(producto.Id))
        {
            throw new ArgumentException("Ya existe un producto con ese ID.");
        }
        productos.Add(producto.Id, producto);
    }

    public void EliminarProducto(int id)
    {
        if (!productos.ContainsKey(id))
        {
            throw new ArgumentException("No existe un producto con ese ID.");
        }
        productos.Remove(id);
    }

    public void MostrarInventario()
    {
        foreach (var producto in productos.Values)
        {
            Console.WriteLine(producto);
        }
    }

    public Producto ObtenerProducto(int id)
    {
        if (!productos.ContainsKey(id))
        {
            return null;
        }
        return productos[id];
    }
}
using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Producto
{
    public int IdProducto { get; set; }

    public double? Precio { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdCategoriaProducto { get; set; }

    public virtual ICollection<ClienteProducto> ClienteProductos { get; set; } = new List<ClienteProducto>();

    public virtual ICollection<FacturaProducto> FacturaProductos { get; set; } = new List<FacturaProducto>();

    public virtual CategoriaProducto? IdCategoriaProductoNavigation { get; set; }

    public virtual ICollection<ProductoMateriaprima> ProductoMateriaprimas { get; set; } = new List<ProductoMateriaprima>();
}

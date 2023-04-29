using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class ClienteProducto
{
    public int IdClienteProducto { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}

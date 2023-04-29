using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class FacturaProducto
{
    public int IdFacturaProducto { get; set; }

    public int? IdFactura { get; set; }

    public int? IdProducto { get; set; }

    public double? Cantidad { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}

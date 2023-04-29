using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Factura
{
    public int IdFactura { get; set; }

    public int? IdCliente { get; set; }

    public string? IdEmpleado { get; set; }

    public int? IdPago { get; set; }

    public int? NumeroMesa { get; set; }

    public DateTime? Fecha { get; set; }

    public double? PrecioTotal { get; set; }

    public int? CantidadTotal { get; set; }

    public virtual ICollection<FacturaProducto> FacturaProductos { get; set; } = new List<FacturaProducto>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Pago? IdPagoNavigation { get; set; }
}

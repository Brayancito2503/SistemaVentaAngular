using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Pago
{
    public int IdPago { get; set; }

    public string? FormaDePago { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}

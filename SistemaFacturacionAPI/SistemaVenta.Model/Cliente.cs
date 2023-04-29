using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public int? IdDelivery { get; set; }

    public virtual ICollection<ClienteProducto> ClienteProductos { get; set; } = new List<ClienteProducto>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Delivery? IdDeliveryNavigation { get; set; }
}

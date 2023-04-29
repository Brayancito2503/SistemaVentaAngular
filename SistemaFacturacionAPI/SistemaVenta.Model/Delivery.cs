using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Delivery
{
    public int IdDelivery { get; set; }

    public string? NombreEmpresa { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}

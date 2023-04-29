using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class NumerosTelefono
{
    public int IdNumeroTelefono { get; set; }

    public string? Numero { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}

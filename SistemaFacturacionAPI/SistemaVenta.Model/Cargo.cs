using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Cargo
{
    public int IdCargo { get; set; }

    public string? Tipo { get; set; }

    public int? Salario { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<MenuRol> MenuRols { get; set; } = new List<MenuRol>();
}

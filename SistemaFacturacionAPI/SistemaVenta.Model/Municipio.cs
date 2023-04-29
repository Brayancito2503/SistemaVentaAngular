using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Municipio
{
    public int IdMunicipio { get; set; }

    public string? Nombre { get; set; }

    public int? IdDepartamento { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual Departamento? IdDepartamentoNavigation { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}

using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Empleado
{
    public string Cedula { get; set; } = null!;

    public int? IdNumeroTelefono { get; set; }

    public int? IdMunicipio { get; set; }

    public int? IdCargo { get; set; }

    public string? Nombre { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cargo? IdCargoNavigation { get; set; }

    public virtual Municipio? IdMunicipioNavigation { get; set; }

    public virtual NumerosTelefono? IdNumeroTelefonoNavigation { get; set; }
}

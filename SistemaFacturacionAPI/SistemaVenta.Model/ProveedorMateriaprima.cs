using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class ProveedorMateriaprima
{
    public int IdProveedorMateriaprima { get; set; }

    public int? IdMateriaPrima { get; set; }

    public int? Ruc { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public double? Precio { get; set; }

    public double? Cantidad { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public virtual MateriaPrima? IdMateriaPrimaNavigation { get; set; }

    public virtual Proveedor? RucNavigation { get; set; }
}

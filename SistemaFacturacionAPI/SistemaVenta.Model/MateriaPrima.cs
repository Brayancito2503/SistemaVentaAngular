using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class MateriaPrima
{
    public int IdMateriaPrima { get; set; }

    public int? IdCategoria { get; set; }

    public string? Nombre { get; set; }

    public double? Cantidad { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual ICollection<ProductoMateriaprima> ProductoMateriaprimas { get; set; } = new List<ProductoMateriaprima>();

    public virtual ICollection<ProveedorMateriaprima> ProveedorMateriaprimas { get; set; } = new List<ProveedorMateriaprima>();
}

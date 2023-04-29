using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class MenuRol
{
    public int IdMenuRol { get; set; }

    public int? IdMenu { get; set; }

    public int? IdCargo { get; set; }

    public virtual Cargo? IdCargoNavigation { get; set; }

    public virtual Menu? IdMenuNavigation { get; set; }
}

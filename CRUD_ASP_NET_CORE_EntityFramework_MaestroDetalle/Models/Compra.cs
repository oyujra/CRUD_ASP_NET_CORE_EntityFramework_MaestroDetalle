using System;
using System.Collections.Generic;

namespace CRUD_ASP_NET_CORE_EntityFramework_MaestroDetalle.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? RazonSocial { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();
}

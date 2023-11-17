using System;
using System.Collections.Generic;

namespace CRUD_ASP_NET_CORE_EntityFramework_MaestroDetalle.Models;

public partial class DetalleCompra
{
    public int IdDetalleCompra { get; set; }

    public int? IdCompra { get; set; }

    public string? Producto { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Total { get; set; }

    public virtual Compra? IdCompraNavigation { get; set; }
}

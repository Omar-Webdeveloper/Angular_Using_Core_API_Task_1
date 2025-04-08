using System;
using System.Collections.Generic;

namespace Angular_Using_Core_API.Server.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDesc { get; set; }
}

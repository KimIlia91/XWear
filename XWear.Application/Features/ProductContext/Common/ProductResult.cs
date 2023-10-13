using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWear.Application.Features.ProductContext.Common;

public sealed record ProductResult(
    Guid Id,
    string Name,
    ProductSizePriceResult ProductSize,
    string ImgUrl,
    bool IsFavorit);

public sealed record ProductSizePriceResult(
    Guid Id,
    decimal Price);

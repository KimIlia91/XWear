using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWear.Contracts.Product.Request;

public record AddProductToFavoriteRequest(Guid ProductId);


﻿using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors;

public static partial class Errors
{
    public static class Category
    {
        public static Error InvalidNameLength => Error.Validation(
               code: PropertyResources.CategoryName,
               description: string.Format(ErrorResources.InvalidStringLength, EntityConstants.CategoryNameLength));
    }
}

using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Resources;

namespace XWear.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class Image
        {
            public static Error InvalidNameLength => Error.Validation(
                code: PropertyResources.ImageName,
                description: string.Format(ErrorResources.InvalidStringLength, EntityConstants.ImageNameLength));
        }
    }
}

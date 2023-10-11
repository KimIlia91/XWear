using ErrorOr;
using System.ComponentModel;
using System.Reflection;

namespace XWear.Domain.Common.Extensions;

internal class EnumHelper
{
    public static ErrorOr<T> GetEnumFromDescription<T>(string description) where T : Enum
    {
        FieldInfo[] fields = typeof(T).GetFields();
        var descriptionToUpper = description.ToUpper();

        foreach (FieldInfo field in fields)
        {
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                if (attribute.Description.ToUpper() == descriptionToUpper)
                {
                    return (T)field.GetValue(null);
                }
            }
        }

        return Errors.Errors.Common.NotFound;
    }
}

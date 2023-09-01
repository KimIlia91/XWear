using System.ComponentModel;

namespace XWear.Domain.Common.Extensions;

public static class EnumExtensions
{
    public static string GetDescription<TEnum>(this TEnum enumerationValue) where TEnum : Enum
    {
        var type = enumerationValue.GetType();
        if (!type.IsEnum) throw new ArgumentException($"{nameof(enumerationValue)} must be of Enum type");

        var memberInfo = type.GetMember(enumerationValue.ToString());
        if (memberInfo.Length > 0)
        {
            var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attrs.Length > 0)
            {
                return ((DescriptionAttribute)attrs[0]).Description;
            }
        }

        return enumerationValue.ToString();
    }

    public static string? GetDescriptionOrNull(this Enum enumValue)
    {
        return enumValue == null ? null : GetDescription(enumValue);
    }

    public static IEnumerable<TEnum> GetAllAsEnumerable<TEnum>() where TEnum : Enum
    {
        return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
    }

    public static IEnumerable<EnumResult> ToEnumResults<TEnum>() where TEnum : Enum
    {
        return ToEnumResults(GetAllAsEnumerable<TEnum>().ToArray());
    }

    public static IEnumerable<EnumResult> ToEnumResults<TEnum>(params TEnum[] values) where TEnum : Enum
    {
        return values.ToList()
            .Select(t => new EnumResult
            {
                Id = (int)(object)t,
                Name = t.ToString(),
                Description = t.GetDescription()
            });
    }
}

using System.ComponentModel;

namespace XWear.Domain.Common.Enums;

public enum CategoryEnum
{
    [Description("Спортивная одежда")] Activewear,

    [Description("Нижнее белье")] Bottoms,
    [Description("Ремни")] Belts,

    [Description("Платья")] Dresses,

    [Description("Шлепки")] FlipFlops,

    [Description("Перчатки")] Gloves,
    [Description("Кеды")] Gumshoes,

    [Description("Верхняя одежда")] Outerwear,

    [Description("Купальники")] Swimwear,
    [Description("Кросовки")] Sneakers,
    [Description("Сандали")] Sandals,
    [Description("Пижамы")] Sleepwear,
    [Description("Солнцезащитные очки")] Sunglasses,
    [Description("Шарфы")] Scarves,
    [Description("Туфли")] Shoes,

    [Description("Сумки")] Handbags,
    [Description("Головные уборы")] Hats,

    [Description("Лофферы")] Loafers,

    [Description("Галстуки")] Ties,

    [Description("Украшения")] Jewelry,

    [Description("Часы")] Watches,
    [Description("Кошельки")] Wallets,
}

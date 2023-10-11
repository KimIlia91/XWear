namespace XWear.Domain.Common.Constants;

public class RegexConstants
{
    public const string PasswordPolicyValidatorRegex = @"^(?=.*[!@#$%^&*])(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,32}$";
    public const string UrlRegex = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
    public const string Email = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";
}

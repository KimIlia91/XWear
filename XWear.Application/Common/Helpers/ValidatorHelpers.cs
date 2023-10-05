using PhoneNumbers;
using System.Text.RegularExpressions;

namespace XWear.Application.Common.Helpers;

public static class ValidatorHelpers
{
    public static bool MustBePhoneNumberFormat(string phone)
    {
        try
        {
            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            var number = phoneNumberUtil.Parse(phone, "ZZ");
            return phoneNumberUtil.IsValidNumber(number);
        }
        catch (NumberParseException)
        {
            return false;
        }
    }

    public static bool PasswordPolicy(string password)
    {
        return Regex.IsMatch(password, @"^(?=.*[!@#$%^&*])(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,32}$", RegexOptions.Compiled);
    }
}



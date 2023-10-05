using PhoneNumbers;

namespace XWear.Application.Common.Helpers
{
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
    }
}

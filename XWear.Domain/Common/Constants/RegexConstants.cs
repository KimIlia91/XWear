﻿namespace XWear.Domain.Common.Constants;

public class RegexConstants
{
    public const string PasswordPolicyValidatorRegex = @"^(?=.*[!@#$%^&*])(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,32}$";
}
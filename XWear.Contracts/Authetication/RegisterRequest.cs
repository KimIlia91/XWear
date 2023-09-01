namespace XWear.Contracts.Authetication;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string Password,
    string ConfirmPassword);

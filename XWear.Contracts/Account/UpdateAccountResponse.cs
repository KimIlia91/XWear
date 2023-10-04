namespace XWear.Contracts.Account;

public record UpdateAccountResponse(
    string FirstName,
    string LastName,
    string Email,
    string Phone);

namespace XWear.Contracts.Account;

public record AccountResponse(
    string FirstName,
    string LastName,
    string Email,
    string Phone);

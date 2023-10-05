namespace XWear.Contracts.Account.Responses;

public record AccountResponse(
    string FirstName,
    string LastName,
    string Email,
    string Phone);

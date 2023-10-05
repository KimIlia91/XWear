namespace XWear.Contracts.Account.Requests
{
    public record AccountUpdateRequest(
        string FirstName,
        string LastName,
        string Email,
        string Phone);
}

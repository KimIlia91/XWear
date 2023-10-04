namespace XWear.Contracts.Account
{
    public record AccountUpdateRequest(
        string FirstName,
        string LastName,
        string Email,
        string Phone);
}

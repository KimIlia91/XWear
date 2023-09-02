namespace XWear.Contracts.Account
{
    public record UpdateAccountRequest(
        string FirstName,
        string LastName,
        string Email,
        string Phone);
}

namespace XWear.Contracts.Authetication.Requests;

public record LoginRequest(
    string Email,
    string Password);

namespace XWear.Contracts.Error;

public sealed record ErrorResponse(
    string Type,
    string Title,
    int Status,
    string TraceId,
    Dictionary<string, List<string>> Errors);

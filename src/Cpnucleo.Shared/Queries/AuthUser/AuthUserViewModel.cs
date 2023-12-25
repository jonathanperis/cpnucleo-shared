namespace Cpnucleo.Shared.Queries.AuthUser;

public sealed record AuthUserViewModel(OperationResult OperationResult, string? Token = default, RecursoDto? Recurso = default) : BaseQuery;
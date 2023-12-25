namespace Cpnucleo.Shared.Queries.GetSistema;

public sealed record GetSistemaViewModel(OperationResult OperationResult, SistemaDto? Sistema = default) : BaseQuery;
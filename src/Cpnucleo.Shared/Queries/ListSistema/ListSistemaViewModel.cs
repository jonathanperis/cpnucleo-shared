namespace Cpnucleo.Shared.Queries.ListSistema;

public sealed record ListSistemaViewModel(OperationResult OperationResult, List<SistemaDto>? Sistemas = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.ListRecurso;

public sealed record ListRecursoViewModel(OperationResult OperationResult, List<RecursoDto>? Recursos = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.GetRecurso;

public sealed record GetRecursoViewModel(OperationResult OperationResult, RecursoDto? Recurso = default) : BaseQuery;
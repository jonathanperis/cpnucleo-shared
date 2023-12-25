namespace Cpnucleo.Shared.Queries.GetRecursoProjeto;

public sealed record GetRecursoProjetoViewModel(OperationResult OperationResult, RecursoProjetoDto? RecursoProjeto = default) : BaseQuery;
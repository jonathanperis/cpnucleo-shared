namespace Cpnucleo.Shared.Queries.ListRecursoProjeto;

public sealed record ListRecursoProjetoViewModel(OperationResult OperationResult, List<RecursoProjetoDto>? RecursoProjetos = default) : BaseQuery;
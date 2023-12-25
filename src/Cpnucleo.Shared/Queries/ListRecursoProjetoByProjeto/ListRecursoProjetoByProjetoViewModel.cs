namespace Cpnucleo.Shared.Queries.ListRecursoProjetoByProjeto;

public sealed record ListRecursoProjetoByProjetoViewModel(OperationResult OperationResult, List<RecursoProjetoDto>? RecursoProjetos = default) : BaseQuery;
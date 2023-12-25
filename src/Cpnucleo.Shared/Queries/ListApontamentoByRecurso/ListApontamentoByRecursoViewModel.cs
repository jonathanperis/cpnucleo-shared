namespace Cpnucleo.Shared.Queries.ListApontamentoByRecurso;

public sealed record ListApontamentoByRecursoViewModel(OperationResult OperationResult, List<ApontamentoDto>? Apontamentos = default) : BaseQuery;
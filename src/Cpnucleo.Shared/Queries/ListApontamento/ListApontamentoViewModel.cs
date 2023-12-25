namespace Cpnucleo.Shared.Queries.ListApontamento;

public sealed record ListApontamentoViewModel(OperationResult OperationResult, List<ApontamentoDto>? Apontamentos = default) : BaseQuery;
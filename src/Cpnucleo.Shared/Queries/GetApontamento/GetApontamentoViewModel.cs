namespace Cpnucleo.Shared.Queries.GetApontamento;

public sealed record GetApontamentoViewModel(OperationResult OperationResult, ApontamentoDto? Apontamento = default) : BaseQuery;
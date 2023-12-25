namespace Cpnucleo.Shared.Queries.ListImpedimento;

public sealed record ListImpedimentoViewModel(OperationResult OperationResult, List<ImpedimentoDto>? Impedimentos = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.GetImpedimento;

public sealed record GetImpedimentoViewModel(OperationResult OperationResult, ImpedimentoDto? Impedimento = default) : BaseQuery;

namespace Cpnucleo.Shared.Queries.GetImpedimentoTarefa;

public sealed record GetImpedimentoTarefaViewModel(OperationResult OperationResult, ImpedimentoTarefaDto? ImpedimentoTarefa = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.ListImpedimentoTarefa;

public sealed record ListImpedimentoTarefaViewModel(OperationResult OperationResult, List<ImpedimentoTarefaDto>? ImpedimentoTarefas = default) : BaseQuery;
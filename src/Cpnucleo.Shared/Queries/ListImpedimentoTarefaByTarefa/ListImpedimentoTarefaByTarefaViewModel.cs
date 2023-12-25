namespace Cpnucleo.Shared.Queries.ListImpedimentoTarefaByTarefa;

public sealed record ListImpedimentoTarefaByTarefaViewModel(OperationResult OperationResult, List<ImpedimentoTarefaDto>? ImpedimentoTarefas = default) : BaseQuery;
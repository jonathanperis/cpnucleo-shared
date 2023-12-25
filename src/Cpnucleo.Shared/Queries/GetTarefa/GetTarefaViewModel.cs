namespace Cpnucleo.Shared.Queries.GetTarefa;

public sealed record GetTarefaViewModel(OperationResult OperationResult, TarefaDto? Tarefa = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.ListTarefa;

public sealed record ListTarefaViewModel(OperationResult OperationResult, List<TarefaDto>? Tarefas = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.ListTarefaByRecurso;

public sealed record ListTarefaByRecursoViewModel(OperationResult OperationResult, List<TarefaDto>? Tarefas = default) : BaseQuery;
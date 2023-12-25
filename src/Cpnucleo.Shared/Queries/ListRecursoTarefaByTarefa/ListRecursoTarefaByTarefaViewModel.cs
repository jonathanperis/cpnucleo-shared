namespace Cpnucleo.Shared.Queries.ListRecursoTarefaByTarefa;

public sealed record ListRecursoTarefaByTarefaViewModel(OperationResult OperationResult, List<RecursoTarefaDto>? RecursoTarefas = default) : BaseQuery;
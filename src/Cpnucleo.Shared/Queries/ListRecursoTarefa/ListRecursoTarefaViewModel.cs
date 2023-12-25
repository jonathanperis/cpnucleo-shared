namespace Cpnucleo.Shared.Queries.ListRecursoTarefa;

public sealed record ListRecursoTarefaViewModel(OperationResult OperationResult, List<RecursoTarefaDto>? RecursoTarefas = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.GetRecursoTarefa;

public sealed record GetRecursoTarefaViewModel(OperationResult OperationResult, RecursoTarefaDto? RecursoTarefa = default) : BaseQuery;
namespace Cpnucleo.Shared.Queries.ListTipoTarefa;

public sealed record ListTipoTarefaViewModel(OperationResult OperationResult, List<TipoTarefaDto>? TipoTarefas = default) : BaseQuery;
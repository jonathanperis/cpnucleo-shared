namespace Cpnucleo.Shared.Queries.GetTipoTarefa;

public sealed record GetTipoTarefaViewModel(OperationResult OperationResult, TipoTarefaDto? TipoTarefa = default) : BaseQuery;
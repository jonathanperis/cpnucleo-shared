﻿namespace Cpnucleo.Shared.Queries.TipoTarefa;

public sealed record ListTipoTarefaViewModel : BaseQuery
{
    public IEnumerable<TipoTarefaDTO> TipoTarefas { get; set; }
    public OperationResult OperationResult { get; set; }
}
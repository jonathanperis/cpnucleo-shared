﻿namespace Cpnucleo.Infra.CrossCutting.Util.Commands.RecursoTarefa;

public class CreateRecursoTarefaCommand : IRequest<OperationResult>
{
    public Guid Id { get; set; }
    public Guid IdRecurso { get; set; }
    public Guid IdTarefa { get; set; }
}
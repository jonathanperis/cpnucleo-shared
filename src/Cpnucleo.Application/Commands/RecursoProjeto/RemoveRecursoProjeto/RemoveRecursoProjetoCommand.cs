﻿namespace Cpnucleo.Application.Commands.RecursoProjeto.RemoveRecursoProjeto;

public class RemoveRecursoProjetoCommand : IRequest<OperationResult>
{
    public Guid Id { get; set; }
}
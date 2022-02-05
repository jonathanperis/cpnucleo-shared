﻿namespace Cpnucleo.Application.Commands.Sistema.UpdateSistema;

public class UpdateSistemaHandler : IRequestHandler<UpdateSistemaCommand, OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateSistemaHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<OperationResult> Handle(UpdateSistemaCommand request, CancellationToken cancellationToken)
    {
        var sistema = await _unitOfWork.SistemaRepository.GetAsync(request.Id);

        if (sistema == null)
        {
            return OperationResult.NotFound;
        }

        sistema.Nome = request.Nome;
        sistema.Descricao = request.Descricao;
        sistema.Ativo = request.Ativo;

        _unitOfWork.SistemaRepository.Update(sistema);

        bool success = await _unitOfWork.SaveChangesAsync();

        OperationResult result = success ? OperationResult.Success : OperationResult.Failed;

        return result;
    }
}
namespace Cpnucleo.Shared.Queries.GetProjeto;

public sealed record GetProjetoViewModel(OperationResult OperationResult, ProjetoDto? Projeto = default) : BaseQuery;
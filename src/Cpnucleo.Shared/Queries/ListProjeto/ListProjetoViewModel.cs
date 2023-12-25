namespace Cpnucleo.Shared.Queries.ListProjeto;

public sealed record ListProjetoViewModel(OperationResult OperationResult, List<ProjetoDto>? Projetos = default) : BaseQuery;
﻿namespace Cpnucleo.RazorPages.Pages.Projeto;

[Authorize]
public class AlterarModel : PageBase
{
    private readonly ICpnucleoApiClient _cpnucleoApiClient;

    public AlterarModel(ICpnucleoApiClient cpnucleoApiClient)
    {
        _cpnucleoApiClient = cpnucleoApiClient;
    }

    [BindProperty]
    public ProjetoDTO Projeto { get; set; }

    public SelectList SelectSistemas { get; set; }

    public async Task<IActionResult> OnGetAsync(Guid id)
    {
        try
        {
            await CarregarDados(id);

            return Page();
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return Page();
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        try
        {
            if (!ModelState.IsValid)
            {
                await CarregarDados(Projeto.Id);

                return Page();
            }

            var result = await _cpnucleoApiClient.ExecuteCommandAsync<OperationResult>("Projeto", "UpdateProjeto", Token, new UpdateProjetoCommand { Id = Projeto.Id, Nome = Projeto.Nome, IdSistema = Projeto.IdSistema });

            if (result == OperationResult.Failed)
            {
                ModelState.AddModelError(string.Empty, "Não foi possível processar a solicitação no momento.");
                return Page();
            }

            return RedirectToPage("Listar");
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return Page();
        }
    }

    private async Task CarregarDados(Guid idProjeto)
    {
        var result = await _cpnucleoApiClient.ExecuteQueryAsync<GetProjetoViewModel>("Projeto", "GetProjeto", Token, new GetProjetoQuery { Id = idProjeto });

        if (result.OperationResult == OperationResult.Failed)
        {
            ModelState.AddModelError(string.Empty, "Não foi possível processar a solicitação no momento.");
            return;
        }

        Projeto = result.Projeto;

        var result2 = await _cpnucleoApiClient.ExecuteQueryAsync<ListSistemaViewModel>("Sistema", "ListSistema", Token, new ListSistemaQuery { });

        if (result2.OperationResult == OperationResult.Failed)
        {
            ModelState.AddModelError(string.Empty, "Não foi possível processar a solicitação no momento.");
            return;
        }

        SelectSistemas = new SelectList(result2.Sistemas, "Id", "Nome");
    }
}

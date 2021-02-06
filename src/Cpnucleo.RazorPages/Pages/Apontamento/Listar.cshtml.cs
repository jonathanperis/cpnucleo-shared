﻿using Cpnucleo.RazorPages.Services.Interfaces;
using Cpnucleo.RazorPages.Models;
using Cpnucleo.RazorPages.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cpnucleo.RazorPages.Pages.Apontamento
{
    [Authorize]
    public class ListarModel : PageBase
    {
        private readonly IHttpService _httpService;

        public ListarModel(IHttpService httpService)
        {
            _httpService = httpService;
        }

        [BindProperty]
        public ApontamentoViewModel Apontamento { get; set; }

        public IEnumerable<ApontamentoViewModel> Lista { get; set; }

        public IEnumerable<TarefaViewModel> ListaTarefas { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                string retorno = ClaimsService.ReadClaimsPrincipal(HttpContext.User, ClaimTypes.PrimarySid);
                Guid idRecurso = new Guid(retorno);

                var result = await _httpService.GetAsync<IEnumerable<ApontamentoViewModel>>("apontamento/getbyrecurso", Token, idRecurso);

                if (!result.sucess)
                {
                    ModelState.AddModelError(string.Empty, $"{result.code} - {result.message}");
                    return Page();
                }

                Lista = result.response;

                var result2 = await _httpService.GetAsync<IEnumerable<TarefaViewModel>>("tarefa/getbyrecurso", Token, idRecurso);

                if (!result2.sucess)
                {
                    ModelState.AddModelError(string.Empty, $"{result2.code} - {result2.message}");
                    return Page();
                }

                ListaTarefas = result2.response;

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
                    string retorno = ClaimsService.ReadClaimsPrincipal(HttpContext.User, ClaimTypes.PrimarySid);
                    Guid idRecurso = new Guid(retorno);

                    var result = await _httpService.GetAsync<IEnumerable<ApontamentoViewModel>>("apontamento/getbyrecurso", Token, idRecurso);

                    if (!result.sucess)
                    {
                        ModelState.AddModelError(string.Empty, $"{result.code} - {result.message}");
                        return Page();
                    }

                    Lista = result.response;

                    var result2 = await _httpService.GetAsync<IEnumerable<TarefaViewModel>>("tarefa/getbyrecurso", Token, idRecurso);

                    if (!result2.sucess)
                    {
                        ModelState.AddModelError(string.Empty, $"{result2.code} - {result2.message}");
                        return Page();
                    }

                    ListaTarefas = result2.response;

                    return Page();
                }

                var result3 = await _httpService.PostAsync<ApontamentoViewModel>("apontamento", Token, Apontamento);

                if (!result3.sucess)
                {
                    ModelState.AddModelError(string.Empty, $"{result3.code} - {result3.message}");
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
    }
}
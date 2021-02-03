﻿using Cpnucleo.RazorPages.Services.Interfaces;
using Cpnucleo.RazorPages.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cpnucleo.RazorPages.Pages.Tarefa
{
    [Authorize]
    public class ListarModel : PageBase
    {
        private readonly ITarefaService _tarefaService;

        public ListarModel(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        public TarefaViewModel Tarefa { get; set; }

        public IEnumerable<TarefaViewModel> Lista { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                Lista = await _tarefaService.ListarAsync(Token, true);

                return Page();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
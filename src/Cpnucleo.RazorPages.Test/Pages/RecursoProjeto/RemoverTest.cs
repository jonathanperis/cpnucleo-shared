﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Cpnucleo.RazorPages.Pages.RecursoProjeto;
using Moq;
using SparkyTestHelpers.AspNetMvc.Core;
using System;
using Xunit;

namespace Cpnucleo.RazorPages.Test.Pages.RecursoProjeto
{
    public class RemoverTest
    {
        private readonly Mock<IRecursoProjetoAppService> _recursoProjetoAppService;

        public RemoverTest()
        {
            _recursoProjetoAppService = new Mock<IRecursoProjetoAppService>();
        }

        [Fact]
        public void Test_OnGet()
        {
            // Arrange
            Guid id = Guid.NewGuid();

            RecursoProjetoViewModel recursoProjetoMock = new RecursoProjetoViewModel { };

            _recursoProjetoAppService.Setup(x => x.Consultar(id)).Returns(recursoProjetoMock);

            RemoverModel pageModel = new RemoverModel(_recursoProjetoAppService.Object);
            PageModelTester<RemoverModel> pageTester = new PageModelTester<RemoverModel>(pageModel);

            // Act
            pageTester
                .Action(x => () => x.OnGet(id))

                // Assert
                .TestPage();
        }

        [Fact]
        public void Test_OnPost()
        {
            // Arrange
            Guid id = Guid.NewGuid();

            _recursoProjetoAppService.Setup(x => x.Remover(id));

            RemoverModel pageModel = new RemoverModel(_recursoProjetoAppService.Object)
            {
                RecursoProjeto = new RecursoProjetoViewModel { Id = id }
            };

            PageModelTester<RemoverModel> pageTester = new PageModelTester<RemoverModel>(pageModel);

            // Act
            pageTester
                .Action(x => x.OnPost)

                // Assert
                .TestRedirectToPage("Listar");
        }
    }
}
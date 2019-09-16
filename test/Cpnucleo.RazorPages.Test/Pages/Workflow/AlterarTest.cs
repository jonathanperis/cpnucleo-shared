﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Application.ViewModels;
using Cpnucleo.RazorPages.Pages.Workflow;
using Moq;
using SparkyTestHelpers.AspNetMvc.Core;
using SparkyTestHelpers.DataAnnotations;
using System;
using Xunit;

namespace Cpnucleo.RazorPages.Test.Pages.Workflow
{
    public class AlterarTest
    {
        private readonly Mock<IWorkflowAppService> _workflowAppService;

        public AlterarTest()
        {
            _workflowAppService = new Mock<IWorkflowAppService>();
        }

        [Fact]
        public void Test_OnGet()
        {
            // Arrange
            Guid id = new Guid();
            WorkflowViewModel workflowMock = new WorkflowViewModel { };

            _workflowAppService.Setup(x => x.Consultar(id)).Returns(workflowMock);

            AlterarModel pageModel = new AlterarModel(_workflowAppService.Object);
            PageModelTester<AlterarModel> pageTester = new PageModelTester<AlterarModel>(pageModel);

            // Act
            pageTester
                .Action(x => () => x.OnGet(id))

                // Assert
                .TestPage();
        }

        [Theory]
        [InlineData("Workflow de Teste", 3)]
        public void Test_OnPost(string nome, int ordem)
        {
            // Arrange
            Guid id = new Guid();
            WorkflowViewModel workflowMock = new WorkflowViewModel { Id = id, Nome = nome, Ordem = ordem };

            _workflowAppService.Setup(x => x.Alterar(workflowMock));

            AlterarModel pageModel = new AlterarModel(_workflowAppService.Object);
            PageModelTester<AlterarModel> pageTester = new PageModelTester<AlterarModel>(pageModel);

            // Act
            pageTester
                .Action(x => x.OnPost)

                // Assert
                .WhenModelStateIsValidEquals(false)
                .TestPage();

            // Act
            pageTester
                .Action(x => x.OnPost)

                // Assert
                .WhenModelStateIsValidEquals(true)
                .TestRedirectToPage("Listar");

            // Assert
            Validation.For(workflowMock).ShouldReturn.NoErrors();
        }
    }
}

﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Application.ViewModels;
using Cpnucleo.RazorPages.Pages.Impedimento;
using Moq;
using SparkyTestHelpers.AspNetMvc.Core;
using System.Collections.Generic;
using Xunit;

namespace Cpnucleo.RazorPages.Test.Pages.Impedimento
{
    public class ListarTest
    {
        private readonly Mock<IAppService<ImpedimentoViewModel>> _impedimentoAppService;

        public ListarTest()
        {
            _impedimentoAppService = new Mock<IAppService<ImpedimentoViewModel>>();
        }

        [Fact]
        public void Test_OnGet()
        {
            // Arrange
            List<ImpedimentoViewModel> listaMock = new List<ImpedimentoViewModel> { };

            _impedimentoAppService.Setup(x => x.Listar()).Returns(listaMock);

            ListarModel pageModel = new ListarModel(_impedimentoAppService.Object);
            PageModelTester<ListarModel> pageTester = new PageModelTester<ListarModel>(pageModel);

            // Act
            pageTester

                // Assert
                .Action(x => x.OnGet)
                .TestPage();
        }
    }
}
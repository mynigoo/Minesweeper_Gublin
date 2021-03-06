// <copyright file="MinefieldTest.cs">Copyright ©  2018</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper_Gublin.ViewModel;

namespace Minesweeper_Gublin.ViewModel.Tests
{
    /// <summary>This class contains parameterized unit tests for Minefield</summary>
    [PexClass(typeof(Minefield))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MinefieldTest
    {
    }
}

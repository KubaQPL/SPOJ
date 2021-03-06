﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Spoj.Solver.UnitTests.Solutions._6___Emperor
{
    [TestClass]
    public sealed class INVCNTTests : SolutionTestsBase
    {
        public override string SolutionSource => Solver.Solutions.INVCNT;

        public override IReadOnlyList<string> TestInputs => new[]
        {
@"2

3
3
1
2

5
2
3
8
6
1"
        };

        public override IReadOnlyList<string> TestOutputs => new[]
        {
@"2
5
"
        };

        [TestMethod]
        public void INVCNT() => TestSolution();
    }
}

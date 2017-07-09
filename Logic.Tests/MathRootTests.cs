using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Logic.MathRoots;

namespace Logic.Tests
{
    [TestFixture]
    public class MathRootTests
    {

        #region Newton's method tests

        [TestCase(4, 2, 0.01, 2.00)]
        [TestCase(459, 2, 0.01, 21.424285287298908)]
        [TestCase(1941, 3, 0.01, 12.474080133232556)]
        [TestCase(1945, 10, 0.01, 2.1325147877535002)]
        [Category("Newton's method")]
        public void NewtonRoot_AllOk_ReturnsRoot(double number, double n, double e, double expectedRes)
        {
            double res = NewtonRoot(number, n, e);

            Assert.AreEqual(expectedRes, res);
        }

        [Category("Newton's method")]
        [TestCase(4, 0, 0.01)]
        [TestCase(459, 2, 1.5)]
        [TestCase(-1941, 4, 0.01)]
        [TestCase(0, -5, 0.01)]
        public void NewtonRoot_IncorrectArguments_ThrowsArgumentException(double number, double n, double e)
        {
            double res;

            Assert.Catch<ArgumentException>(() => res = NewtonRoot(number, n, e));
        }

        #endregion

    }
}

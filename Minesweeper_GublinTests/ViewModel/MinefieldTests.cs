using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper_Gublin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Gublin.ViewModel.Tests
{
    [TestClass()]
    public class MinefieldTests
    {
        [TestMethod()]
        public void GetIndexesAroundTest00()
        {
            int x = 0;
            int y = 0;
            List<int> expected = (new List<int> { 1, 3, 4 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest01()
        {
            int x = 0;
            int y = 1;
            List<int> expected = (new List<int> { 0, 1, 4, 6, 7 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest02()
        {
            int x = 0;
            int y = 2;
            List<int> expected = (new List<int> { 3, 4, 7 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest10()
        {
            int x = 1;
            int y = 0;
            List<int> expected = (new List<int> { 0, 2, 3, 4, 5 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest11()
        {
            int x = 1;
            int y = 1;
            List<int> expected = (new List<int> { 0, 1, 2, 3, 5, 6, 7, 8 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest12()
        {
            int x = 1;
            int y = 2;
            List<int> expected = (new List<int> { 3, 4, 5, 6, 8 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest20()
        {
            int x = 2;
            int y = 0;
            List<int> expected = (new List<int> { 1, 4, 5 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest21()
        {
            int x = 2;
            int y = 1;
            List<int> expected = (new List<int> { 1, 2, 4, 7, 8 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest22()
        {
            int x = 2;
            int y = 2;
            List<int> expected = (new List<int> { 4, 5, 7 });

            object[] args = new object[2] { x, y };
            PrivateObject m = new PrivateObject(new Minefield(3, 3, 0));
            List<int> actual = (List<int>)m.Invoke("GetIndexesAround", args);
            expected.Sort();
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
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

/*
        [TestMethod()]
        public void GetIndexesAroundTest00()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 1, 3, 4 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 0, 0);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest01()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 0, 1, 4, 6, 7 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 0, 1);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

*/
        [TestMethod()]
        public void GetIndexesAroundTest02()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 3, 4, 7 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 0, 2);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest10()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 0, 2, 3, 4, 5 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 1, 0);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest11()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3,3,0));
            List<int> expected = (new List<int> { 0, 1, 2, 3,   5, 6, 7, 8 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 1, 1);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest12()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 3,4,5,6,8 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 1, 2);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetIndexesAroundTest20()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 1, 4, 5 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 2, 0);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest21()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 1, 2, 4, 7, 8 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 2, 1);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexesAroundTest22()
        {
            PrivateObject privateHelperObject = new PrivateObject(new Minefield(3, 3, 0));
            List<int> expected = (new List<int> { 4, 5, 7 });
            expected.Sort();
            List<int> actual = (List<int>)privateHelperObject.Invoke("GetIndexesAround", 2, 2);
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }



    }
}
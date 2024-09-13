using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ParolTesters.Tests
{
    [TestClass]
    public class ParlTests
    {
        [TestMethod]
        public void CheckerParol_vvod_0return()
        {
            //arrange
            string a = "";
            int expected = 0;
            //act
            Parl parl = new Parl();
            int actual = parl.CheckerParol(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckerParol_vvodka_1return()
        {
            //arrange
            string a = "ka";
            int expected = 1;
            //act
            Parl parl = new Parl();
            int actual = parl.CheckerParol(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckerParol_vvodka2_2return()
        {
            //arrange
            string a = "ka2";
            int expected = 2;
            //act
            Parl parl = new Parl();
            int actual = parl.CheckerParol(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckerParol_vvodka2SpecSimvol_3return()
        {
            //arrange
            string a = "ka2)";
            int expected = 3;
            //act
            Parl parl = new Parl();
            int actual = parl.CheckerParol(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckerParol_vvodkaA2SpecSimvol_4return()
        {
            //arrange
            string a = "kaA2)";
            int expected = 4;
            //act
            Parl parl = new Parl();
            int actual = parl.CheckerParol(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckerParol_vvodkaAAAAAAAAAAAAAAAAA2SpecSimvol_5return()
        {
            //arrange
            string a = "kaAAAAAAAAAAAAAAAAA2)";
            int expected = 5;
            //act
            Parl parl = new Parl();
            int actual = parl.CheckerParol(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

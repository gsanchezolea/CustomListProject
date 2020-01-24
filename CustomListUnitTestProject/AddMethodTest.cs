using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTestProject
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void Add_ElementToList_ZeroIndexContainsAValue()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int expected = 1;
            int actual;
            int inputValue = 1;
            //Act
            newList.Add(inputValue);
            actual = newList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ElementToAList_CapacityIncreasesToFour()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int expected = 4;
            int actual;
            int inputValue = 1;

            //Act
            newList.Add(inputValue);
            actual = newList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ElementToAlist_ListElementCountIncreases()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValue = 10;
            int expected = 1;
            int actual;
            //Act
            newList.Add(inputValue);
            actual = newList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveElementsToAList_CapacityShouldIncreaseToEight()
        {
            //The idea here is that because the arrays for this list only increase in size by 4, the moment we add a 5th element 
            //we should see the size of the capacity increase
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValue = 1;
            int expected = 8;
            int actual;
            //Act
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);

            actual = newList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveElementsToAList_ValueAtIndexFiveExists()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValueOne = 1;
            int inputValueTwo = 2;
            int inputValueThree = 3;
            int inputValueFour = 4;
            int inputValueFive = 5;
            int expected = 5;
            int actual;

            //Act
            newList.Add(inputValueOne);
            newList.Add(inputValueTwo);
            newList.Add(inputValueThree);
            newList.Add(inputValueFour);
            newList.Add(inputValueFive);

            actual = newList[4];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveElementsToAList_CapacityShouldDuplicate()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValue = 1;
            int expected = 8;
            int actual;
            //Act
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            actual = newList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    public class RemoveMethodTests
    {
        [TestMethod]
        public void Remove_TwoElementsAfterAddingFiveElements_CountShouldReturnThree()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValue = 1;
            int expected = 3;
            int actual;

            //Act
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            actual = newList.Count;


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Remove_AtIndexTwoInAFiveElementList_ValueOfIndexThreeShouldMoveToIndexTwo()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValueOne = 1;
            int inputValueTwo = 2;
            int inputValueThree = 3;
            int inputValueFour = 4;
            int inputValueFive = 5;
            int expected = 4;
            int actual;
            //Act
            newList.Add(inputValueOne);
            newList.Add(inputValueTwo);
            newList.Add(inputValueThree);
            newList.Add(inputValueFour);
            newList.Add(inputValueFive);
            newList.Remove[3];
            actual = newList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AllElementsInAFiveElementList_ValueOfIndexZeroShouldBeZero()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValue = 1;
            int expected = 0;
            int actual;

            //Act
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            actual = newList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_AllElementsInAFiveElementList_CountShouldDisplayZero()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValue = 0;
            int expected = 0;
            int actual;

            //Act
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            actual = newList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
            public void Remove_AllElementsInAFiveElementList_ValueAtIndexFourShouldBeZero()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValue = 1;
            int expected = 0;
            int actual;

            //Act
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Add(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            newList.Remove(inputValue);
            actual = newList[4];
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}












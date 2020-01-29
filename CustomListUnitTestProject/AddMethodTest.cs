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
            newList.Remove(inputValueThree);
            actual = newList[2];

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
        [TestMethod]
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
        [TestMethod]
        public void String_ThreeIntElements_ElementsShouldBeStrungTogether()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int inputValueOne = 1;
            int inputValueTwo = 2;
            int inputValueThree = 3;
            string expected = "1 2 3";
            string actual;


            //Act
            newList.Add(inputValueOne);
            newList.Add(inputValueTwo);
            newList.Add(inputValueThree);
            actual = newList.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void String_TwoStringElements_TwoStringsShouldBecomeConcatenated()
        {
            //Arrange
            CustomList<string> newList = new CustomList<string>();
            string valueOne = "Hello";
            string valueTwo = "Beautifull";
            string valueThree = "World";
            string expected = "Hello Beautifull World";
            string actual;

            //Act
            newList.Add(valueOne);
            newList.Add(valueTwo);
            newList.Add(valueThree);
            actual = newList.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenatesTwoListsOfThreeElementsEach_ListThreeContainsTheValuesOfBothLists()
        {
            //1,3,5,2,4,6
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree;
            string expected = "1 3 5 2 4 6";
            string actual;

            //Act
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);
            listThree = listOne + listTwo;
            actual = listThree.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void PlusOperator_WeConcatenateAListWithThreeValuesAndAListWithNoValues_ValuesOfTheNonEmptyListWillReturn()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree;
            string expected = "1 3 5";
            string actual;

            //Act
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listThree = listOne + listTwo;
            actual = listThree.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenatingListsOfStrings_StringValuesFromBothListsWillReturn()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();
            CustomList<string> listThree;
            string expected = "KB 24 8 R I P";
            string actual;
            //Act
            listOne.Add("KB");
            listOne.Add("24");
            listOne.Add("8");
            listTwo.Add("R");
            listTwo.Add("I");
            listTwo.Add("P");
            listThree = listOne + listTwo;
            actual = listThree.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateOddNumberLists_AllValuesShouldReturn()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree;
            string expected = "1 2 3";
            string actual;

            //Act
            listOne.Add(1);
            listOne.Add(2);
            listTwo.Add(3);
           
            listThree = listOne + listTwo;
            actual = listThree.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_AddTwoElementsToEachListThenRemoveElementAtIndexOneForEachList_ListThreeShouldOnlyContainTwoValues()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();
            CustomList<string> listThree;
            string expected = "Hello World";
            string actual;
            //Act
            listOne.Add("Hi");
            listOne.Add("Hello");          
            listTwo.Add("World");
            listTwo.Add("Earth");
            listOne.Remove("Hi");
            listTwo.Remove("Earth");

            listThree = listOne + listTwo;
            actual = listThree.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_RemoveValueTwoFromListOne_ValueReturnedIs1945()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree;
            string expected = "1 9 4 5";
            string actual;

            //Act
            listOne.Add(2);
            listOne.Add(1);
            listOne.Add(9);
            listOne.Add(4);
            listOne.Add(5);
            listTwo.Add(7);
            listTwo.Add(8);
            listTwo.Add(3);
            listTwo.Add(2);
            listTwo.Add(0);

            listThree = listOne - listTwo;
            actual = listThree.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_RemoveThreeStringsFromListOne_ListThreeReturnsAlwaysStayCommited()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();
            CustomList<string> listThree;
            string expected = "Always Stay Commited";
            string actual;

            //Act
            listOne.Add("Always");
            listOne.Add("Never");
            listOne.Add("Stay");
            listOne.Add("Leave");
            listOne.Add("Commited");
            listOne.Add("Retained");       
            listTwo.Add("Never");
            listTwo.Add("Leave");
            listTwo.Add("Retained");
            listTwo.Add("Sometimes");
            listTwo.Add("TakeOff");
            listTwo.Add("Maintained");

            listThree = listOne - listTwo;
            actual = listThree.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_TwoEvenLists_FinalListWillTakeInBothValues()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree;
            string expected = "1 2 3 4 5 6 7 8 9 10";
            string actual;
            //Act
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listOne.Add(7);
            listOne.Add(9);
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);
            listTwo.Add(8);
            listTwo.Add(10);
         
            listThree.Zip(listOne, listTwo);
            actual = listThree.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}












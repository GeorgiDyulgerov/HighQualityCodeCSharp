using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDynamicList
{
    [TestClass]
    public class TestDynamicList
    {
        [TestMethod]
        public void Test_CreateEmptyDynamicList_ShouldHaveNoItems()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            //Act
            //Notting here.

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(0, dynamicList.Count, "Dynamic List is not empty.");

        }

        [TestMethod]
        public void Test_AddItemToEmptyDynamicList_ShouldHaveItem()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();

            //Act
            dynamicList.Add(1);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(1, dynamicList.Count, "Dynamic List has more or less than one item.");

        }

        [TestMethod]
        public void Test_AddManyItemsToDynamicList_ShouldHaveItems()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count, dynamicList.Count, string.Format("Dynamic List has more or less than {0} item.", count));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_RemoveAtFromEmptyDynamicList_ShouldTrowExeception()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();

            //Act
            dynamicList.RemoveAt(0);

            //Assert

        }

        [TestMethod]
        public void Test_RemoveAtItemsToDynamicList_ShouldRemoveItemOnSpecifeidIndex()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int index = 10;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            count--;
            var returnedFromRemoveAt = dynamicList.RemoveAt(10);
            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count, dynamicList.Count, string.Format("Dynamic List has more or less than {0} item.", count));
            Assert.AreEqual(index, returnedFromRemoveAt, String.Format("Did not return the correct item from index[{0}]", index));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_RemoveAtFalseIndexFromFullDynamicList_ShouldTrowExeception()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int index = 101;

            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            dynamicList.RemoveAt(index);

            //Assert

        }

        [TestMethod]
        public void Test_RemoveItemFromEmptyDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();

            //Act
            var returnedFromRemoveMethod = dynamicList.Remove(52);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(-1, returnedFromRemoveMethod, "Did not return -1.");
        }

        [TestMethod]
        public void Test_RemoveFalseItemfromDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int falseItem = 666;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            var returnedFromRemoveMethod = dynamicList.Remove(falseItem);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count,dynamicList.Count,"Removed item from the list.");
            Assert.AreEqual(-1, returnedFromRemoveMethod, "Did not return -1.");

        }

        [TestMethod]
        public void Test_RemoveItemfromDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int item = 6;
            int index = 6;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            var returnedIndexFromRemoveMethod = dynamicList.Remove(item);
            count--;
            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count,dynamicList.Count,"Did not remove item from list.");
            Assert.AreEqual(index, returnedIndexFromRemoveMethod, "Did not return the index of the removed item wich is 6.");

        }

        [TestMethod]
        public void Test_IndexOfFalseItemInDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int falseItem = 666;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            var returnedFromIndexOfMethod = dynamicList.IndexOf(falseItem);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count, dynamicList.Count, "Size is not the same.");
            Assert.AreEqual(-1, returnedFromIndexOfMethod, "Did not return -1.");

        }

        [TestMethod]
        public void Test_IndexOfItemfromDynamicList_ShouldReturnIndex()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int item = 6;
            int index = 6;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            var returnedFromIndexOfMethod = dynamicList.IndexOf(item);
            
            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count, dynamicList.Count, "Size is not the same.");
            Assert.AreEqual(index, returnedFromIndexOfMethod, "Did not return the index of the removed item wich is 6.");

        }

        [TestMethod]
        public void Test_IndexOfInEmptyDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int item = 666;
            //Act
            var returnedFromIndexOfMethod = dynamicList.IndexOf(item);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(0, dynamicList.Count, "Size is not the same.");
            Assert.AreEqual(-1, returnedFromIndexOfMethod, "Did not return -1.");

        }

        [TestMethod]
        public void Test_ContainsInEmptyDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int falseItem = 666;
            //Act
            var returnedContainsMethod = dynamicList.Contains(falseItem);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(0, dynamicList.Count, "Size is not the same.");
            Assert.AreEqual(false, returnedContainsMethod, "Did not return -1.");

        }

        [TestMethod]
        public void Test_ContainsFalseItemInDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int falseItem = 666;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            var returnedContainsMethod = dynamicList.Contains(falseItem);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count, dynamicList.Count, "Size is not the same.");
            Assert.AreEqual(false, returnedContainsMethod, "Did not return -1.");

        }

        [TestMethod]
        public void Test_ContainsItemInDynamicList_ShouldReturnMinusOne()
        {
            //Arrange
            var dynamicList = new DynamicList<int>();
            int count = 100;
            int item = 6;
            //Act
            for (int i = 0; i < count; i++)
            {
                dynamicList.Add(i);
            }
            var returnedContainsMethod = dynamicList.Contains(item);

            //Assert
            Assert.IsNotNull(dynamicList);
            Assert.AreEqual(count, dynamicList.Count, "Size is not the same.");
            Assert.AreEqual(true, returnedContainsMethod, "Did not return -1.");

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Platformy_lab1;

namespace TestLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool isItemInRange = false;

            int itemCount = 10;
            int seed = 123;
            int capacity = 0;
            ItemSet itemSet = new ItemSet(itemCount, seed);

            Result result = itemSet.Solution(capacity);

            foreach (int itemId in result.ItemIdList)
            {
                Item item = itemSet.Items.Find(x => x.Id == itemId);
                if (item.Weight <= capacity)
                {
                    isItemInRange = true;
                }
            }
            if (isItemInRange)
            {
                Assert.IsTrue(result.ItemIdList.Count > 0);
            }

        }


    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            int itemCount = 10;
            int seed = 123;
            int capacity = 20;
            ItemSet itemSet = new ItemSet(itemCount, seed);
            ItemSet itemSetReverse = new ItemSet(itemCount, seed);
            itemSetReverse.Items.Reverse();
            Result resultA = itemSet.Solution(capacity);
            Result resultB = itemSetReverse.Solution(capacity);
            //zaklada ze elementy sa sortowane w funkcji solution
            //wtedy kolejnosc nie ma znaczenia 
            CollectionAssert.AreEqual(resultA.ItemIdList, resultB.ItemIdList);
            Assert.AreEqual(resultA.SumValue, resultB.SumValue);  
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            List<Item> items = new List<Item>
        {
            new Item { Id = 1, Weight = 2, Value = 5 },
            new Item { Id = 2, Weight = 3, Value = 8 },
            new Item { Id = 3, Weight = 4, Value = 6 }
        };
            int capacity = 5;
            ItemSet itemSet = new ItemSet(items);
            Result result = itemSet.Solution(capacity);
            Assert.AreEqual(result.SumValue, 13);
            Assert.AreEqual(result.SumWeight, 5);
        }
    }

}
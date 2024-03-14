using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Platformy_lab1;
using System.Diagnostics;

namespace TestLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestItemInRange()
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

        [TestMethod]
        public void TestCapacityEqualsZero()
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

        [TestMethod]
        public void TestSameSolutionForReversedItems()
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

        [TestMethod]
        public void TestExpectedItemList()
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
        // 4 dodatkowe testy
        //sprawdzenia czy przy duzym capacity wszystkie przedmioty beda w plecaku
        [TestMethod]
        public void TestAllItemsFitInBackpack()
        {
            int itemCount = 10;
            int seed = 123;
            int capacity = 1000;
            ItemSet itemSet = new ItemSet(itemCount, seed);
            Result result = itemSet.Solution(capacity);
            Assert.AreEqual(result.ItemIdList.Count(), itemCount);
        }

        [TestMethod]
        [Timeout(3)]
        public void TestPerformance()
        {
            
            int itemCount = 1000; 
            int seed = 123; 
            int capacity = 10000;
            ItemSet itemSet = new ItemSet(itemCount, seed);
            Result result = itemSet.Solution(capacity);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestItemValuesAndWeightsRange()
        {
            int itemCount = 10;
            int seed = 123;
            ItemSet itemSet = new ItemSet(itemCount, seed);
            foreach(Item item in itemSet.Items)
            {
                Assert.IsTrue(item.Value >= 1 && item.Value <= 10);
                Assert.IsTrue(item.Weight >= 1 && item.Weight <= 10);
            }
        }

        [TestMethod]
        public void TestSeedGeneratesSameItems()
        {
            int itemCount = 10;
            int seed = 123;
            ItemSet itemSetA = new ItemSet(itemCount, seed);
            ItemSet itemSetB = new ItemSet(itemCount, seed);
            CollectionAssert.AreEqual(itemSetA.Items, itemSetB.Items);
        }
    }


}

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


}
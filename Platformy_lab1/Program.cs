using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
[assembly: InternalsVisibleTo("TestLab1")]
[assembly: InternalsVisibleTo("Gui")]

namespace Platformy_lab1
{ 
    internal struct Item
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }
    }

    internal class ItemSet
    {
        public int ItemCount { get; set; }
        public List<Item> Items { get; set; }
        public int Seed { get; set; }

        public ItemSet(int itemCount, int seed)
        {
            ItemCount = itemCount;
            Seed = seed;
            Items = GenerateItems(itemCount, seed);
        }

        public ItemSet(List<Item> items)
        {
            Items = items;
        }

        private List<Item> GenerateItems(int itemCount, int seed)
        {
            List<Item> items = new List<Item>();
            Random random = new Random(seed);

            for (int i = 0; i < itemCount; i++)
            {
                items.Add(new Item
                {
                    Id = i + 1,
                    Weight = random.Next(1, 11),
                    Value = random.Next(1, 11)
                });
            }

            return items;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.Append($"Item {item.Id}: Weight = {item.Weight}, Value = {item.Value}");
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public Result Solution(int capacity)
        {
            List<Item> tempItems = new List<Item>();
            List<int> itemIdList = new List<int>();

            Items.Sort((x, y) => {
                double ratioX = (double)x.Value / (double)x.Weight;
                double ratioY = (double)y.Value / (double)y.Weight;
                return ratioY.CompareTo(ratioX);
            });

            int currentWeight = 0;
            int sumValue = 0;

            foreach (Item item in Items)
            {
                if (currentWeight + item.Weight <= capacity)
                {
                    tempItems.Add(item);
                    currentWeight += item.Weight;
                    sumValue += item.Value;
                    itemIdList.Add(item.Id);
                }

            }

            Result result = new Result
            {
                ItemIdList = itemIdList,
                SumValue = sumValue,
                SumWeight = currentWeight
            };

            return result;
        }
    }

    internal class Result
    {
        public List<int> ItemIdList { get; set; }
        public int SumValue { get; set; }
        public int SumWeight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Items in backpack:");
            foreach (var number in ItemIdList)
            {
                sb.Append(number + " ");
            }
            sb.AppendLine();
            sb.AppendLine($"Sum value: {SumValue}");
            sb.AppendLine($"Sum weight: {SumWeight}");
            return sb.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed:");
            int seed = int.Parse(Console.ReadLine());

            ItemSet ItemSet = new ItemSet(n, seed);
            Console.WriteLine(ItemSet.ToString());
            Console.WriteLine("Enter the capacity:");
            int capacity = int.Parse(Console.ReadLine());

            Result result = ItemSet.Solution(capacity);
            Console.WriteLine(result.ToString());
         

        }
    }
}

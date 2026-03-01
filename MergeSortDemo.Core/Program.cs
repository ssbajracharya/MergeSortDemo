using MergeSortDemo.Core;

namespace MergeSortDemo.Core
{
	public class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Enter numbers separated by spaces or commas:");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No Input provided");
                return;
            }

            string[] tokens = input.Split([' ', ','], StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[tokens.Length];

            for(int i = 0; i < tokens.Length; i++)
            {
                bool success = int.TryParse(tokens[i], out numbers[i]);
                if(!success)
                {
                    Console.WriteLine($"Invalid entry: {tokens[i]}.");
                    return;
                }
            }

            MergeSorter Sorter = new MergeSorter();

            int[] sortedArray = Sorter.Sort(numbers);

			Console.WriteLine("Sorted array:");
			Console.WriteLine($"[{string.Join(", ", sortedArray)}]");
		}
	}
}

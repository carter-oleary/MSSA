namespace ChallengeLab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Challenge Lab 11.1----");
            int[] nums = [2, 0, 2, 1, 1, 0];
            Console.WriteLine($"Original Array: [ {string.Join(", ", nums)} ]");
            SortColors(nums);
            Console.WriteLine($"Sorted Array: [ {string.Join(", ", nums)} ]");

            Console.WriteLine("\n----Challenge Lab 11.1----");
            string input1 = "nlaebolko";
            string input2 = "loonbalxballpoon";
            string input3 = "banana";
            Console.WriteLine($"String {input1} has {MaxNumberOfBalloons(input1)} instances of the word \'balloon\'");
            Console.WriteLine($"String {input2} has {MaxNumberOfBalloons(input2)} instances of the word \'balloon\'");
            Console.WriteLine($"String {input3} has {MaxNumberOfBalloons(input3)} instances of the word \'balloon\'");
        }

        public static void SortColors(int[] nums)
        {
            if (nums.Length <= 1) return;
            int[] count = new int[3]; // Track instances of 3 colors
            for(int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++; // Count occurrences of each color (0, 1, 2)
            }
            int prevSum = 0; // To keep track of the cumulative count of colors
            int pointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= count[pointer] + prevSum)
                {
                    prevSum += count[pointer];
                    pointer++;
                } 
                // Bypass colors with no instances
                while (count[pointer] == 0)
                {
                    pointer++;
                }

                nums[i] = pointer;
            }
        }

        public static int MaxNumberOfBalloons(string text)
        {
            var balloonCount = new Dictionary<char, int> { {'b', 1}, {'a', 1}, {'l', 2}, {'o', 2}, {'n', 1} };
            var stringCount = new Dictionary<char, int> { { 'b', 0 }, { 'a', 0 }, { 'l', 0 }, { 'o', 0 }, { 'n', 0 } };
            int maxNum = text.Length;
            foreach (var c in text) // Count characters in the input string
            {
                if(stringCount.ContainsKey(c))
                {
                    stringCount[c]++;
                }
            }
            // Calculate the maximum number of "balloon" words that can be formed
            foreach (char c in balloonCount.Keys)
            {
                if (stringCount[c] < balloonCount[c])
                {
                    return 0; // If any required character is less than needed, return 0
                }
                maxNum = Math.Min(maxNum, stringCount[c] / balloonCount[c]);
            }
           
            return maxNum; 
        }
    }
}

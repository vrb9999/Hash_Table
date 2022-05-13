using System;

namespace Find_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
			MapNode<String, int> myHashMap = new MapNode<String, int>(5);
			String sentence = "to be or not to be";
			String[] words = sentence.ToLower().Split(" ");
			foreach (String word in words)
			{
				Console.WriteLine(word + " --> Added to HashTable");
				int value = myHashMap.Get(word);
				if (value == 0)
					value = 1;
				else
					value = value + 1;
				myHashMap.Add(word, value);
			}
			int frequency = myHashMap.Get("be");
			Console.WriteLine("Frequency of word -> be -> " +frequency);
		}
    }
}

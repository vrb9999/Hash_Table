using System;

namespace Find_Frequency_In_Paragraph
{
    class Program
    {
        static void Main(string[] args)
        {
            MapNode<String, int> myHashMap = new MapNode<String, int>(5);
            String sentence = "Paranoids are not paranoid because they are paranoid but because they " +
                "keep putting themselves deliberately into paranoid avoidable situations";
            String[] words = sentence.ToLower().Split(" ");
            foreach (String word in words)
            {
                Console.WriteLine(word + " -->Added to HashTable");
                int value = myHashMap.Get(word);
                if (value == 0)
                    value = 1;
                else
                    value = value + 1;
                myHashMap.Add(word, value);
            }
            int frequency = myHashMap.Get("paranoid");
            Console.WriteLine("Frequency of word -->paranoid --> " + frequency);
        }
    }
}

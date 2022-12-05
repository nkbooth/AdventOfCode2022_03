namespace AdventOfCode_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPriority = 0;
            int authPriority = 0;
            string input = "input.txt";
            string[] lines = System.IO.File.ReadAllLines(input);

            List<Rucksack> rucksacks = new List<Rucksack>();

            foreach (string line in lines)
            {
                Rucksack rucksack = new Rucksack();
                rucksack.RucksackContents = line;
                rucksacks.Add(rucksack);
            }
            
            Console.WriteLine(string.Format("Loaded {0} rucksacks", rucksacks.Count));

            foreach (Rucksack rucksack in rucksacks)
            {
                int rucksackPriority = 0;
                foreach (char content in rucksack.rucksackContentsA)
                {
                    if (rucksack.rucksackContentsB.Contains(content))
                    {
                        rucksackPriority += rucksack.rucksackContentValue(content);
                        break;
                    }
                }
                totalPriority += rucksackPriority;
            }

            Console.WriteLine(string.Format("Total priority: {0}", totalPriority));

            int count = 0;
            while (count < rucksacks.Count)
            {
                foreach(char content in rucksacks[count].RucksackContents)
                {
                    if (rucksacks[count+1].RucksackContents.Contains(content) && rucksacks[count+2].RucksackContents.Contains(content))
                    {
                        authPriority += rucksacks[count].rucksackContentValue(content);
                        break;
                    }
                }
                count += 3;
            }
            Console.WriteLine(string.Format("Auth priority: {0}", authPriority));
        }
    }
}
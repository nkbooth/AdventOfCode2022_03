namespace AdventOfCode_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPriority = 0;
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

            int count = 0;
            foreach (Rucksack rucksack in rucksacks)
            {
                count++;
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
        }
    }
}
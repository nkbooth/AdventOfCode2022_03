using System;

namespace AdventOfCode_03
{
    class Rucksack
    {
        public string RucksackContents {get {return rucksackContents;} set {rucksackContents = value;}}
        private string? rucksackContents {get; set;}
        
        public string rucksackContentsA {
            get 
            {
                return rucksackContents.Substring(0, rucksackContents.Length / 2);
            }
        }

        public string rucksackContentsB {
            get 
            {
                int halfLength = rucksackContents.Length / 2;
                return rucksackContents[^halfLength..];
            }
        }

        public int rucksackContentValue(char content)
        {
            if (char.IsUpper(content))
            {
                return (int)content - 38;
            }
            else
            {
                return (int)content - 96;
            }
        }
    }
}
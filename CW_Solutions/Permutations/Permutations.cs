namespace Permutations
{
    /*
     * 
     * Task:
     * In this kata you have to create all permutations 
     * of a non empty input string and remove duplicates,
     * if present. This means, you have to shuffle all letters
     * from the input in all possible orders.
     * 
     */
    public class Permutations
    {
        public static List<string> SinglePermutations(string s)
        {
            if(s.Length == 1) return new List<string> { s };
            List<string> allPermitations = new List<string>();
            for(int i = 0; i < s.Length; i++)
            {
                allPermitations.AddRange(Shuffle(s[i],
                    String.Concat(s.Take(i))+ String.Concat(s.Skip(i + 1)) ));
            }
            return allPermitations.Distinct().ToList();
        }
        public static List<string> Shuffle(char first, string s)
        {
            if(s.Length == 1)
            {
                return new List<string>() { first + s };
            }
            List<string> allCombinations = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                foreach (string str in Shuffle(s[i],
                                    String.Concat(s.Take(i))
                                    + String.Concat(s.Skip(i + 1))))
                {
                    allCombinations.Add(first + str);
                }
            }
            return allCombinations;
        }
    }
}
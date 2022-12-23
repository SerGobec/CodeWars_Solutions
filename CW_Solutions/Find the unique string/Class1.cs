namespace Find_the_unique_string
{
    public class Kata
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).First(el => el.Count() == 1).Key;
        }
    }
}
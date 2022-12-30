using System.Text;

namespace BackspacesinstringLibrary
{
    // https://www.codewars.com/kata/5727bb0fe81185ae62000ae3/csharp
    public class Kata
    {
        public static string CleanString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c == '#')
                {
                    if (sb.Length > 0) sb.Length = sb.Length - 1;
                    continue;
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
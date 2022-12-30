using System.Text;

namespace AddingBigNumberLibrary
{
    public class Kata
    {
        public static string Add(string a, string b)
        {
            int minlength = Math.Min(a.Length, b.Length);
            string leftPart = new string(a.Take(a.Length - minlength).Concat(b.Take(b.Length - minlength)).ToArray());
            int counter = 0;
            StringBuilder sb = new StringBuilder();
            for(int i = 1;i <= minlength;i++)
            {
                int sum = int.Parse(a[^i] + "") + int.Parse(b[^i] + "");
                sb.Insert(0,(sum + counter) % 10);
                counter = (sum + counter) / 10;
            }
            for(int i = 1; i <= leftPart.Length ; i++)
            {
                int sum = int.Parse(leftPart[^i] + "");
                sb.Insert(0, (sum + counter) % 10);
                counter = (sum + counter) / 10;
            }
            if (counter != 0) sb.Insert(0, counter);
            return sb.ToString();
        }
    }
}
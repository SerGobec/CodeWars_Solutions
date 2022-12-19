using System.Text;

namespace NotverysecureLybrary
{
    public class Kata
    {
        public static bool Alphanumeric(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            return Encoding.ASCII.GetBytes(str).All(el => (el > 64 && el < 91) || (el > 47 && el < 58) || (el > 96 && el < 123));
        }
    }
}
namespace Strip_Comments
{
    public class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            return string.Join("\n",
                 text.Split("\n").Select(line => 
                 { return line.Split(commentSymbols, StringSplitOptions.None).FirstOrDefault().TrimEnd(); }));
        }
    }
}
namespace RequiredDataI
{
    public class Kata
    {
        public static object[] CountSel(int[] lst)
        {
            return new object[] {
                lst.Count(),
                lst.Distinct().Count(),
                lst.GroupBy(el => el).Where(el => el.Count() == 1).Count(),
                new object[]
                {
                    lst.GroupBy(el => el).Where(el => el.Count() == lst.GroupBy(el => el).Max(el => el.Count()) ).Select(el => el.Key).OrderBy(el=> el).ToArray(),
                    lst.GroupBy(el => el).Max(el => el.Count())
                }
             };
        }
    }
}
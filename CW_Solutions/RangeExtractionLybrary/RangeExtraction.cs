using System.Text;

namespace RangeExtractionLybrary
{
    /* TASK
     * A format for expressing an ordered list of integers is to use a comma separated list of either

        individual integers
        or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
        Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

        Example:

        solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
        // returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
     */
    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            if (args.Length == 0) return "";
            StringBuilder sb = new StringBuilder();
            List<Sequence> list = new List<Sequence>();

            foreach (int arg in args)
            {
                if (list.FirstOrDefault() != null && list.LastOrDefault().Max + 1 == arg)
                {
                    list.LastOrDefault().Max = arg;
                }
                else list.Add(new Sequence() { Min = arg, Max = arg });
            }

            foreach (Sequence seq in list) sb.Append(seq.ToString() + ",");
            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        private class Sequence
        {
            public int Min { get; set; }
            public int Max { get; set; }
            public override string ToString()
            {
                if (Min == Max) return Min.ToString();
                if (Max == Min + 1) return Min + "," + Max;
                return Min + "-" + Max;
            }
        }
    }
}
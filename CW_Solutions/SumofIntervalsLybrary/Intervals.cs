namespace SumofIntervalsLybrary
{
    public class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            IntervalStorer storer = new IntervalStorer();
            foreach(var interval in intervals.OrderBy(el => el.Item1))
            {
                storer.AddInterval(interval);
            }
            return storer.GetSumOfIntervals();
        }

        class IntervalStorer
        {
            List<(int,int)> values= new List<(int,int)> ();
            public void AddInterval((int,int) interval)
            {
                var val = values.FirstOrDefault(el => el.Item1 <= interval.Item1 && el.Item2 >= interval.Item1);
                if(val == default((int,int)))
                {
                    values.Add(interval);
                } else
                {
                    values.Remove(val);
                    val.Item2 = Math.Max(val.Item2, interval.Item2);
                    values.Add(val);
                }
                
            }

            public int GetSumOfIntervals()
            {
                return values.Sum(el => el.Item2 - el.Item1);
            }
        }

    }
}
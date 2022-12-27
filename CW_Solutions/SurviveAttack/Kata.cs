namespace SurviveAttack
{
    public static class Kata
    {
        public static bool HasSurvived(int[] attackers, int[] defenders)
        {
            Array.Resize(ref attackers, Math.Max(attackers.Length, defenders.Length));
            Array.Resize(ref defenders, Math.Max(attackers.Length, defenders.Length));
            int result = attackers.Zip(defenders).Select(el => el.First.CompareTo(el.Second)).Sum(el => el);
            if(result == 0) return defenders.Sum() >= attackers.Sum();
            return result < 0;
        }
    }
}
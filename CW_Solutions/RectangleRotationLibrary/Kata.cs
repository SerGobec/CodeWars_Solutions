namespace RectangleRotationLibrary
{
    public class Kata
    {
        public int RectangleRotation(int a, int b)
        {
            double half_a = (double)a / 2;
            double half_b = (double)b / 2;
            double sqrttwo = Math.Sqrt(2);
            int sum = ((int)(half_b / sqrttwo) * 2 + 1) * ((int)(half_a / sqrttwo) * 2 + 1);
            sum += ((int)((half_b - 0.5 * sqrttwo) / sqrttwo + 1) * 2) * ((int)((half_a - 0.5 * sqrttwo) / sqrttwo + 1) * 2);
            return sum;
        }
    }
}
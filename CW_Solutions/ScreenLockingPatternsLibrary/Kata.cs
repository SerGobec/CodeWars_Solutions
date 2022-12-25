namespace ScreenLockingPatternsLibrary
{
    // Kata: https://www.codewars.com/kata/585894545a8a07255e0002f1/train/csharp
    // 
    // <3
    public static class Kata
    {
        private static Dictionary<char, int> CharIndexPairs = new Dictionary<char, int>
        {
            { 'A', 0},
            { 'B', 1},
            { 'C', 2},
            { 'D', 3},
            { 'E', 4},
            { 'F', 5},
            { 'G', 6},
            { 'H', 7},
            { 'I', 8},
        };

        public static int CountPatternsFrom(char firstDot, int length)
        {
            if (length > 9 || length < 1) return 0;
            int[] checker = new int[9];
            return CountAvailableWays(CharIndexPairs[firstDot], checker, length);
        }

        private static int CountAvailableWays(int verticeIndex, in int[] usedPoints, int length)
        {
            if (length == 1) return 1;
            usedPoints[verticeIndex] = 1;
            int Sum = 0;
            for(int index = 0; index < 9; index++)
            {
                if (usedPoints[index] == 1) continue;
                if(usedPoints[ ConditionsToConnect[verticeIndex,index]] == 1)
                {
                    Sum += CountAvailableWays(index, (int[])usedPoints.Clone(), length - 1);
                }
            }
            return Sum;
        }
        
        // This array tells us which one vertice should be activated, for get acces to required another one vertice
        private static int[,] ConditionsToConnect = new int[9,9] {
            {0, 0, 1, 0, 0, 0, 3, 0, 4},
            {1, 1, 1, 1, 1, 1, 1, 4, 1},
            {1, 2, 2, 2, 2, 2, 4, 2, 5},
            {3, 3, 3, 3, 3, 4, 3, 3, 3},
            {4, 4, 4, 4, 4, 4, 4, 4 ,4},
            {5, 5, 5, 4, 5, 5, 5, 5 ,5},
            {3, 6, 4, 6, 6, 6, 6, 6, 7},
            {7, 4, 7, 7, 7, 7, 7, 7, 7},
            {4, 8, 5, 8, 8, 8, 7, 8, 8}
        };
    }
}
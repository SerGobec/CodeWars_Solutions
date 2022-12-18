namespace BattleshipfieldvalidatorLybrary
{
    public class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            int[,] clone = new int[field.GetLength(0),field.GetLength(1)];
            for(int i = 0;i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i,j] == 1)
                    {

                    }
                }
            }
            return true;
        }


        
    }
}
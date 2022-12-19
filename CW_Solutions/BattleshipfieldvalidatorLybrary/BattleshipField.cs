namespace BattleshipfieldvalidatorLybrary
{
    public class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            Battleground btlgr = new Battleground(field);
            return btlgr.BattlefieldIsValid();
        }

        public class Battleground
        {
            int[,] _batlefield;
            List<Ship> Ships= new List<Ship>();
            public Battleground(int[,] battlegroundfield) { this._batlefield= battlegroundfield; }

            public bool BattlefieldIsValid()
            {
                int[,] clone = new int[_batlefield.GetLength(0), _batlefield.GetLength(1)];
                for(int y = 0;y < clone.GetLength(0); y++)
                {
                    for(int x = 0;x < clone.GetLength(1); x++)
                    {
                        if (!isFreeCell(y, x) && clone[y,x] != 1)
                        {
                            Ship? ship = null; 
                            ship = FindHorisontalShip(y,x) ?? ship;
                            ship = FindVerticalShip(y, x) ?? ship;
                            if (ship == null)
                            {
                                return false;
                            }
                            this.Ships.Add(ship);
                            foreach(Cell cell in ship.Cells)
                            {
                                clone[cell.Y, cell.X] = 1;
                            }
                        }
                    }
                }

                if(Ships.Count == 10 && 
                    Ships.Where(el => el.Size == 1).Count() == 4 &&
                    Ships.Where(el => el.Size == 2).Count() == 3 &&
                    Ships.Where(el => el.Size == 3).Count() == 2 &&
                    Ships.Where(el => el.Size == 4).Count() == 1)
                {
                    return true;
                }
                return false;

                bool isFreeCell(int y, int x)
                {
                    if(x < 0 || y < 0 || x > 9 || y > 9) return true;
                    return _batlefield[y, x] == 0;
                }

                Ship FindHorisontalShip(int y,int x)
                {
                    Ship ship = new Ship();
                    while (!isFreeCell(y,x)){
                        if (!isFreeCell(y + 1, x + 1) ||
                            !isFreeCell(y + 1, x - 1) ||
                            !isFreeCell(y - 1, x + 1) ||
                            !isFreeCell(y - 1, x - 1)
                            ) return null;
                        if (!isFreeCell(y + 1, x) || !isFreeCell(y - 1, x)) return null;
                        ship.AddCell(new Cell { X = x, Y = y });
                        x++;
                    };
                    return ship;
                }

                Ship FindVerticalShip(int y,int x)
                {
                    Ship ship = new Ship();
                    while (!isFreeCell(y, x))
                    {
                        if (!isFreeCell(y + 1, x + 1) ||
                            !isFreeCell(y + 1, x - 1) ||
                            !isFreeCell(y - 1, x + 1) ||
                            !isFreeCell(y - 1, x - 1)
                            ) return null;
                        if (!isFreeCell(y, x + 1) || !isFreeCell(y, x + 1)) return null;
                        ship.AddCell(new Cell { X = x, Y = y });
                        y++;
                    };
                    return ship;
                }
            }

            private class Ship
            {
                public byte Size { get; private set; }
                public List<Cell> Cells = new List<Cell> { };
                public bool AddCell(Cell cell)
                {
                    this.Cells.Add(cell);
                    Size++;
                    return true; // error adding cell
                }
            }
            private struct Cell
            {
                public int X; 
                public int Y;
            }
        } 
    }
}
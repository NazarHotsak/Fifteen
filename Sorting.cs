using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    internal class Sorting
    {
        int positionEmptyBtnX;
        int positionEmptyBtnY;

        public void SortMapOfBtn(int[,] map)
        {
            Random rnd = new Random();
            positionEmptyBtnX = map.GetLength(1) - 1;
            positionEmptyBtnY = map.GetLength(0) - 1;

            for (int sortintIterations = 0; sortintIterations < 300; sortintIterations++)
            {
                switch(rnd.Next(0, 4))
                {
                    case 0:
                        btnMovesTop(map);
                        break;
                    case 1:
                        btnMovesBottom(map);
                        break;
                    case 2:
                        btnMovesLeft(map);
                        break;
                    case 3:
                        btnMovesRight(map);
                        break;
                }
            }
        }
        
        private void btnMovesTop(int[,] map)
        {
            if (positionEmptyBtnY - 1 >= 0)
            {
                Method.Reverse(map, positionEmptyBtnY, positionEmptyBtnX, positionEmptyBtnY - 1, positionEmptyBtnX);
                positionEmptyBtnY--;
            }
        }

        private void btnMovesBottom(int[,] map)
        {
            if (positionEmptyBtnY + 1 <= map.GetLength(0) - 1)
            {
                Method.Reverse(map, positionEmptyBtnY, positionEmptyBtnX, positionEmptyBtnY + 1, positionEmptyBtnX);
                positionEmptyBtnY++;
            }
        }

        private void btnMovesLeft(int[,] map)
        {
            if (positionEmptyBtnX - 1 >= 0)
            {
                Method.Reverse(map, positionEmptyBtnY, positionEmptyBtnX, positionEmptyBtnY, positionEmptyBtnX - 1);
                positionEmptyBtnX--;
            }
        }

        private void btnMovesRight(int[,] map)
        {
            if (positionEmptyBtnX + 1 <= map.GetLength(1) - 1)
            {
                Method.Reverse(map, positionEmptyBtnY, positionEmptyBtnX, positionEmptyBtnY, positionEmptyBtnX + 1);
                positionEmptyBtnX++;
            }
        }
    }
}

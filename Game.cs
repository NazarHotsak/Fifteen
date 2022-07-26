using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    internal class Game
    {
        private const byte _emptyButton = 0;

        public bool doesButtonsMove(int[,] map, int ButtonY, int ButtonX)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                if (map[ButtonY,x] == _emptyButton)
                {
                    if (ButtonX < x)
                    {
                        ButtonMovesFromRightToLeft(map, ButtonX, x, ButtonY);
                    }
                    else
                    {
                        ButtonMovesFromLeftToRight(map, ButtonX, x, ButtonY);
                    }
                    return true;
                }
            }

            for (int y = 0; y < map.GetLength(0); y++)
            {
                if (map[y, ButtonX] == _emptyButton)
                {
                    if (ButtonY < y)
                    {
                        ButtonMovesFromBottomToTop(map, ButtonY, y, ButtonX);
                    }
                    else
                    {
                        ButtonMovesFromTopToBottom(map, ButtonY, y, ButtonX);
                    }
                    return true;
                }
            }

            return false;
        }

        private void ButtonMovesFromRightToLeft(int[,] map, int ButtonX, int x, int ButtonY)
        {
            for (int numberOfPermutations = x - ButtonX; numberOfPermutations > 0; numberOfPermutations--)
            {
                Method.Reverse(map, ButtonY, x, ButtonY, x - 1);
                x--;
            }
        }

        private void ButtonMovesFromLeftToRight(int[,] map, int ButtonX, int x, int ButtonY)
        {
            for (int numberOfPermutations = ButtonX - x; numberOfPermutations > 0; numberOfPermutations--)
            {
                Method.Reverse(map, ButtonY, x, ButtonY, x + 1);
                x++;
            }
        }

        private void ButtonMovesFromTopToBottom(int[,] map, int ButtonY, int y, int ButtonX)
        {
            for (int numberOfPermutations = ButtonY - y; numberOfPermutations > 0; numberOfPermutations--)
            {
                Method.Reverse(map, y, ButtonX, y + 1, ButtonX);
                y++;
            }
        }

        private void ButtonMovesFromBottomToTop(int[,] map, int ButtonY, int y, int ButtonX)
        {
            for (int numberOfPermutations = y - ButtonY; numberOfPermutations > 0; numberOfPermutations--)
            {
                Method.Reverse(map, y, ButtonX, y - 1, ButtonX);
                y--;
            }
        }
    }
}











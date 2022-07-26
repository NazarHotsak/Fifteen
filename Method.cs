using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    static class Method
    {
        static public void Reverse(int[,] map, int buttonOneY, int buttonOneX, int buttonTwoY, int buttonTwoX)
        {
            int caseButton;
            caseButton = map[buttonOneY, buttonOneX];
            map[buttonOneY, buttonOneX] = map[buttonTwoY, buttonTwoX];
            map[buttonTwoY, buttonTwoX] = caseButton;
        }
    }
}

﻿namespace WF_4_Puzzle15;

public static class Utils
{
    public static string GetMovesWord(uint moves)
    {
        uint afterLast = moves % 100 / 10;
        uint last = moves % 10;

        if (afterLast == 1 || last == 0 || (last >= 5 && last <= 9)) return "moves";
        if (last >= 2 && last <= 4) return "move";
        return "move"; // if (last == 1)
    }
}

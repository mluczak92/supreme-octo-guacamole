using System.Globalization;

namespace adventofcode2022._2022
{
    internal static class _09
    {
        //static string args = "R 1\r\nD 1\r\nU 1\r\nR 2\r\nL 2\r\nU 2\r\nD 1\r\nL 2\r\nR 1\r\nL 1\r\nU 2\r\nL 2\r\nR 2\r\nU 1\r\nD 2\r\nR 1\r\nD 1\r\nU 1\r\nL 1\r\nR 1\r\nL 2\r\nD 2\r\nR 1\r\nD 2\r\nL 1\r\nR 1\r\nD 2\r\nL 2\r\nD 1\r\nL 2\r\nD 1\r\nU 1\r\nL 2\r\nU 2\r\nR 2\r\nD 1\r\nL 1\r\nD 1\r\nL 2\r\nR 2\r\nU 1\r\nD 2\r\nL 2\r\nR 1\r\nL 2\r\nU 1\r\nL 2\r\nR 2\r\nD 1\r\nU 1\r\nL 1\r\nU 1\r\nR 1\r\nU 1\r\nR 1\r\nU 1\r\nL 2\r\nD 2\r\nU 1\r\nD 1\r\nL 1\r\nD 2\r\nR 2\r\nD 1\r\nL 1\r\nR 2\r\nD 1\r\nR 2\r\nU 1\r\nL 2\r\nR 1\r\nD 2\r\nR 1\r\nL 2\r\nD 2\r\nU 2\r\nD 2\r\nR 1\r\nD 1\r\nL 1\r\nD 2\r\nR 2\r\nD 2\r\nL 1\r\nD 2\r\nU 1\r\nD 1\r\nL 1\r\nU 1\r\nD 2\r\nL 2\r\nR 2\r\nL 1\r\nR 2\r\nU 2\r\nD 1\r\nU 1\r\nR 1\r\nU 1\r\nR 1\r\nD 2\r\nL 1\r\nU 2\r\nR 1\r\nU 1\r\nR 1\r\nD 2\r\nR 2\r\nU 1\r\nL 2\r\nR 2\r\nU 2\r\nR 3\r\nL 2\r\nR 2\r\nL 2\r\nD 3\r\nR 3\r\nD 1\r\nU 3\r\nL 1\r\nU 1\r\nD 2\r\nL 1\r\nD 1\r\nL 2\r\nD 2\r\nL 1\r\nD 2\r\nU 2\r\nR 1\r\nL 3\r\nU 3\r\nR 2\r\nL 3\r\nR 3\r\nD 3\r\nL 3\r\nR 1\r\nL 3\r\nD 1\r\nR 1\r\nL 1\r\nU 2\r\nD 3\r\nR 2\r\nU 1\r\nL 3\r\nU 3\r\nL 2\r\nD 3\r\nL 2\r\nU 1\r\nL 1\r\nD 1\r\nU 1\r\nD 2\r\nR 1\r\nL 3\r\nR 3\r\nL 1\r\nD 3\r\nU 3\r\nR 2\r\nL 3\r\nR 3\r\nD 2\r\nU 1\r\nR 1\r\nU 3\r\nR 2\r\nL 2\r\nD 3\r\nR 2\r\nL 1\r\nU 3\r\nR 3\r\nD 3\r\nL 3\r\nD 2\r\nR 2\r\nD 2\r\nU 3\r\nL 3\r\nR 1\r\nU 2\r\nD 3\r\nL 2\r\nR 3\r\nD 2\r\nL 2\r\nU 1\r\nD 2\r\nL 3\r\nU 1\r\nD 2\r\nU 1\r\nD 3\r\nR 1\r\nL 3\r\nR 3\r\nD 2\r\nU 1\r\nD 1\r\nU 2\r\nL 1\r\nR 2\r\nU 3\r\nL 2\r\nR 2\r\nD 1\r\nL 1\r\nD 1\r\nR 3\r\nU 2\r\nL 2\r\nD 3\r\nU 2\r\nR 2\r\nL 1\r\nU 1\r\nR 2\r\nU 3\r\nD 1\r\nR 4\r\nD 2\r\nL 4\r\nD 1\r\nL 2\r\nR 1\r\nL 2\r\nD 2\r\nU 2\r\nD 2\r\nR 3\r\nL 2\r\nD 2\r\nL 4\r\nR 4\r\nD 4\r\nL 2\r\nU 4\r\nL 1\r\nR 4\r\nU 4\r\nD 1\r\nL 4\r\nU 2\r\nL 3\r\nD 1\r\nL 3\r\nD 4\r\nU 2\r\nD 2\r\nR 1\r\nL 4\r\nD 1\r\nU 3\r\nL 3\r\nU 2\r\nR 4\r\nL 3\r\nD 3\r\nU 1\r\nL 2\r\nR 3\r\nL 2\r\nR 1\r\nD 2\r\nL 1\r\nU 3\r\nD 1\r\nL 3\r\nU 2\r\nR 2\r\nL 3\r\nD 1\r\nU 4\r\nR 1\r\nU 3\r\nR 1\r\nD 2\r\nR 3\r\nL 2\r\nU 1\r\nD 3\r\nL 4\r\nU 3\r\nL 3\r\nR 1\r\nD 2\r\nR 1\r\nL 1\r\nR 2\r\nD 4\r\nU 3\r\nL 4\r\nD 4\r\nR 3\r\nD 3\r\nU 3\r\nD 3\r\nL 2\r\nR 3\r\nL 4\r\nU 4\r\nD 1\r\nL 3\r\nU 4\r\nR 2\r\nD 3\r\nL 3\r\nR 1\r\nL 1\r\nR 1\r\nL 3\r\nD 3\r\nL 4\r\nR 4\r\nD 3\r\nU 4\r\nL 1\r\nR 2\r\nD 3\r\nU 1\r\nR 1\r\nL 3\r\nR 2\r\nD 3\r\nU 3\r\nR 4\r\nU 2\r\nL 1\r\nU 2\r\nR 2\r\nD 2\r\nR 1\r\nU 3\r\nR 5\r\nL 4\r\nD 2\r\nR 3\r\nL 3\r\nU 4\r\nL 2\r\nU 4\r\nR 1\r\nD 4\r\nR 2\r\nU 5\r\nL 4\r\nR 3\r\nU 5\r\nL 5\r\nU 2\r\nD 5\r\nR 1\r\nD 3\r\nL 5\r\nR 5\r\nL 4\r\nR 3\r\nL 5\r\nU 5\r\nD 2\r\nL 1\r\nU 4\r\nL 2\r\nR 3\r\nD 4\r\nL 3\r\nU 3\r\nL 3\r\nD 1\r\nU 5\r\nD 5\r\nR 1\r\nD 1\r\nL 1\r\nU 4\r\nL 1\r\nU 4\r\nL 1\r\nR 5\r\nD 4\r\nU 4\r\nD 3\r\nL 5\r\nD 1\r\nU 4\r\nR 2\r\nU 2\r\nD 3\r\nR 5\r\nL 3\r\nR 4\r\nD 1\r\nR 2\r\nL 2\r\nU 2\r\nL 3\r\nR 2\r\nL 5\r\nD 5\r\nL 1\r\nU 2\r\nD 5\r\nL 3\r\nU 1\r\nR 2\r\nL 3\r\nU 4\r\nD 5\r\nU 1\r\nR 5\r\nD 4\r\nR 5\r\nU 2\r\nD 4\r\nL 3\r\nR 5\r\nD 2\r\nU 2\r\nL 5\r\nR 1\r\nD 1\r\nR 4\r\nL 3\r\nD 1\r\nR 1\r\nU 1\r\nL 2\r\nD 5\r\nR 4\r\nL 5\r\nU 4\r\nR 4\r\nU 4\r\nD 2\r\nR 1\r\nU 4\r\nL 4\r\nR 4\r\nL 5\r\nD 6\r\nR 1\r\nL 1\r\nD 5\r\nR 4\r\nL 6\r\nD 5\r\nL 6\r\nU 3\r\nD 2\r\nR 6\r\nL 1\r\nR 3\r\nD 5\r\nL 4\r\nR 4\r\nU 4\r\nL 2\r\nU 1\r\nD 3\r\nR 2\r\nU 1\r\nD 2\r\nL 2\r\nR 3\r\nD 6\r\nR 3\r\nL 1\r\nD 3\r\nU 3\r\nL 3\r\nU 6\r\nR 1\r\nL 4\r\nD 3\r\nL 4\r\nU 2\r\nD 1\r\nU 5\r\nR 1\r\nD 1\r\nR 4\r\nD 2\r\nL 4\r\nR 2\r\nL 3\r\nR 6\r\nL 6\r\nR 6\r\nU 2\r\nR 4\r\nD 3\r\nU 6\r\nL 2\r\nR 6\r\nL 2\r\nD 4\r\nR 1\r\nU 4\r\nD 3\r\nR 2\r\nD 6\r\nL 4\r\nD 3\r\nU 5\r\nR 1\r\nD 6\r\nU 5\r\nR 1\r\nL 1\r\nR 3\r\nU 4\r\nL 2\r\nD 1\r\nR 4\r\nD 4\r\nU 4\r\nR 4\r\nL 1\r\nD 6\r\nU 3\r\nD 2\r\nU 2\r\nD 4\r\nR 1\r\nL 5\r\nR 5\r\nD 5\r\nR 5\r\nU 5\r\nL 6\r\nD 4\r\nU 5\r\nR 1\r\nL 5\r\nR 1\r\nU 3\r\nD 4\r\nL 6\r\nU 2\r\nD 1\r\nU 3\r\nR 6\r\nL 5\r\nU 6\r\nR 2\r\nL 2\r\nU 1\r\nL 2\r\nD 6\r\nU 4\r\nR 1\r\nD 4\r\nL 7\r\nD 6\r\nR 5\r\nL 4\r\nU 6\r\nR 4\r\nU 7\r\nR 4\r\nU 3\r\nL 7\r\nD 5\r\nR 6\r\nL 1\r\nR 5\r\nL 3\r\nR 4\r\nU 6\r\nR 1\r\nU 4\r\nL 7\r\nD 2\r\nR 4\r\nL 4\r\nR 5\r\nU 3\r\nD 1\r\nR 2\r\nD 1\r\nL 1\r\nR 4\r\nL 2\r\nU 7\r\nL 4\r\nR 7\r\nU 1\r\nD 3\r\nL 2\r\nD 6\r\nR 3\r\nD 1\r\nU 2\r\nL 5\r\nR 3\r\nD 2\r\nL 5\r\nU 1\r\nR 6\r\nD 3\r\nL 6\r\nU 6\r\nR 3\r\nL 5\r\nD 3\r\nU 3\r\nD 7\r\nU 4\r\nD 7\r\nR 4\r\nD 4\r\nL 4\r\nD 2\r\nR 4\r\nD 2\r\nR 2\r\nD 4\r\nU 5\r\nD 5\r\nL 6\r\nU 6\r\nL 1\r\nR 6\r\nU 3\r\nL 2\r\nU 3\r\nR 1\r\nU 4\r\nL 6\r\nR 5\r\nU 5\r\nD 2\r\nU 4\r\nR 1\r\nD 1\r\nR 2\r\nU 5\r\nL 4\r\nD 3\r\nR 2\r\nL 4\r\nU 2\r\nR 2\r\nL 7\r\nR 4\r\nU 3\r\nL 6\r\nR 3\r\nL 2\r\nU 6\r\nL 2\r\nR 2\r\nL 3\r\nD 2\r\nL 5\r\nR 2\r\nU 6\r\nD 6\r\nL 4\r\nD 5\r\nU 4\r\nR 2\r\nL 2\r\nU 3\r\nD 1\r\nR 8\r\nD 5\r\nL 8\r\nR 1\r\nU 7\r\nR 3\r\nU 4\r\nL 8\r\nD 3\r\nU 6\r\nD 8\r\nR 1\r\nD 4\r\nL 3\r\nD 8\r\nL 7\r\nD 5\r\nR 8\r\nL 5\r\nU 4\r\nD 3\r\nL 5\r\nR 3\r\nL 2\r\nR 5\r\nL 6\r\nR 3\r\nU 6\r\nR 6\r\nU 3\r\nD 1\r\nR 4\r\nU 5\r\nD 2\r\nL 1\r\nR 8\r\nU 3\r\nD 5\r\nR 6\r\nD 1\r\nL 3\r\nD 8\r\nR 1\r\nU 3\r\nL 3\r\nU 4\r\nD 2\r\nU 3\r\nL 8\r\nD 2\r\nL 3\r\nU 7\r\nL 2\r\nU 1\r\nD 1\r\nU 8\r\nR 6\r\nD 6\r\nR 3\r\nL 5\r\nU 6\r\nR 8\r\nL 1\r\nR 5\r\nL 7\r\nU 1\r\nR 1\r\nD 4\r\nL 8\r\nD 7\r\nR 6\r\nU 6\r\nD 5\r\nR 3\r\nU 3\r\nR 8\r\nD 4\r\nR 2\r\nU 6\r\nL 2\r\nD 2\r\nU 1\r\nL 1\r\nD 3\r\nL 4\r\nD 8\r\nR 6\r\nL 8\r\nD 7\r\nR 1\r\nL 2\r\nU 6\r\nR 7\r\nL 5\r\nR 3\r\nL 5\r\nU 3\r\nD 8\r\nU 5\r\nR 3\r\nU 7\r\nL 5\r\nD 8\r\nU 5\r\nR 1\r\nD 5\r\nL 4\r\nD 9\r\nR 5\r\nU 1\r\nD 9\r\nU 6\r\nL 2\r\nD 3\r\nL 7\r\nU 5\r\nD 3\r\nR 3\r\nU 5\r\nR 3\r\nD 2\r\nR 7\r\nU 5\r\nD 6\r\nR 1\r\nL 8\r\nU 6\r\nD 5\r\nL 2\r\nR 1\r\nL 9\r\nD 2\r\nR 3\r\nL 5\r\nR 2\r\nL 4\r\nU 7\r\nL 2\r\nD 6\r\nL 9\r\nR 9\r\nD 8\r\nU 6\r\nD 2\r\nU 7\r\nR 7\r\nD 5\r\nR 3\r\nU 9\r\nR 8\r\nD 5\r\nL 2\r\nD 3\r\nR 8\r\nU 3\r\nL 2\r\nU 8\r\nR 8\r\nL 1\r\nU 5\r\nR 4\r\nL 8\r\nU 9\r\nL 7\r\nU 9\r\nR 9\r\nD 6\r\nL 3\r\nR 9\r\nU 5\r\nL 3\r\nU 7\r\nL 5\r\nU 5\r\nR 1\r\nD 9\r\nU 5\r\nR 9\r\nD 5\r\nU 4\r\nD 8\r\nU 3\r\nL 4\r\nD 8\r\nL 3\r\nU 4\r\nD 5\r\nR 5\r\nL 1\r\nD 7\r\nU 4\r\nR 3\r\nL 6\r\nR 9\r\nU 5\r\nR 8\r\nD 9\r\nL 7\r\nU 4\r\nL 2\r\nD 2\r\nU 6\r\nR 5\r\nU 5\r\nL 8\r\nU 9\r\nL 2\r\nR 3\r\nD 9\r\nU 2\r\nL 6\r\nD 6\r\nL 3\r\nD 2\r\nU 7\r\nD 4\r\nL 6\r\nD 7\r\nL 8\r\nU 4\r\nD 2\r\nR 3\r\nU 3\r\nL 1\r\nR 5\r\nL 3\r\nD 2\r\nR 6\r\nD 8\r\nU 8\r\nR 10\r\nU 7\r\nL 6\r\nU 3\r\nD 6\r\nU 5\r\nL 3\r\nR 5\r\nU 8\r\nD 4\r\nL 8\r\nU 8\r\nL 9\r\nU 6\r\nL 6\r\nD 3\r\nU 1\r\nL 2\r\nU 1\r\nL 8\r\nR 9\r\nL 1\r\nR 9\r\nD 1\r\nR 4\r\nD 5\r\nL 5\r\nR 8\r\nU 3\r\nL 2\r\nU 7\r\nD 2\r\nU 2\r\nL 6\r\nD 4\r\nL 9\r\nU 10\r\nR 10\r\nU 2\r\nR 6\r\nL 4\r\nD 1\r\nR 10\r\nU 5\r\nL 1\r\nU 9\r\nL 10\r\nD 8\r\nR 1\r\nU 2\r\nL 1\r\nD 4\r\nU 2\r\nL 1\r\nU 5\r\nL 9\r\nD 1\r\nU 3\r\nL 10\r\nU 3\r\nD 8\r\nU 8\r\nD 10\r\nL 4\r\nD 9\r\nU 4\r\nL 8\r\nR 9\r\nD 6\r\nU 1\r\nL 1\r\nR 8\r\nL 2\r\nR 5\r\nU 7\r\nL 8\r\nR 2\r\nD 8\r\nL 6\r\nR 8\r\nL 7\r\nR 1\r\nD 4\r\nL 7\r\nR 9\r\nL 6\r\nU 2\r\nR 10\r\nU 1\r\nR 2\r\nU 4\r\nD 7\r\nU 6\r\nL 9\r\nR 6\r\nL 6\r\nR 5\r\nU 4\r\nL 4\r\nD 10\r\nL 10\r\nR 4\r\nL 10\r\nD 10\r\nR 11\r\nU 7\r\nD 5\r\nL 11\r\nD 8\r\nU 2\r\nR 2\r\nL 10\r\nR 9\r\nL 1\r\nU 4\r\nR 11\r\nL 7\r\nR 3\r\nD 5\r\nU 4\r\nL 10\r\nD 11\r\nR 4\r\nD 5\r\nL 8\r\nR 3\r\nD 2\r\nR 11\r\nU 9\r\nL 5\r\nR 1\r\nL 1\r\nU 9\r\nL 10\r\nU 11\r\nD 7\r\nL 3\r\nU 2\r\nD 6\r\nL 9\r\nD 2\r\nU 8\r\nL 6\r\nR 7\r\nU 6\r\nR 8\r\nD 11\r\nL 9\r\nD 7\r\nR 1\r\nD 7\r\nL 8\r\nR 11\r\nL 1\r\nR 7\r\nD 10\r\nR 10\r\nU 2\r\nL 7\r\nU 8\r\nL 2\r\nD 8\r\nU 7\r\nL 6\r\nR 8\r\nD 10\r\nL 11\r\nD 2\r\nU 4\r\nL 3\r\nU 8\r\nL 4\r\nD 10\r\nU 3\r\nD 6\r\nR 4\r\nL 8\r\nD 6\r\nU 11\r\nD 7\r\nL 9\r\nU 10\r\nD 10\r\nR 9\r\nD 8\r\nL 8\r\nU 10\r\nL 6\r\nD 2\r\nL 6\r\nR 11\r\nD 10\r\nR 1\r\nU 7\r\nR 7\r\nL 2\r\nR 6\r\nD 11\r\nR 1\r\nL 6\r\nR 8\r\nU 1\r\nR 3\r\nL 5\r\nU 7\r\nR 2\r\nL 4\r\nU 7\r\nL 4\r\nD 8\r\nR 10\r\nD 12\r\nU 8\r\nL 6\r\nU 2\r\nD 5\r\nU 8\r\nD 5\r\nU 10\r\nR 6\r\nL 7\r\nD 11\r\nL 8\r\nR 4\r\nL 5\r\nR 12\r\nL 3\r\nR 3\r\nD 5\r\nR 3\r\nL 9\r\nU 6\r\nL 3\r\nR 4\r\nD 12\r\nR 7\r\nL 10\r\nD 5\r\nL 6\r\nR 3\r\nU 9\r\nD 4\r\nU 5\r\nR 5\r\nL 12\r\nR 3\r\nU 12\r\nD 6\r\nL 3\r\nU 6\r\nR 10\r\nD 6\r\nU 11\r\nD 9\r\nU 1\r\nD 10\r\nR 4\r\nU 9\r\nD 10\r\nR 7\r\nU 3\r\nR 11\r\nU 5\r\nR 9\r\nL 11\r\nD 11\r\nU 11\r\nR 3\r\nL 10\r\nU 5\r\nL 9\r\nU 6\r\nD 10\r\nL 5\r\nD 11\r\nL 1\r\nR 8\r\nD 7\r\nL 7\r\nR 2\r\nL 5\r\nR 1\r\nD 12\r\nR 2\r\nD 6\r\nU 6\r\nD 3\r\nR 3\r\nL 1\r\nR 10\r\nL 9\r\nR 1\r\nD 10\r\nL 8\r\nD 4\r\nR 4\r\nU 6\r\nL 2\r\nR 4\r\nU 9\r\nL 6\r\nU 9\r\nD 9\r\nR 12\r\nL 8\r\nU 2\r\nD 1\r\nU 4\r\nR 12\r\nD 1\r\nR 10\r\nL 8\r\nU 1\r\nR 6\r\nD 5\r\nU 12\r\nR 10\r\nL 10\r\nD 7\r\nR 3\r\nU 1\r\nD 9\r\nR 1\r\nL 1\r\nD 11\r\nL 3\r\nD 9\r\nU 7\r\nR 4\r\nL 9\r\nR 13\r\nL 5\r\nD 3\r\nU 2\r\nL 7\r\nU 2\r\nR 10\r\nD 1\r\nL 1\r\nD 7\r\nR 4\r\nU 3\r\nR 8\r\nD 6\r\nL 7\r\nU 12\r\nL 6\r\nD 3\r\nR 10\r\nD 11\r\nL 11\r\nR 10\r\nU 6\r\nL 2\r\nU 4\r\nR 10\r\nD 6\r\nR 5\r\nU 2\r\nR 12\r\nD 8\r\nL 2\r\nD 13\r\nR 9\r\nL 5\r\nU 2\r\nL 12\r\nU 8\r\nD 6\r\nU 9\r\nR 11\r\nU 11\r\nL 7\r\nR 7\r\nU 7\r\nR 4\r\nU 9\r\nD 1\r\nR 6\r\nD 8\r\nL 6\r\nD 7\r\nR 1\r\nL 5\r\nR 8\r\nD 10\r\nL 8\r\nR 1\r\nU 9\r\nR 12\r\nD 10\r\nU 2\r\nL 9\r\nU 5\r\nR 4\r\nU 7\r\nD 7\r\nR 3\r\nU 7\r\nD 12\r\nU 2\r\nL 12\r\nU 1\r\nD 6\r\nR 13\r\nL 11\r\nR 12\r\nL 4\r\nU 6\r\nL 1\r\nU 8\r\nD 6\r\nU 9\r\nD 3\r\nL 7\r\nD 7\r\nR 12\r\nU 13\r\nR 13\r\nU 13\r\nD 13\r\nR 11\r\nL 2\r\nD 9\r\nR 2\r\nD 9\r\nU 11\r\nR 7\r\nU 8\r\nR 7\r\nL 8\r\nU 10\r\nR 4\r\nU 5\r\nD 14\r\nR 4\r\nD 4\r\nU 5\r\nR 6\r\nU 2\r\nD 11\r\nL 5\r\nU 10\r\nR 2\r\nL 1\r\nD 12\r\nU 7\r\nD 6\r\nL 4\r\nD 10\r\nU 11\r\nL 12\r\nD 8\r\nR 9\r\nL 6\r\nD 8\r\nR 11\r\nL 14\r\nD 13\r\nU 8\r\nD 12\r\nU 7\r\nD 10\r\nR 9\r\nL 1\r\nD 2\r\nU 3\r\nD 1\r\nR 2\r\nL 2\r\nD 13\r\nL 13\r\nR 4\r\nL 2\r\nR 3\r\nU 10\r\nR 3\r\nL 4\r\nR 8\r\nU 8\r\nR 5\r\nD 13\r\nL 2\r\nR 3\r\nU 2\r\nL 9\r\nR 1\r\nU 6\r\nD 5\r\nL 1\r\nR 4\r\nL 2\r\nU 2\r\nD 5\r\nR 13\r\nL 8\r\nD 13\r\nR 1\r\nU 14\r\nD 2\r\nL 11\r\nU 4\r\nD 12\r\nU 7\r\nR 8\r\nU 5\r\nR 6\r\nU 5\r\nD 2\r\nU 10\r\nD 1\r\nU 2\r\nD 3\r\nU 12\r\nL 10\r\nR 2\r\nD 12\r\nR 12\r\nL 5\r\nD 13\r\nR 1\r\nL 1\r\nU 1\r\nD 10\r\nR 13\r\nL 2\r\nD 4\r\nL 8\r\nU 9\r\nL 3\r\nR 5\r\nD 13\r\nL 4\r\nR 9\r\nU 4\r\nL 3\r\nD 2\r\nU 14\r\nR 1\r\nL 6\r\nD 8\r\nR 14\r\nU 8\r\nL 1\r\nD 5\r\nU 9\r\nL 15\r\nR 4\r\nL 15\r\nR 14\r\nU 6\r\nD 1\r\nL 15\r\nU 11\r\nR 5\r\nD 13\r\nL 1\r\nU 6\r\nR 7\r\nL 12\r\nD 3\r\nU 12\r\nR 11\r\nL 9\r\nR 2\r\nL 6\r\nR 9\r\nL 6\r\nR 4\r\nU 3\r\nL 13\r\nR 9\r\nL 3\r\nR 15\r\nD 8\r\nU 3\r\nD 13\r\nL 6\r\nD 14\r\nU 6\r\nL 3\r\nR 8\r\nU 15\r\nD 14\r\nU 2\r\nL 9\r\nU 3\r\nL 7\r\nU 15\r\nD 11\r\nU 13\r\nL 6\r\nD 9\r\nR 11\r\nL 7\r\nU 2\r\nL 15\r\nU 14\r\nL 4\r\nR 4\r\nU 11\r\nR 7\r\nU 8\r\nD 3\r\nL 15\r\nU 10\r\nR 2\r\nD 14\r\nU 13\r\nD 6\r\nU 1\r\nL 7\r\nR 7\r\nU 5\r\nL 4\r\nR 1\r\nL 12\r\nD 1\r\nR 15\r\nU 14\r\nD 13\r\nU 4\r\nD 10\r\nU 11\r\nL 14\r\nR 3\r\nL 3\r\nR 9\r\nL 11\r\nU 6\r\nD 13\r\nR 5\r\nL 10\r\nR 8\r\nL 5\r\nD 3\r\nU 5\r\nR 12\r\nD 6\r\nL 11\r\nR 1\r\nU 13\r\nD 6\r\nL 2\r\nD 14\r\nR 14\r\nD 10\r\nR 8\r\nL 12\r\nU 8\r\nL 8\r\nU 9\r\nR 8\r\nU 2\r\nR 14\r\nU 9\r\nL 12\r\nD 3\r\nL 3\r\nD 14\r\nU 7\r\nL 4\r\nD 11\r\nL 6\r\nU 2\r\nD 14\r\nL 1\r\nR 10\r\nU 5\r\nR 7\r\nL 12\r\nU 1\r\nL 8\r\nU 3\r\nD 5\r\nL 14\r\nD 3\r\nL 12\r\nR 3\r\nU 11\r\nD 3\r\nU 6\r\nD 12\r\nU 11\r\nL 11\r\nU 1\r\nR 8\r\nU 3\r\nL 16\r\nD 16\r\nL 14\r\nU 13\r\nD 14\r\nL 4\r\nU 15\r\nD 7\r\nU 6\r\nR 13\r\nU 16\r\nL 10\r\nU 6\r\nL 6\r\nU 15\r\nD 10\r\nL 11\r\nU 12\r\nR 13\r\nL 4\r\nR 5\r\nU 10\r\nD 16\r\nU 8\r\nD 8\r\nU 13\r\nR 13\r\nU 10\r\nR 5\r\nD 1\r\nL 9\r\nU 5\r\nD 7\r\nU 4\r\nL 15\r\nR 6\r\nL 13\r\nD 2\r\nU 2\r\nR 3\r\nU 2\r\nD 11\r\nU 12\r\nL 15\r\nD 3\r\nU 3\r\nR 5\r\nL 8\r\nU 14\r\nR 15\r\nU 12\r\nR 14\r\nL 14\r\nD 12\r\nR 14\r\nL 1\r\nR 4\r\nU 6\r\nR 12\r\nD 10\r\nR 12\r\nL 5\r\nD 8\r\nU 15\r\nL 13\r\nD 6\r\nL 4\r\nD 2\r\nR 6\r\nD 9\r\nL 12\r\nU 1\r\nR 16\r\nU 2\r\nL 15\r\nU 1\r\nD 3\r\nR 14\r\nL 5\r\nD 2\r\nL 16\r\nU 14\r\nL 11\r\nU 9\r\nL 5\r\nU 3\r\nR 1\r\nL 4\r\nU 15\r\nR 9\r\nU 4\r\nD 13\r\nU 16\r\nD 2\r\nR 6\r\nD 14\r\nR 6\r\nU 1\r\nL 2\r\nR 12\r\nD 15\r\nU 9\r\nR 3\r\nU 11\r\nL 5\r\nU 1\r\nR 16\r\nD 7\r\nR 11\r\nU 8\r\nL 15\r\nD 5\r\nL 11\r\nU 12\r\nD 12\r\nL 17\r\nU 5\r\nL 13\r\nR 5\r\nD 14\r\nU 14\r\nL 13\r\nU 7\r\nD 2\r\nR 6\r\nD 15\r\nL 8\r\nD 1\r\nU 8\r\nR 13\r\nD 9\r\nU 5\r\nD 1\r\nR 5\r\nL 4\r\nR 5\r\nU 4\r\nL 2\r\nR 15\r\nL 3\r\nR 14\r\nD 4\r\nU 17\r\nR 2\r\nU 2\r\nL 14\r\nU 4\r\nR 16\r\nU 13\r\nL 9\r\nD 4\r\nU 13\r\nL 14\r\nU 15\r\nL 9\r\nU 16\r\nD 10\r\nL 13\r\nR 11\r\nU 6\r\nR 15\r\nD 10\r\nL 1\r\nR 7\r\nU 11\r\nR 5\r\nD 6\r\nL 6\r\nR 10\r\nD 5\r\nU 15\r\nR 13\r\nU 10\r\nD 15\r\nL 14\r\nD 16\r\nU 2\r\nD 11\r\nR 17\r\nU 17\r\nR 17\r\nU 2\r\nR 8\r\nD 4\r\nR 14\r\nL 2\r\nD 12\r\nL 7\r\nR 3\r\nD 4\r\nU 9\r\nL 11\r\nU 1\r\nD 5\r\nU 13\r\nR 7\r\nL 18\r\nU 2\r\nD 17\r\nL 15\r\nR 18\r\nL 2\r\nD 10\r\nL 12\r\nR 3\r\nL 11\r\nR 9\r\nL 13\r\nR 10\r\nU 12\r\nR 14\r\nU 10\r\nD 15\r\nR 17\r\nD 5\r\nU 2\r\nR 12\r\nD 14\r\nL 11\r\nD 10\r\nR 8\r\nU 7\r\nL 4\r\nU 3\r\nR 5\r\nD 13\r\nL 14\r\nD 1\r\nL 2\r\nD 7\r\nR 8\r\nU 13\r\nL 6\r\nD 15\r\nR 5\r\nD 1\r\nL 12\r\nR 7\r\nL 6\r\nR 15\r\nL 17\r\nR 10\r\nD 10\r\nL 4\r\nR 12\r\nD 16\r\nL 12\r\nR 2\r\nL 17\r\nD 6\r\nR 13\r\nL 14\r\nR 14\r\nU 11\r\nL 5\r\nR 7\r\nD 1\r\nL 8\r\nU 16\r\nL 14\r\nR 16\r\nD 16\r\nR 7\r\nL 5\r\nR 13\r\nU 3\r\nR 1\r\nD 8\r\nL 8\r\nD 15\r\nR 14\r\nD 4\r\nU 6\r\nD 13\r\nL 2\r\nD 15\r\nR 11\r\nD 14\r\nU 2\r\nD 15\r\nR 1\r\nL 18\r\nR 8\r\nL 14\r\nU 7\r\nL 13\r\nU 11\r\nR 5\r\nL 17\r\nR 3\r\nU 13\r\nR 17\r\nU 9\r\nR 4\r\nD 10\r\nL 13\r\nD 12\r\nR 10\r\nL 11\r\nU 9\r\nL 14\r\nD 9\r\nU 3\r\nD 15\r\nL 2\r\nR 8\r\nD 14\r\nU 17\r\nR 5\r\nD 3\r\nU 2\r\nR 2\r\nL 13\r\nR 16\r\nL 6\r\nD 9\r\nU 1\r\nR 8\r\nD 4\r\nR 4\r\nL 3\r\nD 12\r\nU 4\r\nD 5\r\nU 13\r\nL 19\r\nR 13\r\nL 6\r\nR 10\r\nL 9\r\nD 16\r\nL 6\r\nR 4\r\nU 9\r\nL 5\r\nD 12\r\nL 2\r\nU 8\r\nR 8\r\nU 2\r\nL 12\r\nR 15\r\nD 4\r\nU 4\r\nL 8\r\nD 6\r\nU 8\r\nR 8\r\nD 16\r\nU 2\r\nR 12\r\nU 17\r\nR 15\r\nU 8\r\nD 1\r\nR 5\r\nU 8\r\nR 4\r\nL 3\r\nD 7\r\nR 15\r\nD 2\r\nU 19\r\nL 15\r\nR 1\r\nU 6\r\nR 9\r\nD 3\r\nU 1\r\nR 15\r\nL 16\r\nD 6\r\nU 19\r\nD 11\r\nL 7\r\nR 13\r\nD 19\r\nU 13\r\nL 1\r\nU 14\r\nR 5\r\nU 9\r\nD 12\r\nU 2\r\nL 7\r\nD 2\r\nR 5\r\nU 1\r\nL 3\r\nR 17\r\nU 10\r\nR 12\r\nU 19\r\nL 8\r\nU 11\r\nD 16\r\nL 14\r\nU 11\r\nL 3\r\nR 17\r\nL 10\r\nD 2\r\nU 11\r\nL 8\r\nU 15\r\nL 14\r\nD 18\r\nU 2\r\nD 6\r\nL 14\r\nD 14\r\nR 12";
        //static string args = "R 4\r\nU 4\r\nL 3\r\nD 1\r\nR 4\r\nD 1\r\nL 5\r\nR 2";

        //static int rows = 10000;
        //static int columns = 10000;
        //static (int row, int col) head = (5000, 5000);
        //static (int row, int col) tail = (5000, 5000);
        //static HashSet<(int, int)> visited = new HashSet<(int, int)>();

        //public static void Run()
        //{
        //    var steps = args.Split("\r\n")
        //        .Select(x => (x.Split(" ")[0], int.Parse(x.Split(" ")[1])))
        //        .ToArray();

        //    visited.Add(tail);
        //    foreach (var step in steps)
        //    {
        //        switch (step.Item1)
        //        {
        //            case "R":
        //                Console.WriteLine($"\t{step}");
        //                for (int i = 0; i < step.Item2; i++)
        //                {
        //                    head.col = Math.Clamp(head.col + 1, 1, columns);
        //                    Console.WriteLine($"H: {head}");
        //                    if (Math.Abs(tail.col - head.col) <= 1)
        //                    {
        //                        continue;
        //                    }

        //                    if (tail.row != head.row)
        //                    {
        //                        tail.row = head.row;
        //                    }

        //                    tail.col = Math.Clamp(tail.col + 1, 1, columns);
        //                    Console.WriteLine($"T: {tail}");
        //                    visited.Add(tail);
        //                }

        //                break;
        //            case "U":
        //                Console.WriteLine($"\t{step}");
        //                for (int i = 0; i < step.Item2; i++)
        //                {
        //                    head.row = Math.Clamp(head.row - 1, 1, rows);
        //                    Console.WriteLine($"H: {head}");
        //                    if (Math.Abs(tail.row - head.row) <= 1)
        //                    {
        //                        continue;
        //                    }

        //                    if (tail.col != head.col)
        //                    {
        //                        tail.col = head.col;
        //                    }

        //                    tail.row = Math.Clamp(tail.row - 1, 1, rows);
        //                    Console.WriteLine($"T: {tail}");
        //                    visited.Add(tail);
        //                }

        //                break;
        //            case "L":
        //                Console.WriteLine($"\t{step}");
        //                for (int i = 0; i < step.Item2; i++)
        //                {
        //                    head.col = Math.Clamp(head.col - 1, 1, columns);
        //                    Console.WriteLine($"H: {head}");
        //                    if (Math.Abs(tail.col - head.col) <= 1)
        //                    {
        //                        continue;
        //                    }

        //                    if (tail.row != head.row)
        //                    {
        //                        tail.row = head.row;
        //                    }

        //                    tail.col = Math.Clamp(tail.col + -1, 1, columns);
        //                    Console.WriteLine($"T: {tail}");
        //                    visited.Add(tail);
        //                }

        //                break;
        //            case "D":
        //                Console.WriteLine($"\t{step}");
        //                for (int i = 0; i < step.Item2; i++)
        //                {
        //                    head.row = Math.Clamp(head.row + 1, 1, rows);
        //                    Console.WriteLine($"H: {head}");
        //                    if (Math.Abs(tail.row - head.row) <= 1)
        //                    {
        //                        continue;
        //                    }

        //                    if (tail.col != head.col)
        //                    {
        //                        tail.col = head.col;
        //                    }

        //                    tail.row = Math.Clamp(tail.row + 1, 1, rows);
        //                    Console.WriteLine($"T: {tail}");
        //                    visited.Add(tail);
        //                }

        //                break;
        //        }
        //    }

        //    Console.WriteLine(visited.Count);
        //}

        //static string args = "R 5\r\nU 8\r\nL 8\r\nD 3\r\nR 17\r\nD 10\r\nL 25\r\nU 20";
        static string args = "R 1\r\nD 1\r\nU 1\r\nR 2\r\nL 2\r\nU 2\r\nD 1\r\nL 2\r\nR 1\r\nL 1\r\nU 2\r\nL 2\r\nR 2\r\nU 1\r\nD 2\r\nR 1\r\nD 1\r\nU 1\r\nL 1\r\nR 1\r\nL 2\r\nD 2\r\nR 1\r\nD 2\r\nL 1\r\nR 1\r\nD 2\r\nL 2\r\nD 1\r\nL 2\r\nD 1\r\nU 1\r\nL 2\r\nU 2\r\nR 2\r\nD 1\r\nL 1\r\nD 1\r\nL 2\r\nR 2\r\nU 1\r\nD 2\r\nL 2\r\nR 1\r\nL 2\r\nU 1\r\nL 2\r\nR 2\r\nD 1\r\nU 1\r\nL 1\r\nU 1\r\nR 1\r\nU 1\r\nR 1\r\nU 1\r\nL 2\r\nD 2\r\nU 1\r\nD 1\r\nL 1\r\nD 2\r\nR 2\r\nD 1\r\nL 1\r\nR 2\r\nD 1\r\nR 2\r\nU 1\r\nL 2\r\nR 1\r\nD 2\r\nR 1\r\nL 2\r\nD 2\r\nU 2\r\nD 2\r\nR 1\r\nD 1\r\nL 1\r\nD 2\r\nR 2\r\nD 2\r\nL 1\r\nD 2\r\nU 1\r\nD 1\r\nL 1\r\nU 1\r\nD 2\r\nL 2\r\nR 2\r\nL 1\r\nR 2\r\nU 2\r\nD 1\r\nU 1\r\nR 1\r\nU 1\r\nR 1\r\nD 2\r\nL 1\r\nU 2\r\nR 1\r\nU 1\r\nR 1\r\nD 2\r\nR 2\r\nU 1\r\nL 2\r\nR 2\r\nU 2\r\nR 3\r\nL 2\r\nR 2\r\nL 2\r\nD 3\r\nR 3\r\nD 1\r\nU 3\r\nL 1\r\nU 1\r\nD 2\r\nL 1\r\nD 1\r\nL 2\r\nD 2\r\nL 1\r\nD 2\r\nU 2\r\nR 1\r\nL 3\r\nU 3\r\nR 2\r\nL 3\r\nR 3\r\nD 3\r\nL 3\r\nR 1\r\nL 3\r\nD 1\r\nR 1\r\nL 1\r\nU 2\r\nD 3\r\nR 2\r\nU 1\r\nL 3\r\nU 3\r\nL 2\r\nD 3\r\nL 2\r\nU 1\r\nL 1\r\nD 1\r\nU 1\r\nD 2\r\nR 1\r\nL 3\r\nR 3\r\nL 1\r\nD 3\r\nU 3\r\nR 2\r\nL 3\r\nR 3\r\nD 2\r\nU 1\r\nR 1\r\nU 3\r\nR 2\r\nL 2\r\nD 3\r\nR 2\r\nL 1\r\nU 3\r\nR 3\r\nD 3\r\nL 3\r\nD 2\r\nR 2\r\nD 2\r\nU 3\r\nL 3\r\nR 1\r\nU 2\r\nD 3\r\nL 2\r\nR 3\r\nD 2\r\nL 2\r\nU 1\r\nD 2\r\nL 3\r\nU 1\r\nD 2\r\nU 1\r\nD 3\r\nR 1\r\nL 3\r\nR 3\r\nD 2\r\nU 1\r\nD 1\r\nU 2\r\nL 1\r\nR 2\r\nU 3\r\nL 2\r\nR 2\r\nD 1\r\nL 1\r\nD 1\r\nR 3\r\nU 2\r\nL 2\r\nD 3\r\nU 2\r\nR 2\r\nL 1\r\nU 1\r\nR 2\r\nU 3\r\nD 1\r\nR 4\r\nD 2\r\nL 4\r\nD 1\r\nL 2\r\nR 1\r\nL 2\r\nD 2\r\nU 2\r\nD 2\r\nR 3\r\nL 2\r\nD 2\r\nL 4\r\nR 4\r\nD 4\r\nL 2\r\nU 4\r\nL 1\r\nR 4\r\nU 4\r\nD 1\r\nL 4\r\nU 2\r\nL 3\r\nD 1\r\nL 3\r\nD 4\r\nU 2\r\nD 2\r\nR 1\r\nL 4\r\nD 1\r\nU 3\r\nL 3\r\nU 2\r\nR 4\r\nL 3\r\nD 3\r\nU 1\r\nL 2\r\nR 3\r\nL 2\r\nR 1\r\nD 2\r\nL 1\r\nU 3\r\nD 1\r\nL 3\r\nU 2\r\nR 2\r\nL 3\r\nD 1\r\nU 4\r\nR 1\r\nU 3\r\nR 1\r\nD 2\r\nR 3\r\nL 2\r\nU 1\r\nD 3\r\nL 4\r\nU 3\r\nL 3\r\nR 1\r\nD 2\r\nR 1\r\nL 1\r\nR 2\r\nD 4\r\nU 3\r\nL 4\r\nD 4\r\nR 3\r\nD 3\r\nU 3\r\nD 3\r\nL 2\r\nR 3\r\nL 4\r\nU 4\r\nD 1\r\nL 3\r\nU 4\r\nR 2\r\nD 3\r\nL 3\r\nR 1\r\nL 1\r\nR 1\r\nL 3\r\nD 3\r\nL 4\r\nR 4\r\nD 3\r\nU 4\r\nL 1\r\nR 2\r\nD 3\r\nU 1\r\nR 1\r\nL 3\r\nR 2\r\nD 3\r\nU 3\r\nR 4\r\nU 2\r\nL 1\r\nU 2\r\nR 2\r\nD 2\r\nR 1\r\nU 3\r\nR 5\r\nL 4\r\nD 2\r\nR 3\r\nL 3\r\nU 4\r\nL 2\r\nU 4\r\nR 1\r\nD 4\r\nR 2\r\nU 5\r\nL 4\r\nR 3\r\nU 5\r\nL 5\r\nU 2\r\nD 5\r\nR 1\r\nD 3\r\nL 5\r\nR 5\r\nL 4\r\nR 3\r\nL 5\r\nU 5\r\nD 2\r\nL 1\r\nU 4\r\nL 2\r\nR 3\r\nD 4\r\nL 3\r\nU 3\r\nL 3\r\nD 1\r\nU 5\r\nD 5\r\nR 1\r\nD 1\r\nL 1\r\nU 4\r\nL 1\r\nU 4\r\nL 1\r\nR 5\r\nD 4\r\nU 4\r\nD 3\r\nL 5\r\nD 1\r\nU 4\r\nR 2\r\nU 2\r\nD 3\r\nR 5\r\nL 3\r\nR 4\r\nD 1\r\nR 2\r\nL 2\r\nU 2\r\nL 3\r\nR 2\r\nL 5\r\nD 5\r\nL 1\r\nU 2\r\nD 5\r\nL 3\r\nU 1\r\nR 2\r\nL 3\r\nU 4\r\nD 5\r\nU 1\r\nR 5\r\nD 4\r\nR 5\r\nU 2\r\nD 4\r\nL 3\r\nR 5\r\nD 2\r\nU 2\r\nL 5\r\nR 1\r\nD 1\r\nR 4\r\nL 3\r\nD 1\r\nR 1\r\nU 1\r\nL 2\r\nD 5\r\nR 4\r\nL 5\r\nU 4\r\nR 4\r\nU 4\r\nD 2\r\nR 1\r\nU 4\r\nL 4\r\nR 4\r\nL 5\r\nD 6\r\nR 1\r\nL 1\r\nD 5\r\nR 4\r\nL 6\r\nD 5\r\nL 6\r\nU 3\r\nD 2\r\nR 6\r\nL 1\r\nR 3\r\nD 5\r\nL 4\r\nR 4\r\nU 4\r\nL 2\r\nU 1\r\nD 3\r\nR 2\r\nU 1\r\nD 2\r\nL 2\r\nR 3\r\nD 6\r\nR 3\r\nL 1\r\nD 3\r\nU 3\r\nL 3\r\nU 6\r\nR 1\r\nL 4\r\nD 3\r\nL 4\r\nU 2\r\nD 1\r\nU 5\r\nR 1\r\nD 1\r\nR 4\r\nD 2\r\nL 4\r\nR 2\r\nL 3\r\nR 6\r\nL 6\r\nR 6\r\nU 2\r\nR 4\r\nD 3\r\nU 6\r\nL 2\r\nR 6\r\nL 2\r\nD 4\r\nR 1\r\nU 4\r\nD 3\r\nR 2\r\nD 6\r\nL 4\r\nD 3\r\nU 5\r\nR 1\r\nD 6\r\nU 5\r\nR 1\r\nL 1\r\nR 3\r\nU 4\r\nL 2\r\nD 1\r\nR 4\r\nD 4\r\nU 4\r\nR 4\r\nL 1\r\nD 6\r\nU 3\r\nD 2\r\nU 2\r\nD 4\r\nR 1\r\nL 5\r\nR 5\r\nD 5\r\nR 5\r\nU 5\r\nL 6\r\nD 4\r\nU 5\r\nR 1\r\nL 5\r\nR 1\r\nU 3\r\nD 4\r\nL 6\r\nU 2\r\nD 1\r\nU 3\r\nR 6\r\nL 5\r\nU 6\r\nR 2\r\nL 2\r\nU 1\r\nL 2\r\nD 6\r\nU 4\r\nR 1\r\nD 4\r\nL 7\r\nD 6\r\nR 5\r\nL 4\r\nU 6\r\nR 4\r\nU 7\r\nR 4\r\nU 3\r\nL 7\r\nD 5\r\nR 6\r\nL 1\r\nR 5\r\nL 3\r\nR 4\r\nU 6\r\nR 1\r\nU 4\r\nL 7\r\nD 2\r\nR 4\r\nL 4\r\nR 5\r\nU 3\r\nD 1\r\nR 2\r\nD 1\r\nL 1\r\nR 4\r\nL 2\r\nU 7\r\nL 4\r\nR 7\r\nU 1\r\nD 3\r\nL 2\r\nD 6\r\nR 3\r\nD 1\r\nU 2\r\nL 5\r\nR 3\r\nD 2\r\nL 5\r\nU 1\r\nR 6\r\nD 3\r\nL 6\r\nU 6\r\nR 3\r\nL 5\r\nD 3\r\nU 3\r\nD 7\r\nU 4\r\nD 7\r\nR 4\r\nD 4\r\nL 4\r\nD 2\r\nR 4\r\nD 2\r\nR 2\r\nD 4\r\nU 5\r\nD 5\r\nL 6\r\nU 6\r\nL 1\r\nR 6\r\nU 3\r\nL 2\r\nU 3\r\nR 1\r\nU 4\r\nL 6\r\nR 5\r\nU 5\r\nD 2\r\nU 4\r\nR 1\r\nD 1\r\nR 2\r\nU 5\r\nL 4\r\nD 3\r\nR 2\r\nL 4\r\nU 2\r\nR 2\r\nL 7\r\nR 4\r\nU 3\r\nL 6\r\nR 3\r\nL 2\r\nU 6\r\nL 2\r\nR 2\r\nL 3\r\nD 2\r\nL 5\r\nR 2\r\nU 6\r\nD 6\r\nL 4\r\nD 5\r\nU 4\r\nR 2\r\nL 2\r\nU 3\r\nD 1\r\nR 8\r\nD 5\r\nL 8\r\nR 1\r\nU 7\r\nR 3\r\nU 4\r\nL 8\r\nD 3\r\nU 6\r\nD 8\r\nR 1\r\nD 4\r\nL 3\r\nD 8\r\nL 7\r\nD 5\r\nR 8\r\nL 5\r\nU 4\r\nD 3\r\nL 5\r\nR 3\r\nL 2\r\nR 5\r\nL 6\r\nR 3\r\nU 6\r\nR 6\r\nU 3\r\nD 1\r\nR 4\r\nU 5\r\nD 2\r\nL 1\r\nR 8\r\nU 3\r\nD 5\r\nR 6\r\nD 1\r\nL 3\r\nD 8\r\nR 1\r\nU 3\r\nL 3\r\nU 4\r\nD 2\r\nU 3\r\nL 8\r\nD 2\r\nL 3\r\nU 7\r\nL 2\r\nU 1\r\nD 1\r\nU 8\r\nR 6\r\nD 6\r\nR 3\r\nL 5\r\nU 6\r\nR 8\r\nL 1\r\nR 5\r\nL 7\r\nU 1\r\nR 1\r\nD 4\r\nL 8\r\nD 7\r\nR 6\r\nU 6\r\nD 5\r\nR 3\r\nU 3\r\nR 8\r\nD 4\r\nR 2\r\nU 6\r\nL 2\r\nD 2\r\nU 1\r\nL 1\r\nD 3\r\nL 4\r\nD 8\r\nR 6\r\nL 8\r\nD 7\r\nR 1\r\nL 2\r\nU 6\r\nR 7\r\nL 5\r\nR 3\r\nL 5\r\nU 3\r\nD 8\r\nU 5\r\nR 3\r\nU 7\r\nL 5\r\nD 8\r\nU 5\r\nR 1\r\nD 5\r\nL 4\r\nD 9\r\nR 5\r\nU 1\r\nD 9\r\nU 6\r\nL 2\r\nD 3\r\nL 7\r\nU 5\r\nD 3\r\nR 3\r\nU 5\r\nR 3\r\nD 2\r\nR 7\r\nU 5\r\nD 6\r\nR 1\r\nL 8\r\nU 6\r\nD 5\r\nL 2\r\nR 1\r\nL 9\r\nD 2\r\nR 3\r\nL 5\r\nR 2\r\nL 4\r\nU 7\r\nL 2\r\nD 6\r\nL 9\r\nR 9\r\nD 8\r\nU 6\r\nD 2\r\nU 7\r\nR 7\r\nD 5\r\nR 3\r\nU 9\r\nR 8\r\nD 5\r\nL 2\r\nD 3\r\nR 8\r\nU 3\r\nL 2\r\nU 8\r\nR 8\r\nL 1\r\nU 5\r\nR 4\r\nL 8\r\nU 9\r\nL 7\r\nU 9\r\nR 9\r\nD 6\r\nL 3\r\nR 9\r\nU 5\r\nL 3\r\nU 7\r\nL 5\r\nU 5\r\nR 1\r\nD 9\r\nU 5\r\nR 9\r\nD 5\r\nU 4\r\nD 8\r\nU 3\r\nL 4\r\nD 8\r\nL 3\r\nU 4\r\nD 5\r\nR 5\r\nL 1\r\nD 7\r\nU 4\r\nR 3\r\nL 6\r\nR 9\r\nU 5\r\nR 8\r\nD 9\r\nL 7\r\nU 4\r\nL 2\r\nD 2\r\nU 6\r\nR 5\r\nU 5\r\nL 8\r\nU 9\r\nL 2\r\nR 3\r\nD 9\r\nU 2\r\nL 6\r\nD 6\r\nL 3\r\nD 2\r\nU 7\r\nD 4\r\nL 6\r\nD 7\r\nL 8\r\nU 4\r\nD 2\r\nR 3\r\nU 3\r\nL 1\r\nR 5\r\nL 3\r\nD 2\r\nR 6\r\nD 8\r\nU 8\r\nR 10\r\nU 7\r\nL 6\r\nU 3\r\nD 6\r\nU 5\r\nL 3\r\nR 5\r\nU 8\r\nD 4\r\nL 8\r\nU 8\r\nL 9\r\nU 6\r\nL 6\r\nD 3\r\nU 1\r\nL 2\r\nU 1\r\nL 8\r\nR 9\r\nL 1\r\nR 9\r\nD 1\r\nR 4\r\nD 5\r\nL 5\r\nR 8\r\nU 3\r\nL 2\r\nU 7\r\nD 2\r\nU 2\r\nL 6\r\nD 4\r\nL 9\r\nU 10\r\nR 10\r\nU 2\r\nR 6\r\nL 4\r\nD 1\r\nR 10\r\nU 5\r\nL 1\r\nU 9\r\nL 10\r\nD 8\r\nR 1\r\nU 2\r\nL 1\r\nD 4\r\nU 2\r\nL 1\r\nU 5\r\nL 9\r\nD 1\r\nU 3\r\nL 10\r\nU 3\r\nD 8\r\nU 8\r\nD 10\r\nL 4\r\nD 9\r\nU 4\r\nL 8\r\nR 9\r\nD 6\r\nU 1\r\nL 1\r\nR 8\r\nL 2\r\nR 5\r\nU 7\r\nL 8\r\nR 2\r\nD 8\r\nL 6\r\nR 8\r\nL 7\r\nR 1\r\nD 4\r\nL 7\r\nR 9\r\nL 6\r\nU 2\r\nR 10\r\nU 1\r\nR 2\r\nU 4\r\nD 7\r\nU 6\r\nL 9\r\nR 6\r\nL 6\r\nR 5\r\nU 4\r\nL 4\r\nD 10\r\nL 10\r\nR 4\r\nL 10\r\nD 10\r\nR 11\r\nU 7\r\nD 5\r\nL 11\r\nD 8\r\nU 2\r\nR 2\r\nL 10\r\nR 9\r\nL 1\r\nU 4\r\nR 11\r\nL 7\r\nR 3\r\nD 5\r\nU 4\r\nL 10\r\nD 11\r\nR 4\r\nD 5\r\nL 8\r\nR 3\r\nD 2\r\nR 11\r\nU 9\r\nL 5\r\nR 1\r\nL 1\r\nU 9\r\nL 10\r\nU 11\r\nD 7\r\nL 3\r\nU 2\r\nD 6\r\nL 9\r\nD 2\r\nU 8\r\nL 6\r\nR 7\r\nU 6\r\nR 8\r\nD 11\r\nL 9\r\nD 7\r\nR 1\r\nD 7\r\nL 8\r\nR 11\r\nL 1\r\nR 7\r\nD 10\r\nR 10\r\nU 2\r\nL 7\r\nU 8\r\nL 2\r\nD 8\r\nU 7\r\nL 6\r\nR 8\r\nD 10\r\nL 11\r\nD 2\r\nU 4\r\nL 3\r\nU 8\r\nL 4\r\nD 10\r\nU 3\r\nD 6\r\nR 4\r\nL 8\r\nD 6\r\nU 11\r\nD 7\r\nL 9\r\nU 10\r\nD 10\r\nR 9\r\nD 8\r\nL 8\r\nU 10\r\nL 6\r\nD 2\r\nL 6\r\nR 11\r\nD 10\r\nR 1\r\nU 7\r\nR 7\r\nL 2\r\nR 6\r\nD 11\r\nR 1\r\nL 6\r\nR 8\r\nU 1\r\nR 3\r\nL 5\r\nU 7\r\nR 2\r\nL 4\r\nU 7\r\nL 4\r\nD 8\r\nR 10\r\nD 12\r\nU 8\r\nL 6\r\nU 2\r\nD 5\r\nU 8\r\nD 5\r\nU 10\r\nR 6\r\nL 7\r\nD 11\r\nL 8\r\nR 4\r\nL 5\r\nR 12\r\nL 3\r\nR 3\r\nD 5\r\nR 3\r\nL 9\r\nU 6\r\nL 3\r\nR 4\r\nD 12\r\nR 7\r\nL 10\r\nD 5\r\nL 6\r\nR 3\r\nU 9\r\nD 4\r\nU 5\r\nR 5\r\nL 12\r\nR 3\r\nU 12\r\nD 6\r\nL 3\r\nU 6\r\nR 10\r\nD 6\r\nU 11\r\nD 9\r\nU 1\r\nD 10\r\nR 4\r\nU 9\r\nD 10\r\nR 7\r\nU 3\r\nR 11\r\nU 5\r\nR 9\r\nL 11\r\nD 11\r\nU 11\r\nR 3\r\nL 10\r\nU 5\r\nL 9\r\nU 6\r\nD 10\r\nL 5\r\nD 11\r\nL 1\r\nR 8\r\nD 7\r\nL 7\r\nR 2\r\nL 5\r\nR 1\r\nD 12\r\nR 2\r\nD 6\r\nU 6\r\nD 3\r\nR 3\r\nL 1\r\nR 10\r\nL 9\r\nR 1\r\nD 10\r\nL 8\r\nD 4\r\nR 4\r\nU 6\r\nL 2\r\nR 4\r\nU 9\r\nL 6\r\nU 9\r\nD 9\r\nR 12\r\nL 8\r\nU 2\r\nD 1\r\nU 4\r\nR 12\r\nD 1\r\nR 10\r\nL 8\r\nU 1\r\nR 6\r\nD 5\r\nU 12\r\nR 10\r\nL 10\r\nD 7\r\nR 3\r\nU 1\r\nD 9\r\nR 1\r\nL 1\r\nD 11\r\nL 3\r\nD 9\r\nU 7\r\nR 4\r\nL 9\r\nR 13\r\nL 5\r\nD 3\r\nU 2\r\nL 7\r\nU 2\r\nR 10\r\nD 1\r\nL 1\r\nD 7\r\nR 4\r\nU 3\r\nR 8\r\nD 6\r\nL 7\r\nU 12\r\nL 6\r\nD 3\r\nR 10\r\nD 11\r\nL 11\r\nR 10\r\nU 6\r\nL 2\r\nU 4\r\nR 10\r\nD 6\r\nR 5\r\nU 2\r\nR 12\r\nD 8\r\nL 2\r\nD 13\r\nR 9\r\nL 5\r\nU 2\r\nL 12\r\nU 8\r\nD 6\r\nU 9\r\nR 11\r\nU 11\r\nL 7\r\nR 7\r\nU 7\r\nR 4\r\nU 9\r\nD 1\r\nR 6\r\nD 8\r\nL 6\r\nD 7\r\nR 1\r\nL 5\r\nR 8\r\nD 10\r\nL 8\r\nR 1\r\nU 9\r\nR 12\r\nD 10\r\nU 2\r\nL 9\r\nU 5\r\nR 4\r\nU 7\r\nD 7\r\nR 3\r\nU 7\r\nD 12\r\nU 2\r\nL 12\r\nU 1\r\nD 6\r\nR 13\r\nL 11\r\nR 12\r\nL 4\r\nU 6\r\nL 1\r\nU 8\r\nD 6\r\nU 9\r\nD 3\r\nL 7\r\nD 7\r\nR 12\r\nU 13\r\nR 13\r\nU 13\r\nD 13\r\nR 11\r\nL 2\r\nD 9\r\nR 2\r\nD 9\r\nU 11\r\nR 7\r\nU 8\r\nR 7\r\nL 8\r\nU 10\r\nR 4\r\nU 5\r\nD 14\r\nR 4\r\nD 4\r\nU 5\r\nR 6\r\nU 2\r\nD 11\r\nL 5\r\nU 10\r\nR 2\r\nL 1\r\nD 12\r\nU 7\r\nD 6\r\nL 4\r\nD 10\r\nU 11\r\nL 12\r\nD 8\r\nR 9\r\nL 6\r\nD 8\r\nR 11\r\nL 14\r\nD 13\r\nU 8\r\nD 12\r\nU 7\r\nD 10\r\nR 9\r\nL 1\r\nD 2\r\nU 3\r\nD 1\r\nR 2\r\nL 2\r\nD 13\r\nL 13\r\nR 4\r\nL 2\r\nR 3\r\nU 10\r\nR 3\r\nL 4\r\nR 8\r\nU 8\r\nR 5\r\nD 13\r\nL 2\r\nR 3\r\nU 2\r\nL 9\r\nR 1\r\nU 6\r\nD 5\r\nL 1\r\nR 4\r\nL 2\r\nU 2\r\nD 5\r\nR 13\r\nL 8\r\nD 13\r\nR 1\r\nU 14\r\nD 2\r\nL 11\r\nU 4\r\nD 12\r\nU 7\r\nR 8\r\nU 5\r\nR 6\r\nU 5\r\nD 2\r\nU 10\r\nD 1\r\nU 2\r\nD 3\r\nU 12\r\nL 10\r\nR 2\r\nD 12\r\nR 12\r\nL 5\r\nD 13\r\nR 1\r\nL 1\r\nU 1\r\nD 10\r\nR 13\r\nL 2\r\nD 4\r\nL 8\r\nU 9\r\nL 3\r\nR 5\r\nD 13\r\nL 4\r\nR 9\r\nU 4\r\nL 3\r\nD 2\r\nU 14\r\nR 1\r\nL 6\r\nD 8\r\nR 14\r\nU 8\r\nL 1\r\nD 5\r\nU 9\r\nL 15\r\nR 4\r\nL 15\r\nR 14\r\nU 6\r\nD 1\r\nL 15\r\nU 11\r\nR 5\r\nD 13\r\nL 1\r\nU 6\r\nR 7\r\nL 12\r\nD 3\r\nU 12\r\nR 11\r\nL 9\r\nR 2\r\nL 6\r\nR 9\r\nL 6\r\nR 4\r\nU 3\r\nL 13\r\nR 9\r\nL 3\r\nR 15\r\nD 8\r\nU 3\r\nD 13\r\nL 6\r\nD 14\r\nU 6\r\nL 3\r\nR 8\r\nU 15\r\nD 14\r\nU 2\r\nL 9\r\nU 3\r\nL 7\r\nU 15\r\nD 11\r\nU 13\r\nL 6\r\nD 9\r\nR 11\r\nL 7\r\nU 2\r\nL 15\r\nU 14\r\nL 4\r\nR 4\r\nU 11\r\nR 7\r\nU 8\r\nD 3\r\nL 15\r\nU 10\r\nR 2\r\nD 14\r\nU 13\r\nD 6\r\nU 1\r\nL 7\r\nR 7\r\nU 5\r\nL 4\r\nR 1\r\nL 12\r\nD 1\r\nR 15\r\nU 14\r\nD 13\r\nU 4\r\nD 10\r\nU 11\r\nL 14\r\nR 3\r\nL 3\r\nR 9\r\nL 11\r\nU 6\r\nD 13\r\nR 5\r\nL 10\r\nR 8\r\nL 5\r\nD 3\r\nU 5\r\nR 12\r\nD 6\r\nL 11\r\nR 1\r\nU 13\r\nD 6\r\nL 2\r\nD 14\r\nR 14\r\nD 10\r\nR 8\r\nL 12\r\nU 8\r\nL 8\r\nU 9\r\nR 8\r\nU 2\r\nR 14\r\nU 9\r\nL 12\r\nD 3\r\nL 3\r\nD 14\r\nU 7\r\nL 4\r\nD 11\r\nL 6\r\nU 2\r\nD 14\r\nL 1\r\nR 10\r\nU 5\r\nR 7\r\nL 12\r\nU 1\r\nL 8\r\nU 3\r\nD 5\r\nL 14\r\nD 3\r\nL 12\r\nR 3\r\nU 11\r\nD 3\r\nU 6\r\nD 12\r\nU 11\r\nL 11\r\nU 1\r\nR 8\r\nU 3\r\nL 16\r\nD 16\r\nL 14\r\nU 13\r\nD 14\r\nL 4\r\nU 15\r\nD 7\r\nU 6\r\nR 13\r\nU 16\r\nL 10\r\nU 6\r\nL 6\r\nU 15\r\nD 10\r\nL 11\r\nU 12\r\nR 13\r\nL 4\r\nR 5\r\nU 10\r\nD 16\r\nU 8\r\nD 8\r\nU 13\r\nR 13\r\nU 10\r\nR 5\r\nD 1\r\nL 9\r\nU 5\r\nD 7\r\nU 4\r\nL 15\r\nR 6\r\nL 13\r\nD 2\r\nU 2\r\nR 3\r\nU 2\r\nD 11\r\nU 12\r\nL 15\r\nD 3\r\nU 3\r\nR 5\r\nL 8\r\nU 14\r\nR 15\r\nU 12\r\nR 14\r\nL 14\r\nD 12\r\nR 14\r\nL 1\r\nR 4\r\nU 6\r\nR 12\r\nD 10\r\nR 12\r\nL 5\r\nD 8\r\nU 15\r\nL 13\r\nD 6\r\nL 4\r\nD 2\r\nR 6\r\nD 9\r\nL 12\r\nU 1\r\nR 16\r\nU 2\r\nL 15\r\nU 1\r\nD 3\r\nR 14\r\nL 5\r\nD 2\r\nL 16\r\nU 14\r\nL 11\r\nU 9\r\nL 5\r\nU 3\r\nR 1\r\nL 4\r\nU 15\r\nR 9\r\nU 4\r\nD 13\r\nU 16\r\nD 2\r\nR 6\r\nD 14\r\nR 6\r\nU 1\r\nL 2\r\nR 12\r\nD 15\r\nU 9\r\nR 3\r\nU 11\r\nL 5\r\nU 1\r\nR 16\r\nD 7\r\nR 11\r\nU 8\r\nL 15\r\nD 5\r\nL 11\r\nU 12\r\nD 12\r\nL 17\r\nU 5\r\nL 13\r\nR 5\r\nD 14\r\nU 14\r\nL 13\r\nU 7\r\nD 2\r\nR 6\r\nD 15\r\nL 8\r\nD 1\r\nU 8\r\nR 13\r\nD 9\r\nU 5\r\nD 1\r\nR 5\r\nL 4\r\nR 5\r\nU 4\r\nL 2\r\nR 15\r\nL 3\r\nR 14\r\nD 4\r\nU 17\r\nR 2\r\nU 2\r\nL 14\r\nU 4\r\nR 16\r\nU 13\r\nL 9\r\nD 4\r\nU 13\r\nL 14\r\nU 15\r\nL 9\r\nU 16\r\nD 10\r\nL 13\r\nR 11\r\nU 6\r\nR 15\r\nD 10\r\nL 1\r\nR 7\r\nU 11\r\nR 5\r\nD 6\r\nL 6\r\nR 10\r\nD 5\r\nU 15\r\nR 13\r\nU 10\r\nD 15\r\nL 14\r\nD 16\r\nU 2\r\nD 11\r\nR 17\r\nU 17\r\nR 17\r\nU 2\r\nR 8\r\nD 4\r\nR 14\r\nL 2\r\nD 12\r\nL 7\r\nR 3\r\nD 4\r\nU 9\r\nL 11\r\nU 1\r\nD 5\r\nU 13\r\nR 7\r\nL 18\r\nU 2\r\nD 17\r\nL 15\r\nR 18\r\nL 2\r\nD 10\r\nL 12\r\nR 3\r\nL 11\r\nR 9\r\nL 13\r\nR 10\r\nU 12\r\nR 14\r\nU 10\r\nD 15\r\nR 17\r\nD 5\r\nU 2\r\nR 12\r\nD 14\r\nL 11\r\nD 10\r\nR 8\r\nU 7\r\nL 4\r\nU 3\r\nR 5\r\nD 13\r\nL 14\r\nD 1\r\nL 2\r\nD 7\r\nR 8\r\nU 13\r\nL 6\r\nD 15\r\nR 5\r\nD 1\r\nL 12\r\nR 7\r\nL 6\r\nR 15\r\nL 17\r\nR 10\r\nD 10\r\nL 4\r\nR 12\r\nD 16\r\nL 12\r\nR 2\r\nL 17\r\nD 6\r\nR 13\r\nL 14\r\nR 14\r\nU 11\r\nL 5\r\nR 7\r\nD 1\r\nL 8\r\nU 16\r\nL 14\r\nR 16\r\nD 16\r\nR 7\r\nL 5\r\nR 13\r\nU 3\r\nR 1\r\nD 8\r\nL 8\r\nD 15\r\nR 14\r\nD 4\r\nU 6\r\nD 13\r\nL 2\r\nD 15\r\nR 11\r\nD 14\r\nU 2\r\nD 15\r\nR 1\r\nL 18\r\nR 8\r\nL 14\r\nU 7\r\nL 13\r\nU 11\r\nR 5\r\nL 17\r\nR 3\r\nU 13\r\nR 17\r\nU 9\r\nR 4\r\nD 10\r\nL 13\r\nD 12\r\nR 10\r\nL 11\r\nU 9\r\nL 14\r\nD 9\r\nU 3\r\nD 15\r\nL 2\r\nR 8\r\nD 14\r\nU 17\r\nR 5\r\nD 3\r\nU 2\r\nR 2\r\nL 13\r\nR 16\r\nL 6\r\nD 9\r\nU 1\r\nR 8\r\nD 4\r\nR 4\r\nL 3\r\nD 12\r\nU 4\r\nD 5\r\nU 13\r\nL 19\r\nR 13\r\nL 6\r\nR 10\r\nL 9\r\nD 16\r\nL 6\r\nR 4\r\nU 9\r\nL 5\r\nD 12\r\nL 2\r\nU 8\r\nR 8\r\nU 2\r\nL 12\r\nR 15\r\nD 4\r\nU 4\r\nL 8\r\nD 6\r\nU 8\r\nR 8\r\nD 16\r\nU 2\r\nR 12\r\nU 17\r\nR 15\r\nU 8\r\nD 1\r\nR 5\r\nU 8\r\nR 4\r\nL 3\r\nD 7\r\nR 15\r\nD 2\r\nU 19\r\nL 15\r\nR 1\r\nU 6\r\nR 9\r\nD 3\r\nU 1\r\nR 15\r\nL 16\r\nD 6\r\nU 19\r\nD 11\r\nL 7\r\nR 13\r\nD 19\r\nU 13\r\nL 1\r\nU 14\r\nR 5\r\nU 9\r\nD 12\r\nU 2\r\nL 7\r\nD 2\r\nR 5\r\nU 1\r\nL 3\r\nR 17\r\nU 10\r\nR 12\r\nU 19\r\nL 8\r\nU 11\r\nD 16\r\nL 14\r\nU 11\r\nL 3\r\nR 17\r\nL 10\r\nD 2\r\nU 11\r\nL 8\r\nU 15\r\nL 14\r\nD 18\r\nU 2\r\nD 6\r\nL 14\r\nD 14\r\nR 12";

        static int rows = 10000;
        static int columns = 10000;
        static (int row, int col) head = (5000, 5000);
        static (int row, int col)[] body = Enumerable.Range(0, 9).Select(x => (5000, 5000)).ToArray();
        static HashSet<(int, int)> visited = new HashSet<(int, int)>();

        public static void Run()
        {
            var steps = args.Split("\r\n")
                .Select(x => (x.Split(" ")[0], int.Parse(x.Split(" ")[1])))
                .ToArray();

            visited.Add(head);
            foreach (var step in steps)
            {
                switch (step.Item1)
                {
                    case "R":
                        Console.WriteLine($"\t{step}");
                        for (int i = 0; i < step.Item2; i++)
                        {
                            head.col = Math.Clamp(head.col + 1, 1, columns);
                            Console.WriteLine($"H: {head}");

                            for (int j = 0; j < body.Length; j++)
                            {
                                var last = j == 0 ? head : body[j - 1];

                                if (Math.Abs(body[j].col - last.col) <= 1 && Math.Abs(body[j].row - last.row) <= 1)
                                {
                                    continue;
                                }

                                if (body[j].row != last.row)
                                {
                                    body[j].row = last.row > body[j].row ? body[j].row + 1 : body[j].row - 1;
                                }

                                if (body[j].col != last.col)
                                {
                                    body[j].col = last.col > body[j].col ? body[j].col + 1 : body[j].col - 1;
                                }

                                Console.WriteLine($"{j + 1}: {body[j]}");

                                if (j == body.Length - 1)
                                {
                                    Console.WriteLine($"!!!");
                                    visited.Add(body[j]);
                                }
                            }
                        }

                        break;

                    case "U":
                        Console.WriteLine($"\t{step}");
                        for (int i = 0; i < step.Item2; i++)
                        {
                            head.row = Math.Clamp(head.row - 1, 1, rows);
                            Console.WriteLine($"H: {head}");

                            for (int j = 0; j < body.Length; j++)
                            {
                                var last = j == 0 ? head : body[j - 1];

                                if (Math.Abs(body[j].row - last.row) <= 1 && Math.Abs(body[j].col - last.col) <= 1)
                                {
                                    continue;
                                }

                                if (body[j].col != last.col)
                                {
                                    body[j].col = last.col > body[j].col ? body[j].col + 1 : body[j].col - 1;
                                }

                                if (body[j].row != last.row)
                                {
                                    body[j].row = last.row > body[j].row ? body[j].row + 1 : body[j].row - 1;
                                }

                                Console.WriteLine($"{j + 1}: {body[j]}");

                                if (j == body.Length - 1)
                                {
                                    Console.WriteLine($"!!!");
                                    visited.Add(body[j]);
                                }
                            }
                        }

                        break;

                    case "L":
                        Console.WriteLine($"\t{step}");
                        for (int i = 0; i < step.Item2; i++)
                        {
                            head.col = Math.Clamp(head.col - 1, 1, columns);
                            Console.WriteLine($"H: {head}");

                            for (int j = 0; j < body.Length; j++)
                            {
                                var last = j == 0 ? head : body[j - 1];

                                if (Math.Abs(body[j].col - last.col) <= 1 && Math.Abs(body[j].row - last.row) <= 1)
                                {
                                    continue;
                                }

                                if (body[j].row != last.row)
                                {
                                    body[j].row = last.row > body[j].row ? body[j].row + 1 : body[j].row - 1;
                                }

                                if (body[j].col != last.col)
                                {
                                    body[j].col = last.col > body[j].col ? body[j].col + 1 : body[j].col - 1;
                                }

                                Console.WriteLine($"{j + 1}: {body[j]}");

                                if (j == body.Length - 1)
                                {
                                    Console.WriteLine($"!!!");
                                    visited.Add(body[j]);
                                }
                            }
                        }

                        break;

                    case "D":
                        Console.WriteLine($"\t{step}");
                        for (int i = 0; i < step.Item2; i++)
                        {
                            head.row = Math.Clamp(head.row + 1, 1, rows);
                            Console.WriteLine($"H: {head}");

                            for (int j = 0; j < body.Length; j++)
                            {
                                var last = j == 0 ? head : body[j - 1];

                                if (Math.Abs(body[j].row - last.row) <= 1 && Math.Abs(body[j].col - last.col) <= 1)
                                {
                                    continue;
                                }

                                if (body[j].col != last.col)
                                {
                                    body[j].col = last.col > body[j].col ? body[j].col + 1 : body[j].col - 1;
                                }

                                if (body[j].row != last.row)
                                {
                                    body[j].row = last.row > body[j].row ? body[j].row + 1 : body[j].row - 1;
                                }

                                Console.WriteLine($"{j + 1}: {body[j]}");

                                if (j == body.Length - 1)
                                {
                                    Console.WriteLine($"!!!");
                                    visited.Add(body[j]);
                                }
                            }
                        }

                        break;

                }
            }

            Console.WriteLine(visited.Count);
        }
    }
}

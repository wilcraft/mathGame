using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace mathGame
{
    internal class Global
    {
        public class randomNumber
        {
            private int pA;
            private int pB;

            public int A
            {
                get { return pA; }
                set { pA = value; }
            }
            public int B
            {
                get { return pB; }
                set { pB = value; }
            }

            public randomNumber()
            {
                Random rand = new Random();
                A = rand.Next(0, 101);
                B = rand.Next(0, 101);
            }
        }
        public class globalVars
        {
            private int points;
            private int? limit;
            private string input;
            public string Input
            {
                get { return input; }
                set { input = value; }
            }
            public int? Limit
            {
                get { return limit; }
                set { limit = value; }
            }
            public int Points
            {
                get { return points; }
                set { points = value; }
            }

        }
        public static class gameSelection
        {
            public static int gameSelected;
            public static string[] gameHistory;
        }
    }
}

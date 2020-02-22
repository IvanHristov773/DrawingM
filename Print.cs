using System;

namespace HelloWord
{
    public class Print
    {
        public void PrintStars(int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("*");
            }
        }

        public void PrintDashes(int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("-");
            }
        }
    }
}
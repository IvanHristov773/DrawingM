using System;

namespace HelloWord
{
    class DrawClass
    {
        static void Main(string[] args)
        {

            int N = Int32.Parse(Console.ReadLine());
            int star = 0;
            int dash = 1;
            int secondStar = 0;
            int secondDash = 1;

            var Draw = new Print();

            for (int i = 0; i < N + 1; i++)
            {
                //Printing first M
                Draw.PrintDashes(N - i);
                Draw.PrintStars(N);

                if (i <= (N / 2))
                {
                    Draw.PrintStars(star);
                }
                else
                {
                    Draw.PrintDashes(dash);
                    Draw.PrintStars(N);
                }

                Draw.PrintDashes(N - star);

                if (i > (N / 2))
                {
                    Draw.PrintStars(N - dash);
                }
                else
                {
                    Draw.PrintStars(N);
                }


                if (i <= (N / 2))
                {
                    Draw.PrintStars(star);
                }
                else
                {
                    Draw.PrintDashes(dash);
                    Draw.PrintStars(N);
                    dash += 2;
                }

                Draw.PrintDashes(N - i);

                //Print second M

                Draw.PrintDashes(N - i);
                Draw.PrintStars(N);

                if (i <= (N / 2))
                {
                    Draw.PrintStars(secondStar);
                }
                else
                {
                    Draw.PrintDashes(secondDash);
                    Draw.PrintStars(N);
                }

                Draw.PrintDashes(N - secondStar);

                if (i > (N / 2))
                {
                    Draw.PrintStars(N - secondDash);
                }
                else
                {
                    Draw.PrintStars(N);
                }

                if (i <= (N / 2))
                {
                    Draw.PrintStars(secondStar);
                }
                else
                {
                    Draw.PrintDashes(secondDash);
                    Draw.PrintStars(N);
                    secondDash += 2;
                }

                Draw.PrintDashes(N - i);

                System.Console.WriteLine();

                star += 2;
                secondStar += 2;

            }
        }
    }
}
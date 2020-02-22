using System;

namespace HelloWord {
    class Program {
        static void Main (string[] args) {

            int N = Int32.Parse (Console.ReadLine ());
            int star = 0;
            int dash = 1;
            int secondStar = 0;
            int secondDash = 1;

            var Draw = new Print ();

            for (int i = 0; i < N + 1; i++) {
                //first part
                Draw.PrintDashes (N - i);
                Draw.PrintStars (N);

                if (i <= (N / 2)) {
                    for (int j = 0; j < star; j++) {
                        Console.Write ("*");
                    }
                } 
                else {
                    for (int k = 0; k < dash; k++) {
                        Console.Write ("-");

                    }
                    for (int p = 0; p < N; p++) {
                        Console.Write ("*");
                    }
                }

                Draw.PrintDashes (N - star);

                if (i > (N / 2))
                {
                    for (int p = 0; p < N-dash; p++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Draw.PrintStars(N);

                }


                if (i <= (N / 2)) {
                    for (int j = 0; j < star; j++) {
                        Console.Write ("*");
                    }
                } 
                else {
                    for (int k = 0; k < dash; k++) {
                        Console.Write ("-");

                    }
                    for (int p = 0; p < N; p++) {
                        Console.Write ("*");
                    }
                    dash += 2;
                }

                Draw.PrintDashes (N - i);

                //second part

                Draw.PrintDashes(N - i);
                Draw.PrintStars(N);

                if (i <= (N / 2))
                {
                    for (int j = 0; j < secondStar; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int k = 0; k < secondDash; k++)
                    {
                        Console.Write("-");

                    }
                    for (int p = 0; p < N; p++)
                    {
                        Console.Write("*");
                    }
                    
                }

                Draw.PrintDashes(N - secondStar);

                if (i > (N / 2))
                {
                    for (int p = 0; p < N - secondDash; p++)
                    {
                        Console.Write("*");
                    }
                    //secondDash += 2;
                }
                else
                {
                    Draw.PrintStars(N);

                }

                if (i <= (N / 2))
                {
                    for (int j = 0; j < secondStar; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int k = 0; k < secondDash; k++)
                    {
                        Console.Write("-");

                    }
                    for (int p = 0; p < N; p++)
                    {
                        Console.Write("*");
                    }
                    secondDash += 2;
                }

                Draw.PrintDashes(N - i);

                System.Console.WriteLine ();



                star += 2;
                secondStar += 2;
                
            }



        }
    }
}
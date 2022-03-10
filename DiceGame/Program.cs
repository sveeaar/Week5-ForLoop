using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat: arvuti ja kasutaja;
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab välja võitja;

            Random rnd = new Random();


            int cpuScore = 0;
            int userScore = 0;



            for (int i = 0; i < 3; i++)
            {

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}, kasutaja viskas {userRandom}");


                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitja, palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitja!");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

            }

 
            Console.WriteLine($"Arvuti lõpptulemus: {cpuScore}");
            Console.WriteLine($"Kasutaja lõpptulemus: {userScore}");

            
            

            

            
            


        }
    }
}

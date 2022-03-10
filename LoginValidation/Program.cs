using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnuse ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis programm kuvab konsoolis "Tere tulemast!";
            //muudel juhtudel konsoolis kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti!";
            //kasutajal on kolm katset

       

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna, teil on {3 - i} katset jäänud.");
                }
              
            }






        }
    }
}

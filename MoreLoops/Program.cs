using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnuse ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis programm kuvab konsoolis "Tere tulemast!";
            //muudel juhtudel konsoolis kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti!";


            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            //AND (&&) 

            //"admin" AND "admin1234" --> true 
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin123" --> false

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna, proovi uuesti!");
            }


              




            

        }
    }
}

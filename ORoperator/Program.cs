using System;

namespace ORoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnuse ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis programm kuvab konsoolis "Tere tulemast!";
            //muudel juhtudel konsoolis kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti!";

            //OR || (pipes)

            //true || true --> true (mõlemad operandid tõesed)
            //false || true --> true (üks operant tõene)
            //true || false --> true 
            //false || false --> false 


            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna, proovi uuesti!");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //"admin1" != "admin" || "admin1234" != "admin1234" --> true || false --> true;
            //"admin" != "admin" || "admin123" != "admin1234" --> false || true --> true;
            //"admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true;
            //"admin" != "admin" || "admin1234" != "admin1234" --> false || false --> false;



        }
    }
}

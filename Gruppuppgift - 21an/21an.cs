using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Gruppuppgift___21an;

class Program
{
    static void Main(string[] args)
    {

        bool spela = true;

        string name = "Ingen har vunnit mot datorn än!";

        while(spela){
        Console.WriteLine(" ");
        Console.WriteLine("Välkommen till 21:an!\nVälj ett alternativ");
        Console.WriteLine("1. Spela 21:an");
        Console.WriteLine("2. Visa senaste vinnaren");
        Console.WriteLine("3. Spelets regler");
        Console.WriteLine("4. Avsluta programmet");
        int val = int.Parse(Console.ReadLine());
        
        if (val == 1){

            int spelarePoäng = 0;
            int datorPoäng = 0;

            Random rnd = new Random();

            spelarePoäng = rnd.Next(1,11) + rnd.Next(1,11);
            datorPoäng = rnd.Next(1,11) + rnd.Next(1,11);

            Console.WriteLine(" ");
            Console.WriteLine("Nu kommer två kort dras per spelare");
            Console.WriteLine($"Din poäng: {spelarePoäng}");
            Console.WriteLine($"Datorns poäng: {datorPoäng}");

            while (spelarePoäng < 21){
                Console.WriteLine("Vill du har ett kort till?");
                string forts = Console.ReadLine();

                    if((forts =="j" ) || (forts == "J")){
                        int nyttKort = rnd.Next(1,11);
                        Console.WriteLine(" ");
                        Console.WriteLine($"Ditt nya kort är värt {nyttKort} poäng");
                        spelarePoäng += nyttKort;
                        Console.WriteLine($"Din totalpoäng är {spelarePoäng}");
                        Console.WriteLine($"Din poäng: {spelarePoäng}");
                        Console.WriteLine($"Datorns poäng: {datorPoäng}");
                        
                    }
                    else if((forts == "n") || (forts == "N")){
                        break;
                    } 
                    if(spelarePoäng > 21){
                        Console.WriteLine(" ");
                        Console.WriteLine($"Du förlorade, datorn vann"); //Lägga till vem som vann till val 2 
                    }
            }
                    
                if(spelarePoäng <= 21){
                while(datorPoäng < 21 && datorPoäng < spelarePoäng){
                        Thread.Sleep(500);
                        int nyttKort = rnd.Next(1,11);
                        Console.WriteLine(" ");
                        Console.WriteLine($"Datorn drog ett kort värt {nyttKort} poäng");
                        datorPoäng += nyttKort;
                        Console.WriteLine($"Din totalpoäng är {spelarePoäng}");
                        Console.WriteLine($"Din poäng: {spelarePoäng}");
                        Console.WriteLine($"Datorns poäng: {datorPoäng}");        
                }

                if(datorPoäng > 21){
                    Console.WriteLine($"Datorn förlorade, du vann!"); //Lägga till vem som vann till val 2
                    Console.WriteLine("Vad heter du som vann?");
                    name = Console.ReadLine();

                    }
                if(datorPoäng >= spelarePoäng && datorPoäng <= 21){
                            Console.WriteLine($"Du förlorade, datorn vann"); //Lägga till vem som vann till val 2
                            
                    }
                }
        }

            else if(val == 2){
                Console.WriteLine(" ");
                Console.WriteLine($"Senaste vinnaren: {name}");
            }
            else if(val == 3){
                Console.WriteLine(" ");
                Console.WriteLine("I 21:an kommer du att spela mot datorn och försöka tvinga datorn att få över 21 poäng. Både du och datorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng. När spelet börjar dras två kort till både dig och datorn. Därefter får du dra hur många kort som du vill tills du är nöjd med din totalpoäng, du vill komma så nära 21 som möjligt utan att få mer än 21 poäng. När du inte vill dra fler kort så kommer datorn att dra kort tills den har mer eller lika många poäng som dig.\n\nDu vinner om datorn får mer än totalt 21 poäng när den håller på att dra kort. Datorn vinner om den har mer poäng än dig när spelet är slut så länge som datorn inte har mer än 21 poäng. Om det skulle bli lika i poäng så vinner datorn. Om du får mer än 21 poäng när du drar kort så har du förlorat.");
                Console.WindowWidth = 120;
                
            }
            else if(val == 4){
                Console.WriteLine("Programmet avslutas");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
        }
    }
}

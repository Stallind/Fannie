using FannieExercise;

internal class Program : Greeting
{
    private static void Main(string[] args)
    {
        var gr = new Greeting();

        gr.SayHello();

        Console.WriteLine(gr.SendGreeting(IGreeting.Greetings.Hello));
        Console.WriteLine(gr.SendGreeting(IGreeting.Greetings.Goodbye));

       
    }

  
}


/* 
 * 
Uppgift, abstrahera SayHello() till en egen klass som heter Greeting. 
Kalla på den ifrån Main-metoden. (Den får inte vara static)

 Skapa ett Interface för Greeting-klassen.

 Skapa en Enum som heter Greetings, den ska innehålla Hello och Goodbye.

 Lägg till en ny metod i Greeting-klassen som heter SendGreeting.

 Den ska ta en Enum som inparameter och returnera en sträng.

 När du skickar in Enum.Hello, ska texten "Hello world" returneras.
 När du skickar in Enum.Goodbye ska texten "Goodbye world" returneras.

 Kalla på metoden med de olika alternativen ifrån main-metoden och skriv ut dom i console.

*/
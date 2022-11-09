using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FannieExercise.IGreeting;

namespace FannieExercise
{
    internal class Greeting : IGreeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }


        public string SendGreeting(IGreeting.Greetings greetings)
        {
            switch (greetings)
            {
                case IGreeting.Greetings.Hello:
                    return "Hello World";

                case IGreeting.Greetings.Goodbye:
                    return "Goodbye World";

                default:
                    return "not found";

            }
        }

       
    }
}


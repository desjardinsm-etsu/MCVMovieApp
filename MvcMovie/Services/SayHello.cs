using System;
namespace MVCMovie.Services
{
    public class SayHello : ISayHello
    {
        public int Number { get; init; }

        public SayHello()
        {
            Number = new Random().Next();
        }

        public string Hello()
        {
            return "Hello!";
        }


    }
}

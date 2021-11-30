using System;
namespace MVCMovie.Services
{
    public class AnotherSayHello : ISayHello
    {
        public int Number { get; init; }

        public AnotherSayHello()
        {
            Number = 25;
        }

        public string Hello()
        {
            return "I will always say Hello!";
        }
    }
}

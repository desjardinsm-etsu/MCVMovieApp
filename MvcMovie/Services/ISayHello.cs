using System;
namespace MVCMovie.Services
{
    public interface ISayHello
    {
        public int Number { get; init; }

        public string Hello();

    }
}

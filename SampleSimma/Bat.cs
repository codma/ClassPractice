using System;
namespace SampleSimma
{
    public class Bat : ICreature, IMonster
    {
        public Bat()
        {
        }

        public string Breath()
        {
            return "숨";
        }

        public string Die()
        {
            return "끝";
        }

        public string Eat()
        {
            return "3끼";
        }

        public string Fly()
        {
            return "날다";
        }

        public string Live()
        {
            return "살아있다";
        }

        public string Sleep()
        {
            return "8시간";
        }
    }
}

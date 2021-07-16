using System;
namespace SampleSimma
{
    public class Animal : ICreature
    {
        public Animal()
        {

        }

        public string Breath()
        {
            return "숨";
        }

        public string Sleep()
        {
            return "8시간";
        }

        public virtual string Eat()
        {
            return "3끼";
        }

        public string Die()
        {
            return "끝";
        }

        public string live()
        {
            return "살아있다";
        }
    }
}

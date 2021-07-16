using System;
namespace SampleSimma
{
    public class Calc
    {
        public Calc()
            //반환형태가 없는 것은 생성자라고 함

        {
            Plus(1, 2);

        }

        public int Calculate(string oper, int firstNum, int secondNum)
        {
            int result = 0;
            switch (oper)
            {
                case "+":
                    {
                        result = Plus(firstNum, secondNum);
                        break;
                    }
                case "-":
                    {
                        result = Minus(firstNum, secondNum);
                        break;
                    }
                case "*":
                    {
                        result = Multi(firstNum, secondNum);
                        break;
                    }
                case "/":
                    {
                        result = Div(firstNum, secondNum);
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
            return result;
        }


        public int Plus(int firstNum, int secondNum)
        {
            int result = 0;

            result = firstNum + secondNum;

            return result;
        }


        public int Minus(int firstNum, int secondNum)
        {
            int result = 0;

            result = firstNum - secondNum;

            return result;
        }


        public int Multi(int firstNum, int secondNum)
        {
            int result = 0;

            result = firstNum * secondNum;

            return result;
        }


        public int Div(int firstNum, int secondNum)
        {
            int result = 0;

            result = firstNum / secondNum;

            return result;
        }

        
    }
}

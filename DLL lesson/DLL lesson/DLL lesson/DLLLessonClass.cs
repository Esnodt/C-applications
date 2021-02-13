using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_lesson
{
    public static class DLLLessonClass
    {
        public static int Addition(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public static int Substraction(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public static int Multiplication(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public static int Division(int firstNum, int secondNum)
        {
            if(secondNum == 0)
            {
                return 0;
            }
            else
            {
                return firstNum / secondNum;
            }
        }
    }
}

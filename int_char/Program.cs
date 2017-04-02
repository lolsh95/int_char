using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_char
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue; //لمعرفة القيمة الادنى للكاركتر
            int charMax = char.MaxValue;// لمعرفة القيمة القصوى للكركتر

            char value = 'A';
            int Vo = 65;
            int vo1 = 71; //لتحويل الارقام الى حروف 
            char myVal = Convert.ToChar(Vo); //نسخدم هذا لطريقة 

            Console.Write("\nValue Min = {0}\nValue Max = {1}\nValues = {2}\nMY Valuee = {3}", charMin, charMax, value,myVal);
            Console.ReadKey();
        }
    }
}

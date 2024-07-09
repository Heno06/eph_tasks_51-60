using System.Numerics;

namespace eph_tasks_51_60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int first_digit = a / 100;
            int second_digit = a % 100 / 10;
            int third_digit = a % 10;
            bool sum = true;    
            sum = third_digit==second_digit+first_digit ? true : false;
            Console.WriteLine(sum);
            sum = first_digit == second_digit || first_digit == third_digit || second_digit == third_digit ? true : false;\
            Console.WriteLine(sum);
            int digit_sum = first_digit+second_digit+third_digit;
            float ratio2 = (float)digit_sum / (float)a;
            float ratio = (float)a/ (float)digit_sum;
            float output = 0;
            output = a>ratio ? ratio : ratio2;
            Console.WriteLine(output);
            int max = 0;
            max = first_digit>second_digit ? first_digit: second_digit;
            max = max>third_digit ? max : third_digit;
            Console.WriteLine(max);
            int min = 0;
            min = first_digit < second_digit ? first_digit : second_digit;
            min = min < third_digit ? min : third_digit;
            Console.WriteLine(min);
            output = third_digit > second_digit ? ratio2 : a;
            Console.WriteLine(output);
            output = a>300 ? second_digit/third_digit : first_digit/third_digit;
            Console.WriteLine(output);

        }
    }
}

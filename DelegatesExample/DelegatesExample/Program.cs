using System;
using System.Threading;

namespace DelegatesExample
{
    class Program
    {
        private delegate void CallMethod();
        private static void Func1()
        {
            Thread.Sleep(1000);
        }

        private static void Func2()
        {
            Thread.Sleep(2000);
        }

        private static void Func3()
        {
            Thread.Sleep(3000);
        }

        private static double MeasureExecutionTime(CallMethod callMethodExecute)
        {
            var executionTimeStart = DateTime.Now;
            callMethodExecute();
            var executionTimeEnd = DateTime.Now;
            return (executionTimeEnd - executionTimeStart).TotalMilliseconds;
        }

        private delegate double Calcultate(double val1, double val2);


        static void Main(string[] args)
        {
            Console.WriteLine($"Tiempo de Ejecución de función 1 : {MeasureExecutionTime(Func1)}");
            Console.WriteLine($"Tiempo de Ejecución de función 2 : {MeasureExecutionTime(Func2)}");
            Console.WriteLine($"Tiempo de Ejecución de función 3 : {MeasureExecutionTime(Func3)}");

            //Sustitución de funciones 1, 2 y 3
            Console.WriteLine($"Tiempo de Ejecución de función 1 : {MeasureExecutionTime(()=> Thread.Sleep(1000))}");
            Console.WriteLine($"Tiempo de Ejecución de función 1 : {MeasureExecutionTime(() => Thread.Sleep(2000))}");
            Console.WriteLine($"Tiempo de Ejecución de función 1 : {MeasureExecutionTime(() => Thread.Sleep(3000))}");

            //Asignación de lamda a delegate
            Calcultate c = (d1,d2) => d1 * d2;
            var result = c(25,35);

            Console.ReadKey();
        }
    }
}

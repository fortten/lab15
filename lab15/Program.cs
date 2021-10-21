using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    /* Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
     * - метод void setStart(int x) - устанавливает начальное значение;
     * - метод int getNext() - возвращает следующее число ряда;
     * - метод void reset() - выполняет сброс к начальному значению.
     * Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
     * В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное значение прорессии: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество элементов прогрессии: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Арифметическая прогрессия с шагом d = 2");
            ArithProgressin arith = new ArithProgressin();
            arith.SetStart(start);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arith.GetNext() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессия с знаминателем q = 3");
            GeomProgression geom = new GeomProgression();
            geom.SetStart(start);
            for (int i = 0; i < n; i++)
            {
                Console.Write(geom.GetNext() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void SetStart(int x);

        int GetNext();

        void Reset();
    }
    public abstract class Progression : ISeries
    {
        public int Start { get; set; }
        public int Current { get; set; }

        public void SetStart(int x)
        {
            Start = x;
            Current = Start;
            Console.Write(Current + " ");
        }

        public abstract int GetNext();

        public void Reset()
        {
            Start = Current;
            Console.Write(Start + " ");
        }
    }
    class ArithProgressin : Progression
    {
        public override int GetNext()
        {
            Current+=2;
            return Current;
        }
    }
    class GeomProgression : Progression
    {
        public override int GetNext()
        {
            Current *= 3;
            return Current;
        }
    }
}

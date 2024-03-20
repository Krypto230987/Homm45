

namespace Home_45_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread vasyaThread = new Thread(VasyaMorningRoutine);
            vasyaThread.Start();
            vasyaThread.Join();
            Console.WriteLine($"Вася потратил {totalMinutes} минут на утреннюю рутину.");
        }

        static int totalMinutes = 0;

        static void VasyaMorningRoutine()
        {

            List<Task> tasks = new List<Task>
            {
                Task.Run(() => LieInBed()),
                Task.Run(() => BoilWater()),
                Task.Run(() => HeatUpDinner()),
                Task.Run(() => FillBath()),
                Task.Run(() => TakeBath()),
                Task.Run(() => EatBreakfast()),
                Task.Run(() => GetDressed()),
                Task.Run(() => DriveToWork())
            };
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine($"Вася потратил {totalMinutes} минут на утреннюю рутину.");
        }

        static void LieInBed()
        {
            Thread.Sleep(1500);
            totalMinutes += 15;
            Console.WriteLine("Вася лежал в кровати 15 минут.");
        }

        static void BoilWater()
        {
            Thread.Sleep(500);
            totalMinutes += 5;
            Console.WriteLine("Вася поставил чайник на плиту и ждал 5 минут, пока он закипит.");
        }

        static void HeatUpDinner()
        {
            Thread.Sleep(500);
            totalMinutes += 5;
            Console.WriteLine("Вася разогрел вчерашний ужин за 5 минут.");
        }

        static void FillBath()
        {
            Thread.Sleep(1000);
            totalMinutes += 10;
            Console.WriteLine("Вася набирал ванну 10 минут.");
        }

        static void TakeBath()
        {
            Thread.Sleep(1500);
            totalMinutes += 15;
            Console.WriteLine("Вася принимал ванну 15 минут.");
        }

        static void EatBreakfast()
        {
            Thread.Sleep(1000);
            totalMinutes += 10;
            Console.WriteLine("Вася завтракал 10 минут.");
        }

        static void GetDressed()
        {
            Thread.Sleep(500);
            totalMinutes += 5;
            Console.WriteLine("Вася одевался 5 минут.");
        }

        static void DriveToWork()
        {
            Thread.Sleep(5500);
            totalMinutes += 55;
            Console.WriteLine("Вася ехал на работу 55 минут.");
        }
    }
}

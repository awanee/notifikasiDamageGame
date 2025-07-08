using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objective: Kalahkan Monster Untuk Menyelamatkan Tuan Putri!");
            Console.WriteLine();
            Console.WriteLine("Battle Start!");
            Console.WriteLine("Tekan Angka 1 Untuk Basic Attack! (10 Damage)");
            Console.WriteLine("Tekan Angka 2 Untuk Tembakan Fire Ball! (20 Damage)");
            Console.WriteLine("Tekan Angka 3 Untuk Ultimate Attack! (40 Damage)");
            Console.WriteLine();
            Console.WriteLine("Nyawa Monster: 100");
            Karakter monster = new Karakter("Monster", 100);

            Serangan[] serangan = new Serangan[]
            {
                new SeranganDasar(10),
                new SeranganFireBall(20),
                new SeranganUltimate(40)
            };

            while (monster.Hidup)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyinfo.Key)
                {
                    case ConsoleKey.D1:
                        serangan[0].Eksekusi(monster);
                        break;
                    case ConsoleKey.D2:
                        serangan[1].Eksekusi(monster);
                        break;
                    case ConsoleKey.D3:
                        serangan[2].Eksekusi(monster);
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pertandingan Selesai, Tuan Putri Telah Diselamatkan!");
            Console.ReadKey(); 
        }
    }
}
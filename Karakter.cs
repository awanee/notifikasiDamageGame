using System;

namespace MyApp
{
    internal class Karakter
    {
        public string Nama { get; set; }
        public int Kesehatan { get; set; }
        public bool Hidup { get { return Kesehatan > 0; } }

        public Karakter(string nama, int kesehatan)
        {
            Nama = nama;
            Kesehatan = kesehatan;
        }

        public virtual void TakeDamage(int kerusakan)
        {
            Kesehatan -= kerusakan;
            if (Kesehatan < 0)
            {
                Kesehatan = 0;
            }

            Console.WriteLine($"{Nama} Menerima {kerusakan} Damage, Nyawa Sekarang: {Kesehatan}");
        }
    }
}
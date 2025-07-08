using System;

namespace MyApp
{
    internal class SeranganFireBall : Serangan
    {
        private int Kerusakan { get; }

        public SeranganFireBall(int kerusakan)
        {
            this.Kerusakan = kerusakan;
        }

        public void Eksekusi(Karakter target)
        {
            target.TakeDamage(Kerusakan);
            if (!target.Hidup)
            {
                Console.WriteLine($"Monster Telah Mati! Anda Mendapatkan 5 Emas!");
            }
        }
    }
}
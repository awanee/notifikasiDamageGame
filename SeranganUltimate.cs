using System;

namespace MyApp
{
    internal class SeranganUltimate : Serangan
    {
        private int Kerusakan { get; }

        public SeranganUltimate(int kerusakan)
        {
            this.Kerusakan = kerusakan;
        }

        public void Eksekusi(Karakter target)
        {
            target.TakeDamage(Kerusakan);
            if (!target.Hidup)
            {
                Console.WriteLine($"Monster Telah Mati! Anda Mendapatkan 1 Kristal Sihir!");
            }
        }
    }
}
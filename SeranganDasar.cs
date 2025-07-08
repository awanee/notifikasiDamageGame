using System;

namespace MyApp
{
    internal class SeranganDasar : Serangan
    {
        private int Kerusakan { get; }

        public SeranganDasar(int kerusakan)
        {
            this.Kerusakan = kerusakan;
        }

        public void Eksekusi(Karakter target)
        {
            target.TakeDamage(Kerusakan);
            if (!target.Hidup)
            {
                Console.WriteLine($"Monster Telah Mati! Anda Mendapatkan 10 Perak!");
            }
        }    
    }
}
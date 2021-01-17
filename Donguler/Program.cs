using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] 
            { 
                "yazılım geliştirici yetiştirme kampı ", "programlamaya başlangıç için temel kurs", "java kursu", "python", "c#"
            };


            for (int i = 0; i<kurslar.Length; i++)    // (başlangıç;şart;artış)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-for bitti-");

            foreach (string kurs in kurslar)    // foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}

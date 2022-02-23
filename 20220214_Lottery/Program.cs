using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220214_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int index = 0;
            int[] numbers = new int[6];
            int[] guesses = new int[6];

            while (index < 6)
            {
                int number = random.Next(1, 50);
                if (!numbers.Contains(number))
                {
                    numbers[index] = number;
                    index++;
                }
            }

            Console.WriteLine("Lütfen 1 ile 49 arası 5 adet sayı tahmin ediniz.");

            index = 0;

            while (index < 6)
            {
                int number = 0;

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number < 1)
                    {
                        Console.WriteLine("Tahmininiz 0'dan büyük olmalıdır.");
                    }

                    else if (number > 49)
                    {
                        Console.WriteLine("Tahmininiz 50'den küçük olmalıdır.");

                    }

                    else if (guesses.Contains(number))
                    {
                        Console.WriteLine("Bu tahmini zaten yaptınız.");

                    }
                    else
                    {
                        guesses[index] = number;
                        index++;

                        if (index < 6)
                        {
                            Console.WriteLine("Bir sonraki tahmininizi yapabilirsiniz.");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Lütfen bir tamsayı giriniz.");
                }
            }

            int score = 0;

            foreach(int number in guesses)
            {
                if (numbers.Contains(number))
                {
                    score++;
                }
            }

            Console.WriteLine("Score: " + score);

            string lucky_numbers = "Şanslı sayılar: ";

            foreach(int number in numbers)
            {
                lucky_numbers += number + " ";
            }

            Console.WriteLine(lucky_numbers);

            ////////////////////////////////////////////////////////////////

            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}

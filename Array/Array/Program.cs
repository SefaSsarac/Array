using System;

class Program
{
    static void Main()
    {
        // 1. Pratik: 10 adet tam sayı verisi alacak bir dizi tanımlama

        int[] sayilar = new int[10];

        // 2. Pratik:  Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazdırma

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = i;
        }
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        // 3. Pratik:  Bu diziye kullanıcıdan alınan yeni bir değeri ekleme (11. eleman olarak)

        Console.WriteLine("Lutfen eklemek için bir sayi giriniz.");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        int[] yeniDizi = new int[sayilar.Length + 1];  // Yeni dizi boyutunu yeni eleman için 1 artırıyoruz

        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }
        // Yeni değeri son eleman olarak ekle
        yeniDizi[sayilar.Length] = yeniSayi;

        Console.WriteLine("Yeni dizi:");

        foreach (int item in yeniDizi)
        {
            Console.WriteLine(item + "");
        }

        // 4. Pratik: Diziyi büyükten küçüğe ekrana yazdırma

        for (int i = 0; i < yeniDizi.Length - 1; i++)
        {
            for (int j = 0; j < yeniDizi.Length - i - 1; j++)
            {
                if (yeniDizi[j] < yeniDizi[j + 1])
                {
                    // Elemanları yer değiştirme
                    int temp = yeniDizi[j];
                    yeniDizi[j] = yeniDizi[j + 1];
                    yeniDizi[j + 1] = temp;
                }
            }
        }
    }
}  
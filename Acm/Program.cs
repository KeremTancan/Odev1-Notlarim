char yanıt;
do
{
    Random x = new Random();
    int s, tahmin, i;
    s = x.Next(100) + 1;



    Console.WriteLine("Tuttuğum sayıyı tahmin et");


    for (i = 1; i <= 5; i++)
    {

        tahmin = Convert.ToInt32(Console.ReadLine());

        if (tahmin == s)
        {
            Console.WriteLine("Tuttuğum sayıyı {0}. denemede buldun", i);
        }
        if (tahmin > s)
        {
            Console.WriteLine("Daha aşağı");
        }
        if (tahmin < s)
        {
            Console.WriteLine("Daha yukarı");
        }

    }
    Console.WriteLine("Tuttuğum sayı {0} idi", s);
    Console.WriteLine("Tekrar oynamak ister misin? (e/h)");
    yanıt = Convert.ToChar(Console.ReadLine());



} while (yanıt == 'e' || yanıt == 'E');
		
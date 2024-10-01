int sayac1 = 0;
while (sayac1 < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac1++;
}
int sayac2 = 1;
while (sayac2 <= 20) // 1 ile 20 arasındaki sayıları konsol ekranına yazdırır
{
    Console.WriteLine(sayac2);
    sayac2++;
}
int sayac3 = 1;
while (sayac3 <= 20) //  1 ile 20 arasındaki çift sayıları konsol ekranına yazdırır
{
    if (sayac3 % 2 == 0)
    {
        Console.WriteLine(sayac3);
    }
    sayac3++;
}
int sayac4 = 50;
int toplam4 = 0;
while (sayac4 <= 150) //  50 ile 150 arasındaki sayıların toplamını ekrana yazdırır
{
    toplam4 += sayac4;
    sayac4++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam4);
int sayac5 = 1;
int ciftToplam = 0;
int tekToplam = 0;

while (sayac5 <= 120) // 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırır
{
    if (sayac5 % 2 == 0)
    {
        ciftToplam += sayac5;
    }
    else
    {
        tekToplam += sayac5;
    }
    sayac5++;
}

Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);


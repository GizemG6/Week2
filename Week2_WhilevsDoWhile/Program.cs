// while
Console.Write("Bir limit değeri giriniz: ");
int limit1 = int.Parse(Console.ReadLine());

int sayac1 = 0;

while (sayac1 <= limit1)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac1++;
}

// do-while
Console.Write("Bir limit değeri giriniz: ");
int limit2 = int.Parse(Console.ReadLine());

int sayac2 = 0;

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;
}
while (sayac2 <= limit2);

// while döngüsü:
// - Eğer kullanıcı negatif bir limit değeri girerse, koşul en başta false olacağından, döngüye hiç girmez.
// - Örneğin limit değeri -5 olduğunda "Ben bir Patika'lıyım" hiç yazdırılmadan program sonlanır.

// do-while döngüsü:
// - Döngü önce bir kez çalışır, daha sonra koşul kontrol edilir. Bu nedenle negatif bir limit değeri girilmiş olsa bile en az bir kere "Ben bir Patika'lıyım" yazdırılır.
// - Örneğin limit değeri -5 olduğunda bile bir kez "Ben bir Patika'lıyım" yazdırılacaktır.
// Hапишите программу , которая 
// принимает на вXод число ( N ) и выдаëт таблицу 
// квадратов чисел от 1 до N. 
// 5 - > 1 , 4 , 9 , 16 , 25 . 
// 2 - > 1,4 
Console.WriteLine ( " Bведите число " );
int number = Convert.ToInt32 ( Console.ReadLine ( ) );
int count = 1;
while ( count <= number )
{
    Console.WriteLine ($" чиcлo { count , 5 } | Kвадрат { count * count , 5 } " );
    count ++;
}
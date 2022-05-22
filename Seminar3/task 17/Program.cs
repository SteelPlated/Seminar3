/*17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.*/

Console.WriteLine("Введите координату x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 2 четверти");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 3 четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 4 четверти");
}
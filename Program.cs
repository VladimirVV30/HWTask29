// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]


int[] mass(int N)
{
    int[] mass = new int[N];

    for (int i = 0; i < N; i++)
    {
        System.Console.Write ($"Введите {i+1} элемент массива ");
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mass;
}

try
{
    System.Console.Write("Введите размер массива ");
    int a = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine("Создан массив из "+ a +" элементов со значениями: " + String.Join(", ", mass(a)));
}
catch
{
    System.Console.WriteLine("Необходимо ввести число цифрами!");
}
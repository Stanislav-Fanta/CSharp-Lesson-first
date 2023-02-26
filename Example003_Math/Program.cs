//Алгоритм сложения чисел//
// Console.WriteLine("Введите первое и второе число: ");
// int FirstNumber = int.Parse(Console.ReadLine());
// int SecondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine(FirstNumber+SecondNumber);

//Алгоритм деления чисел с десетичными дробями//
// Console.WriteLine("Введите первое и второе число: ");
// double FirstNumber = int.Parse(Console.ReadLine());
// double SecondNumber = int.Parse(Console.ReadLine()); // double это тип данных, потдеживающий дроби и не целые числа
// Console.WriteLine(FirstNumber/SecondNumber);

//Алгоритм сложения рандомных чисел от 1 до 9
int FirstNumber = new Random().Next(1, 10); // Команда, которая создает новое рандомное целое число в диапазоне 1 - 9 включительно
Console.WriteLine(FirstNumber);
int SecondNumber = new Random().Next(1, 10);
Console.WriteLine(SecondNumber);
Console.WriteLine(FirstNumber + SecondNumber);
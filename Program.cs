// Задание 1.1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

// Задание 1.2
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.WriteLine(i);
// }

// Задание 2
// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if (i % 7 == 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Сумма кратных 3: {sum}");
// Console.WriteLine($"Количество кратных 7: {count}");

// Задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int positive = 0;
// int negative = 0;

// while (number != 0)
// {
//     if (number > 0)
//     {
//         positive++;
//     }
//     else if (number < 0)
//     {
//         negative++;
//     }

//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"Положительных: {positive}");
// Console.WriteLine($"Отрицательных: {negative}");

// Задание 4
// bool dostyp = false;

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine("Введите пароль: ");
//     string password = Console.ReadLine();

//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешён");
//         dostyp = true;
//         break;
//     }
// }

// if (!dostyp)
// {
//     Console.WriteLine("Доступ заблокирован");
// }

// Задание 5
// Console.Write("Введите число от 1 до 9: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }

// Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }

//     if (i % 10 == 0 && i > 20)
//     {
//         break;
//     }

//     Console.WriteLine(i);
// }

// Угадай число
// int secret = 42;
// bool win = false;

// for (int i = 1; i <= 5; i++)
// {
//     Console.Write($"Попытка {i}. Введите число: ");
//     int otvet = Convert.ToInt32(Console.ReadLine());

//     if (otvet == secret)
//     {
//         Console.WriteLine($"Победа! Попыток: {i}");
//         win = true;
//         break;
//     }
//     else if (otvet > secret)
//     {
//         Console.WriteLine("Меньше");
//     }
//     else
//     {
//         Console.WriteLine("Больше");
//     }
// }

// if (!win)
// {
//     Console.WriteLine("Вы проиграли, число было 42");
// }

// Задание со звездочкой
// Console.Write("Введите целое положительное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int count = 0;

// while (n > 0)
// {
//     sum += n % 10;
//     count++;
//     n /= 10;
// }

Console.WriteLine($"Сумма цифр: {sum}");
Console.WriteLine($"Количество цифр: {count}");
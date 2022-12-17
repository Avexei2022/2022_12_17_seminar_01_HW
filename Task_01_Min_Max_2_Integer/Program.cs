// Чистим терминал
Console.Clear();  

// Выведем на экран условия Задачи 2
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа");
Console.WriteLine("и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("a = 5; b = 7 -> max = 7");
Console.WriteLine("a = 2 b = 10 -> max = 10");
Console.WriteLine("a = -9 b = -3 -> max = -3");
Console.WriteLine(""); // Разделим условия задачи пустой строкой

// Просим ввести значение первого числа и проверяем его на соответствие условиям
Console.Write("Введите первое целое число 'a' в диапазоне от -100 до 100: "); // Ограничимся в цифрах
int first_number = 0; // присваиваем имя, тип и значение (все равно будет ввелено новое) переменной первого числа
int.TryParse(Console.ReadLine(), out first_number); // пытаемся перевести введенные пользователем символы в целое число
while (first_number < -100 | first_number > 100) // проверяем введенное значение на соответствие условиям
// до конца пока не разобрался с отрицательным диапазоном, поскольку при его наличии в условии и вводе символа пограмма выдает true
{
    Console.WriteLine("Вы не выполнили условия!");
    Console.Write("Повторите ввод: ");
    int.TryParse(Console.ReadLine(), out first_number); // пытаемся перевести введенные пользователем символы в целое число уже в цикле
}
Console.WriteLine(""); // Отделяем пустой для наглядности

// Просим ввести значение второго числа и проверяем его на соответствие условиям
Console.Write("Введите второе целое число 'b' в диапазоне от -100 до 100: "); // Ограничимся в цифрах
int second_number = 0; // присваиваем имя, тип и значение (все равно будет ввелено новое) переменной второгоо числа
int.TryParse(Console.ReadLine(), out second_number); // пытаемся перевести введенные пользователем символы в целое число
while (second_number < -100 | second_number > 100) // проверяем введенное значение на соответствие условиям
// до конца пока не разобрался с отрицательным диапазоном, поскольку при его наличии в условии и вводе символа пограмма выдает true
{
    Console.WriteLine("Вы не выполнили условия!");
    Console.Write("Повторите ввод: ");
    int.TryParse(Console.ReadLine(), out second_number); // пытаемся перевести введенные пользователем символы в целое число уже в цикле
}
Console.WriteLine(""); // Отделяем пустой для наглядности

Console.WriteLine($"Сравниваем число a = {first_number} и число b = {second_number}"); 

if (first_number > second_number) // Если первое число больше второго выводим на экран соответствующие результаты
{
    Console.WriteLine($"Число a = {first_number} больше числа b = {second_number}.");
    Console.WriteLine($"Иначе сказать: число a = {first_number} является максимальным из двух чисел {first_number} и {second_number},");
    Console.WriteLine($"а число b = {second_number} является минимальным из двух чисел {first_number} и {second_number}.");
}
else
{
    if (first_number == second_number) // Проверяем на равенство чисел и если числа равны выводим сообщение
    {
        Console.WriteLine($"Число a = {first_number} равно числу b = {second_number}.");
        Console.WriteLine($"Иначе сказать: a = b");
    }
    else // И если первое число не больше и не равно второму, т.е. меньше его, выводим соответствующее сообщение
    {
    Console.WriteLine($"Число b = {second_number} больше числа a = {first_number}.");
    Console.WriteLine($"Иначе сказать: число b = {second_number} является максимальным из двух чисел {first_number} и {second_number},");
    Console.WriteLine($"а число a = {first_number} является минимальным из двух чисел {first_number} и {second_number}.");
    }
}
Console.WriteLine(""); // Отделяем пустой для наглядности
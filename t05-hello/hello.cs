int number = 2026;
int digitSum = 0;
int digitCount = 0;

while (number > 0)
{
// ошибка 1
// строка: digitSum += number / 10;
// переменная: number
// на остановке number = 2026, а number / 10 даёт 202
// а должно быть 6 (последняя цифра)
// просто перепутал / и %

    digitSum += number % 10;   // поправил

    digitCount++;
    number /= 10;
}

// ошибка 2
// строка: while (number > 0)
// переменная: number
// когда number = 0, цикл вообще не заходит
// а 0 — это одна цифра, digitCount должен быть 1, сумма 0
// цикл просто пропускает ноль

if (digitCount == 0)
{
    digitCount = 1;
}

Console.WriteLine($"Цифр: {digitCount}, сумма цифр: {digitSum}");

// Здравствуйте, Ергали :D
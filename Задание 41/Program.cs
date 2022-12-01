//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int m = 5;
Console.WriteLine($"Введите {m} целых чисел в строку через пробел:");
string strNumbers = Console.ReadLine(); //Пользователь вводит с клавиатуры M чисел
char[] charSeparators = new char[] {' ', ',', ';'}; //Символы, которыми пользователь возможно разделял числа
string[] arrNumbers = strNumbers.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries); //Производим разделение строки, введённой пользователем и получаем массив строк с числами
if (arrNumbers.Length > m) //Если чисел введено больше, чем м, мы проверим только первые м чисел (не знаю почему, но это есть в условии)
{
    Console.WriteLine("Вы ввели больше чисел. Я проверю только первые " + m);
}
int[] numbers = new int[arrNumbers.Length];
int count = 0;
for (int i = 0, i < arrNumbers.Length, i++) //Конвертируем массив строк в массив чисел и проверяем больше ли оно 0, если да, то к счётчику прибавляем единицу.
{
    Console.Write(arrNumbers[i] + " ,");
    numbers[i] = Convert.ToInt32(arrNumbers[i]);
    if (numbers[i] > 0)
    {
        count = count + 1;
    }
}

Console.WriteLine()

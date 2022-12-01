//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)


double[] StrToIntArray(string strNumbers, char[] charSeparators) //Метод из строки выдаёт массив целых чисел
{
    string[] arrNumbers = strNumbers.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries); //Производим разделение строки, введённой пользователем и получаем массив строк с числами
    double[] numbers = new double[arrNumbers.Length];
    for (int i = 0; i < arrNumbers.Length; i++) //Конвертируем массив строк в массив чисел
    {
        Console.Write(arrNumbers[i] + " ,"); //использовал для отладки
        numbers[i] = Convert.ToDouble(arrNumbers[i]);
    }
    return numbers;
}

Console.WriteLine("Введите первую Функцию в формате kx + b: ");
Console.Write("y1 = ");
string strNumbers = Console.ReadLine(); //Пользователь вводит с клавиатуры формулу
char[] charSeparators = new char[] { ' ', 'x', '+', '*', 'X', '-' }; //Определяем лишние символы в формуле
double[] array = StrToIntArray(strNumbers, charSeparators);
double k1 = array[0];// Получаем коэффициент k1
double b1 = array[1];// Получаем коэффициент b1

Console.WriteLine("Введите вторую Функцию в формате kx + b: ");
Console.Write("y2 = ");
strNumbers = Console.ReadLine(); //Пользователь вводит с клавиатуры формулу
array = StrToIntArray(strNumbers, charSeparators);
double k2 = array[0];// Получаем коэффициент k2
double b2 = array[1];// Получаем коэффициент b2
if (k1 == k2)
{
    Console.WriteLine("Эти прямые параллельны.")ж
        return;
}
(double, double) GetCrosses() //Метод для получения координат точки пересечения графиков прямых
{
    double get_x = (b2 - b1) / (k1 - k2);
    double get_y = k1 * get_x + b1;
    var result = (get_x, get_y);
    return result;
}

Console.WriteLine($"Точка пересечения данных функций: ({GetCrosses().Item1}, {GetCrosses().Item2})");

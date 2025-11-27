using Tyuiu.UlukhanovDV.Sprint5.Task5.V13.Lib;
// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти среднее значение всех чисел в файле, которые находятся            *");
Console.WriteLine("* в промежутке от -1.5 до 1.5. Полученный результат вывести на консоль.   *");
Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string path = @"C:\DataSprint5\InPutDataFileTask5V13.txt";
Console.WriteLine("Данные находятся в файле: " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();

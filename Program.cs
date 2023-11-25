using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Количество элементов для вставки
        int elementsCount = 1000000;

        // Создаем List и LinkedList
        List<int> list = new List<int>();
        LinkedList<int> linkedList = new LinkedList<int>();

        // Используем Stopwatch для измерения времени
        Stopwatch listStopwatch = new Stopwatch();
        Stopwatch linkedListStopwatch = new Stopwatch();

        // Измеряем время вставки в List
        listStopwatch.Start();
        for (int i = 0; i < elementsCount; i++)
        {
            list.Add(i);
        }
        listStopwatch.Stop();

        // Измеряем время вставки в LinkedList
        linkedListStopwatch.Start();
        for (int i = 0; i < elementsCount; i++)
        {
            linkedList.AddLast(i);
        }
        linkedListStopwatch.Stop();

        // Выводим результаты
        Console.WriteLine($"Время вставки в List: {listStopwatch.ElapsedMilliseconds} миллисекунд");
        Console.WriteLine($"Время вставки в LinkedList: {linkedListStopwatch.ElapsedMilliseconds} миллисекунд");
    }
}

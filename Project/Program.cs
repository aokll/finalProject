// See https://aka.ms/new-console-template for more information

/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

void Print(String[] arr)
	{
        String[] res = new String[arr.Length];

	    int num = arr.GetLength(0);
	
	    for (int i = 0; i < num; i++)
	    {
            if(i == 0){Console.Write("[");}
	            Console.Write($" {arr[i]} ");
            if(i == num - 1){Console.Write("] -> ");}

            if(arr[i].Length <= 3){
                res[i] = arr[i]; 
            }else{
                res[i] = "";
            }

	    }    
        for(int j = 0; j < res.Length; j++)
        {
             if(j == 0){Console.Write("[");}
	            Console.Write($" {res[j]} ");
            if(j == num - 1){Console.Write("]");}
        }
	}
	
String[] MassNums(int num)
{
    String[] arr = new String[num];

    for (int i = 0; i < arr.Length; i++)
    {
            Console.Write($"Введите значение {i} элемента массива: ");
            arr[i] = Console.ReadLine()!;
    }

    return arr;
}

	Console.Write("Задайте колличество элементов в массиве: ");
	int num = int.Parse(Console.ReadLine()!);
	
    String[] array = MassNums(num);

    Print(array); 


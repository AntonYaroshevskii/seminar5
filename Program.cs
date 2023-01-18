// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine($"Задача 34");
int[] evensumarray = GetArray(8, 100, 999);
Console.WriteLine($"[{String.Join(",",evensumarray)}]");
Console.WriteLine($"Количество четных чисел равна {FindEvenNum(evensumarray)}");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
Console.WriteLine($"Задача 36");
int[] countarray = GetArray(8, -100, 100);
Console.WriteLine($"[{String.Join(",",countarray)}]");
Console.WriteLine($"Сумма нечетных индексов равна {CountSum(countarray)}");

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

Console.WriteLine($"Задача 37");
int[] array = GetArray(5, 1, 10);
Console.WriteLine($"[{String.Join(",",array)}]");
int[] array1 = new int[array.Length]; 
int[] array2 = new int[array.Length / 2 + 1];
array2[array.Length / 2] = array[array.Length / 2];
for( int i = 0; i < array.Length / 2; i++ ){
    array1[i] = array[array.Length - i - 1];
    array2[i] = array[i] * array1[i];
}
Console.WriteLine($"[{String.Join(",",array2)}]");



//---------методы----------
// создания массива (общая)
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//подсчет четных чисел массива. Задача 34
int FindEvenNum(int[] array){
int count = 0;
    foreach (int el in array){
        if(el % 2 == 0){
            count += 1;
        }
    }
    return count;
}

//подсчет суммы чисел на нечетных индексах. Задача 36
int CountSum(int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2){
        sum += array[i];
    }
    return sum;
}
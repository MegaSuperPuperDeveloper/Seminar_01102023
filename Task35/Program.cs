// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] RandomNumbers(int length) {
    var rnd = new Random();
    int[] array = new int[length];
    for(int i = 0; i < length; i++) {
        array[i] = rnd.Next(1, 124);
    }
    PrintArray(array);
    return array;
}

void PrintArray(int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        if(i + 1 != array.Length) {
            Console.Write($"{array[i]}, ");
        } else {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountOfNumbers(int[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i] <= 99 && array[i] >= 10) {
            count++;
        }
    }
    return count;
}

Console.Write("Введите кол-во элементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = RandomNumbers(length);
Console.Write($" -> {CountOfNumbers(array)}");
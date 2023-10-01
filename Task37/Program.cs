// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



// Функция генерирует массив
int[] RandomNumbers(int length) {
    var rnd = new Random();
    int[] array = new int[length];
    for(int i = 0; i < length; i++) {
        array[i] = rnd.Next(1, 124);
    }
    return array;
}

// Функция выводит массив
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

// Функция умножает первый элемент на последний, второй на предпоследний и тд
int[] ProductsOfNums(int length, int[] array) {
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size += 1;
    int[] arrayU = new int[size];
    if(size % 2 == 0) {
        for(int i = 0; i < size; i++) {
            arrayU[i] = array[i] * array[length - i - 1];
        }
    } else {
        length++;
        for(int i = 0; i < size; i++) {
            if(length / 2 == i) {
                arrayU[i] = array[length / 2];
            } else {
                arrayU[i] = array[i] * array[length - i - 1];
            }
        }
    }
    return arrayU;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = RandomNumbers(length);
PrintArray(array);
int[] res = ProductsOfNums(8, array);
Console.Write(" -> ");
foreach(int i in res) {
    Console.Write($"{i} ");
}
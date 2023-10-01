// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// Меняет знаки всем элементам массива
int[] Otricanie(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        array[i] *= -1;
    }
    return array;
}

// Функция генерирует массив
int[] RandomNumbers(int length) {
    var rnd = new Random();
    int[] array = new int[length];
    for(int i = 0; i < length; i++) {
        array[i] = rnd.Next(-124, 124);
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

int[] array = RandomNumbers(8);
PrintArray(array);
Otricanie(array);
Console.WriteLine();
PrintArray(array);
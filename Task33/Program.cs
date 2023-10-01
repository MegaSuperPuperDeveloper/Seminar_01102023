// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



// Функция потверждает или опровергает наличие переменной в массиве
string IndexOf(int digit, int[] array) {
    for(int i = 0; i < array.Length; i++) {
        if(array[i] == digit) {
            return "да";
        } 
    }
    return "нет";
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

// Функция генерирует массив
int[] RandomNumbers(int length) {
    var rnd = new Random();
    int[] array = new int[length];
    for(int i = 0; i < length; i++) {
        array[i] = rnd.Next(1, 20);
    }
    return array;
}

int i = Convert.ToInt32(Console.ReadLine());
Console.Write($"{i}; ");
int[] array = RandomNumbers(20);
PrintArray(array);
Console.Write($" -> {IndexOf(i, array)}");
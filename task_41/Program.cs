/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Напишите количество вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] WriteArray (int size){
    int[] array = new int [size];
for (int i = 0; i<size;i++){
    Console.WriteLine("Введите число: ");
    array[i]= Convert.ToInt32(Console.ReadLine());
}
return array ;
}
void PrintArray (int[] array)  {
    for (int i = 0; i<array.Length; i++ ){
    if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
    else Console.Write ($"{array[i]}");
    }
    Console.Write("->");
}
int  PositiveDigit (int[] array){
    int count = 0;
    for (int i = 0; i < size; i++){
        if (array[i]>0) count ++;
    }
    return count;
}
int [] arr = WriteArray (size);
PrintArray (arr);
int Positive = PositiveDigit (arr);
Console.WriteLine(Positive);
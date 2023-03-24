// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 1 ++++++++++++++++++++++++++++++++++
// Console.Write("Ввесдите число А:  ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Ввесдите число B:  ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {A} в степени {B} равно {Count_pow(A, B)}");

// int Count_pow (int numberA, int numberB){
//     int i = 1;
//     int res = numberA;
//     while (i<numberB){
//         res = res*numberA;
//         i++;
//     }
//     return res;
// }

// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 2 ++++++++++++++++++++++++++++++++++
// Console.Write("Ввесдите число А:  ");
// String A =Console.ReadLine();
// int sum = Sum_dig(A);
// Console.WriteLine($"Сумма цифр в числе равна: {sum}");

// int Sum_dig(string A) {
//     int sum = 0;
//     for (int i = 0; i < A.Length; i++) {
//         if (char.IsDigit(A[i])) {
//             sum += int.Parse(A[i].ToString());
//         }
//     }
//     return sum;
// }
// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 3 ++++++++++++++++++++++++++++++++++
Console.WriteLine("Ввесдите мин число массива:  ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввесдите макс число массива:  ");
int B = int.Parse(Console.ReadLine()!);

int [] array = GetRandomArray(8,A,B);
Console.WriteLine($"[{String.Join(",", array)}]");

int [] GetRandomArray (int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

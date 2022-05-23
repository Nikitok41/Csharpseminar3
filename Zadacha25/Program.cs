/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int Stepen(int number1, int number2){
  int result = 1;
  for(int i=1; i <= number2; i++){
    result = result * number1;
  }
    // int result = Math.Pow(number1, number2);
    return result;
}

  Console.Write("Введите число A: ");
  int number1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int number2 = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Stepen(number1, number2);
  Console.WriteLine("Ответ: " + exponentiation);

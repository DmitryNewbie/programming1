Console.WriteLine("Введите число");
string num1 = Console.ReadLine();
int numInt1 = Convert.ToInt32(num1);
Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine();
int numInt2 = Convert.ToInt32(num2);
if (numInt1 < numInt2){
    Console.WriteLine("большее " + numInt2);
    Console.Write ("Меньшее " + numInt1);
}





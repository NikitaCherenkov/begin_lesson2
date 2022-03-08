// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 & num % 23 == 0) {
    Console.WriteLine("Кратно 7 и 23");
} else {
    Console.WriteLine("Не кратно 7 и 23");
}
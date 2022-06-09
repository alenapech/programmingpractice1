Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (n <= i) {
    Console.WriteLine("Четных чисел нет");
}

while (i <= n) {
    if (i%2 == 0) {
        Console.WriteLine(i);
    }
    i++;
}
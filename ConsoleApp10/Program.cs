Console.WriteLine("Введите сообщение: ");
string text = Console.ReadLine();
char ch = '*';
int indexOfChar = text.IndexOf(ch);
Console.WriteLine($"Смивол '{ch}' первый раз встречается на {indexOfChar + 1} позиции");
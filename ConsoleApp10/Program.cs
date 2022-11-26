Console.Write("Введите сообщение: ");
string text = Console.ReadLine();
char ch = '*';
int indexOfChar = text.IndexOf(ch);
if (indexOfChar > 0)Console.WriteLine($"Смивол '{ch}' первый раз встречается на {indexOfChar + 1} позиции");
else Console.WriteLine($"Символ '{ch}' в тексте не встречается");
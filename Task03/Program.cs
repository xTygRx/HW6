// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
bool IsPalindrome(string str){
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    System.Console.WriteLine($"Строка после удаления небуквенно-цифровых символов(например пробелов)  {normalized}");
    return normalized.SequenceEqual(normalized.Reverse());

}


string input = "ша1л1 аш";
System.Console.WriteLine($"Начальная строка   {input}");

bool isPalindrome = IsPalindrome(input);
System.Console.WriteLine(isPalindrome);


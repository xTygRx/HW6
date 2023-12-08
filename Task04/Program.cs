//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

string ReversWords(string str){

    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

System.Console.WriteLine("Введите строку");
string input = System.Console.ReadLine()!;
string resault = ReversWords(input);
System.Console.WriteLine(resault);

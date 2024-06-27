//Console.WriteLine("№1")
//Console.WriteLine("Введите ваше имя");
//string first_nameAnswer = Console.ReadLine();
//Console.WriteLine($"Ваше имя: {first_nameAnswer}");

//Console.WriteLine("№2");
//Console.WriteLine("Введите два слова, первое слово:");
//string First_textAnswer = Console.ReadLine();
//Console.WriteLine("Второе слово:");
//string Last_textAnswer = Console.ReadLine();

//if (String.Compare(First_textAnswer, Last_textAnswer) <= 0)
//{
//    Console.WriteLine(First_textAnswer);
//    Console.WriteLine(Last_textAnswer);
//}

//else
//{
//    Console.WriteLine(Last_textAnswer);
//    Console.WriteLine(First_textAnswer);
//}

//Console.WriteLine("№3");
//Console.WriteLine("Введите любое предложение:");
//string First_TextAnswer = Console.ReadLine();
//Console.WriteLine(First_TextAnswer.ToCharArray().Reverse().ToArray());

//Console.WriteLine("№4");
//Console.WriteLine("Введите любое предложение:");
//string First_TextAnswer = Console.ReadLine();
//char[] temptemp = First_TextAnswer.ToCharArray();
//Array.Reverse(temptemp);
//string First_TextAnswer2 = new string(temptemp);

//Console.WriteLine("№6");
//Console.WriteLine("Введите слово:");
//string str = Console.ReadLine();
//Console.WriteLine(str.Replace('а', 'о'));

//Console.WriteLine("№13");
//Console.WriteLine("Напишите любое предложение:");
//string First_TextAnswer = Console.ReadLine();
//string[] First_TextAnswer2 = First_TextAnswer.Split();

//for (int i = 0; i < First_TextAnswer.Length; i++)
//{
//    Console.WriteLine(First_TextAnswer[i]);
//}

//Console.WriteLine("№8");
//Console.WriteLine("Напишите любое предложение:");
//string First_TextAnswer = Console.ReadLine();
//string[] split = First_TextAnswer.Split(new Char[] { ' ' });
//for (int j = 0; j < split.Length;)
//{
//    if (First_TextAnswer.Trim() != "")
//    {
//        ++j;
//    }
//}
//Console.WriteLine(j);

//Console.WriteLine("№9");
//Console.WriteLine("Напишите любое предложение");
//string str1 = Console.ReadLine();
//string[] word = str1.Split(' ');
//int max = word[0].Length;
//int maxIndex = 0;

//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i].Length > max)
//    {
//        max = word[i].Length;
//        maxIndex = i;
//    }
//    Console.WriteLine(i);
//}


//Console.WriteLine("№15");
//Console.WriteLine("Напишите любое предложение: (ВНИМАНИЕ! Будет использоватся шифрование Цезаря)");
//string rim = Console.ReadLine();
//Console.WriteLine("Введите ключ:");
//int key_pass = Convert.ToInt32(Console.ReadLine());
//char[] temprim = rim.ToCharArray();

//for (int i = 0; i < temprim.Length; i++)
//{
//    char temp_a = temprim[i];

//    if (char.IsLetter(temp_a))
//    {
//        char ecryptoC = Convert.ToChar(temp_a + key_pass);

//        if (char.IsUpper(ecryptoC) && ecryptoC > 'Z')
//        {
//            ecryptoC = Convert.ToChar(ecryptoC - 26);
//        }

//        else if (char.IsUpper(ecryptoC) && ecryptoC < 'Z')
//        {
//            ecryptoC = Convert.ToChar(ecryptoC - 26);
//        }

//        temprim[i] = ecryptoC;
//        Console.WriteLine(temprim[i]);

//    }
//}

//Console.WriteLine("№5");
//Console.WriteLine("Введите любое предложение:");
//string str1 = Console.ReadLine().ToLower();
//string result = "";

//for (int i = 0; i < str1.Length; i++)
//{
//    char chars = str1[i];

//    if (result.Contains(chars) == false)
//    {
//        result += chars;
//    }
//}
//Console.WriteLine(result);

//Console.WriteLine("№10");
//Console.WriteLine("Введите любое предложение:");
//string str1 = Console.ReadLine();

//bool IsNumbered = true;

//for (int i = 0; i < str1.Length; i++)
//{
//    if (Char.IsDigit(str1[i]))
//    {
//        continue;
//    }

//    else
//    {
//        IsNumbered = false;
//        break;
//    }
//}

//if (IsNumbered == true)
//{
//    Console.WriteLine("Строка это число");
//}

//else
//{
//    Console.WriteLine("Ошибка!");
//}

//Console.WriteLine("№11");
//Console.WriteLine("Введите любое предложение:");
//string str1 = Console.ReadLine();
//string[] word_str1 = str1.Split();
//Console.WriteLine(str1.Length);

//Console.WriteLine("№7");
//Console.WriteLine("Введите первое слово: (проверка на ???)");
//string str1 = Console.ReadLine().ToLower();
//Console.WriteLine("Введите второе слово:");
//string str2 = Console.ReadLine().ToLower();

//char[] arr1 = str1.ToCharArray();
//char[] arr2 = str2.ToCharArray();
//Array.Sort(arr1);
//Array.Sort(arr2);

//str1 = new string(arr1);
//str2 = new string(arr2);

//if (str1 == str2)
//{
//    Console.WriteLine("Анаграммы");
//}

//else
//{
//    Console.WriteLine("Ошибка!");
//}

//Сделано: №1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 15.

//Не сделано: №13.
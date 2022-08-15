﻿// // Вид 1 Ничего не возвращают и ничего не принимают                      
// void Method1()      
// {
//     Console.WriteLine ("Автор");
// }

// // Они очень простые и выглядят следующим образом. 
// // Обратите внимание у нас ключевое слово void, наименование Method1, в скобках нет никаких аргументов и есть тело метода которое что-то может показывать на экран.
// // Следующий пункт который может быть интересен это вариант как вызываются подобного рода методы. 
// // Вызываются они очень просто

// Method1(); // Вы должны указать идентификатор этого метода и просто круглые скобки (открывающиеся и закрывающиеся) без них будет ошибка.






// //Вид 2 Ничего не возвращают, но могут принимать аргументы
// void Method2(string msg) 
// {
//     Console.WriteLine(msg);  
// }
// Method2(msg: "text message");

// // void ключевое слово, дальше идентификатор, дальше какое-то количество аргументов. 
// // Здесь мы можем указывать какие-то операторы и соответственно использовать те аргументы, которые были приняты. 
// // Для того чтобы вызвать такой метод нам требуется указать его идентификатор и дальше уже указывать какое-то сообщение.
// // Есть еще так называемые аргументы именованные, когда у нас явно может быть указано какому аргументу какое значение мы хотим указать, это бывает очень часто нужно, в случае если методы принимают какое-то количество аргументов отличное от одного. Method2(msg: "text message");. Давайте продемонстрируем это. 


// void Method21(string msg, int count)  // у нас есть месадж (msg) и какой-нибудь условный count (2 arguments)
// {
//     int i = 0;   // и здесь в нашем случае будет использоваться значение переменной count, для того чтобы показывать на экране определенное количество сообщений msg, которые 
//                  // будут передаваться непосредственно в наш метод
//     while (i < count) // и здесь (условия) нам нужно будет написать (i < count)
//     {
//         Console.WriteLine(msg);  // здесь запишем наш msg
//         i++;    
//     }          
// }
// Method21(msg: "text", count: 4);   // в таком варианте вызов нашего метода может осуществляться путем указания аргументов и дальше через запятую мы укажем сколько раз 
//                                    // мы конкретно хотим увидеть это сообщение                          
//                                    // Идея в том что мы можем в том числе явно указывать какому аргументу и какое значение мы хотим присвоить Method21(msg: "text", count: 4);
//                                    // через вот такую конструкцию, явно указываем именование вот этого вот аргумента  string msg (msg:  и дальше то значение которое должно будет быть передано) Именованное аргументы необязательно писать по порядку. 





// // Вид 3 Что-то возвращают, но ничего не принимают.

// int Method3 ()                                // если метод что-то возвращает мы в обязательном порядке должны будем указать тип данных значение которого мы ожидаем.  
// {                                             // для нас это будет Method3, аргументы он никакие не принимает и соответственно обязательно использование оператора return
//     return DateTime.Now.Year;                 // давайте здесь например для красоты просто выведем текущей datetime на возьмем текущий год
// }                                               
// int year = Method3();                         // например таким образом для того чтобы вот этот метод вызвать мы точно таким же образом должны будем указать имя 
// Console.WriteLine();                          // идентификатор метода дальше обязательно круглые скобки и после этого в левой части мы можем использовать идентификатор      
//                                               // переменной и через оператор присваивания положить нужное значение.  
//                                               // в дальнейшем уже использовать эту переменную это значение которое нам вернул метод, говоря вот таким образом т.е здесь  return DateTime.Now.Year; что-то произошло какая-то работа вот сюда вот year будет положен результат работы этого метода и дальше мы можем уже использовать.
                                                
                                            



 
// // Вид 4 Что-то принимают и что-то возвращают

// string Method4(int count, string text )           // возвращать будем строку, будем передавать int count
// {                                                 // строку "c (text)" будем друг за другом компоновать count раз
//     int i = 0;                                    // для начала возьмем цикл, дальше нам потребуется переменная (куда будем класть конечный результат)
//     string result = String.Empty;                 // таким образом мы можем прочитать result и он изначально будет пустой строкой

//     while (i < count)
//     {
//         result = result + text;                   // и будем класть в result result + c-text (вот эта вот строчка которую мы изначально указали)            
//         i++;                                      // правой кнопкой сделали rename symbol на text
//     }                                             // не забываем увеличивать наш счетчик
//     return result;                                // после того как данный метод отработает используем классический оператор return в котором указываем тот результат
// }                                                 // или ту переменную значение которой мы ожидаем получить из метода                                
// string res = Method4(10, "text");                 // для того чтобы вызвать Method4 мы должны будем создать нужную нам переменную string res         
// Console.WriteLine(res);                           // далее по порядку указать н-р значение 10 и текст который мы будем склеиваить 10 раз.
//                                                   // и после этого мы можем показать на экране результат (res) который данный метод будет возвращать







 
// string Method5(int count, string text )                   // вместо while используем цикл for
// {                                                 
                                    
//     string result = String.Empty;                 
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;                                                            
//     }                                   
//     return result;                              
// }                                                                           
// string res5 = Method5(10, "text");                       
// Console.WriteLine(res5);      






// // Задача вывести таблицу умножения на экран

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }






//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             +  "ежели бы вас послали вместо нашего милого Винценгероде,"
//             +  "вы бы взяли приступом согласие прусского короля."
//             +  "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             012345 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText =  Replace(text, ' ', '|');   // вот этот итоговый текст который мы получили, мы можем в дальнейшем обрабатывать

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
//  Console.WriteLine(newText);





 // Алгоритм сортировки методом выбора



 // 1. Найти позицию минимального элемента в неотсортированной части массива.
 // 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
 // 3. Повторять пока есть неотсортированные элементы.


int[] arr={1, 5, 4, 3, 2, 6, 7, 1, 1};               // вывод данных массива на экран

void PrintArray(int[] array)                      
{
    int count = array.Length;

    for (int i = 0; i < count ; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}

// Теперь нужно написать метод, который будет упорядочивать наш массив. 


void SelectionSort(int[] array)
{
      
        for (int i = 0; i < array.Length-1; i++)
        {
            int minPosition = i;
            for (int j = i+1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition])
                {
                minPosition = j;
                }
}
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        }
}
PrintArray(arr);    
SelectionSort(arr);
PrintArray(arr);        






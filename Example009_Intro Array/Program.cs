

int Max (int arg1, int arg2, int arg3)          
{                                               
    int result = arg1;                          
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;                              
}

int[] array = {21, 25, 38, 45, 6558, 61, 78, 80, 59};                           // Нам требуется определить массив

  int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[4]),
    Max(array[6], array[7], array[8])
  
  );
Console.WriteLine(result);

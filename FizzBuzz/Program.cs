for (int i = 2; i < 101; i++) {
    if (i % 3 == 0 && i % 5 == 0) {
        Console.WriteLine(i + " - FizzBuzz ");
    }else if (i % 5 == 0) {
        Console.WriteLine(i + " - Buzzz ");
    }else if (i % 3 == 0) {
        Console.WriteLine(i + " - Fizz ");
    } else { Console.WriteLine(i);}
}



    
    bool istrue = true;
    bool isfalse = false;

    
    Console.WriteLine($"istrue: {istrue}");
    Console.WriteLine($"isfalse: {isfalse}");

    // logical 
    Console.WriteLine($"logical AND: {istrue && isfalse}"); // false
    Console.WriteLine($"logical OR: {istrue || isfalse}");  // true
    Console.WriteLine($"logical NOT for true: {!istrue}");  // false
    Console.WriteLine($"logical NOT for false: {!isfalse}"); // true

    // comparison
    int a = 1;
    int b = 2;
    int c = 3;
    int d = 4;
    int e = 5;

    Console.WriteLine($"1 > 3: {a > c}");
    Console.WriteLine($"2 < 4: {b < d}");
    Console.WriteLine($"1 == 4: {a == c}");
    Console.WriteLine($"2 != 3: {b != c}");

    bool expression1 = (a > c) && (b < d);
    bool expression2 = (a < c) && (b > d);
    Console.WriteLine($"expression 1: {expression1}");// true
    Console.WriteLine($"expression 2: {expression2}");// false

    Console.ReadLine();
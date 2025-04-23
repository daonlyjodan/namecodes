bool loop = true;
while (loop == true) {
    System.Console.WriteLine("Enter a number");
    int num;
    while (!int.TryParse(Console.ReadLine(), out num)) {
        System.Console.WriteLine("Invalid input, please enter a number");
    }

    static bool isPrime(int number) // Copied a prime number checking function from ChatGPT
    {
        if (number < 2)
            return false;
        if (number == 2 || number == 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        // Check divisibility from 5 to √n, skipping multiples of 2 and 3
        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }
    if (isPrime(num) == true) {
        System.Console.WriteLine("Is prime");
    }
    else {
        string output = num switch 
        {
            <= 1 => "Not greater than 1",
            _ => "Is not prime"
        };
        System.Console.WriteLine(output);
    }


    System.Console.WriteLine("Would you like to enter another number?");
    string? cont = Console.ReadLine();
    while (cont != "yes" && cont != "no") {
        System.Console.WriteLine("Invalid input, would you like to enter another number?");
        cont = Console.ReadLine();
    }
    if (cont == "yes") {
        loop = true;
    }
    else if (cont == "no") {
        loop = false;
    }
}
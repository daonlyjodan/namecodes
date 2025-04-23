// System.Console.WriteLine("Enter an integer greater than 1:");
// int Number = Convert.ToInt32(Console.ReadLine());
// int X = 2;
// int Count = 0;
// while (Number>1) {
//     bool Multi = false;
//     while (Number % X == 0) {
//         if (!Multi) {
//             System.Console.WriteLine(X);
//         }
//         Count += 1;
//         Multi = true;
//         Number = Number / X;
//     }
//     X += 1;
// }
// System.Console.WriteLine(Count);

//next task

// List<int> numbers = new List<int> {};
// bool ask = true;

// while (ask) {
//     System.Console.WriteLine("Enter a number");
//     int num = Convert.ToInt32(Console.ReadLine());
//     numbers.Add(num);
//     System.Console.WriteLine("Would you like to enter another number?");
//     string? cont = Console.ReadLine();
//     string cont1 = cont.ToLower();
//     if (cont1 == "yes") {
//         ask = true;
//     }
//     else if (cont1 == "no") {
//         ask = false;
//     }
//     else {
//         System.Console.WriteLine("Invalid input");
//     }
// }
// int sum = 0;
// foreach (int n in numbers) {
//     sum += numbers[n-1];
// }
// System.Console.WriteLine(sum);

//next task

// for (int i = 1 ; i <= 50 ; i++) {
//     if (i%15 == 0) {
//         System.Console.WriteLine("FizzBuzz");
//     }
//     else {
//         if (i%3 == 0) {
//             Console.WriteLine("Fizz");
//         }
//         else if (i%5 == 0) {
//             System.Console.WriteLine("Buzz");
//         }
//         else {
//             System.Console.WriteLine(i);
//         }
//     }
// }


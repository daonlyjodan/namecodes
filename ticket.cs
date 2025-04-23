// // // Task 1

// string[,] prices = {{"Infant", "0"},{"Child","5"},{"Teen","7"},{"Adult","10"},{"Senior","6"}};
// string user_age = "";
// string price = "";
// System.Console.WriteLine("Enter the age");
// int age = Convert.ToInt32(Console.ReadLine());
// if (age >= 0 && age <=3) {
//     user_age = "Infant";
// }
// else if (age >= 4 && age <= 12) {
//     user_age = "Child";
// }
// else if (age >= 13 && age <= 17) {
//     user_age = "Teen";
// }
// else if (age >= 18 && age <= 64) {
//     user_age = "Adult";
// }
// else {
//     user_age = "Senior";
// }

// if (user_age == "Infant") {
//     price = prices[0,1];
// }
// else if (user_age == "Child") {
//     price = prices[1,1];
// }
// else if (user_age == "Teen") {
//     price = prices[2,1];
// }
// else if (user_age == "Adult") {
//     price = prices[3,1];
// }
// else if (user_age == "Senior") {
//     price = prices[4,1];
// }

// System.Console.WriteLine("The chosen ticket type is " + user_age + " and the price will be GBP " + price);



// Improved Task 1 with ChatGPT

Dictionary<string, string> prices = new Dictionary<string, string>
    {
        {"Infant", "0"},
        {"Child", "5"},
        {"Teen", "7"},
        {"Adult", "10"},
        {"Senior", "6"}
    };
    int age;
    Console.WriteLine("Enter the age:");

    while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 130)
    {
        Console.WriteLine("Invalid input. Please enter a valid age between 0 and 130:");
    }
    
    string user_age = age switch
    {
        <= 3 => "Infant",
        <= 12 => "Child",
        <= 17 => "Teen",
        <= 64 => "Adult",
        _ => "Senior"
    };

string price = prices[user_age];

Console.WriteLine($"The chosen ticket type is {user_age} and the price will be GBP {price}");
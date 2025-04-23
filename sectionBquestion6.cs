static string getSurname(string surname) {
    string ln = "";
    string surname1 = surname.ToUpper();
    char[] chars = surname1.ToCharArray();
    for (int i = 0 ; i < 3 ; i++) {
        ln+= chars[i];
    }
    return ln;
}
static string getForename(string forename) {
    string fn = "";
    string forename1 = forename.ToLower();
    char[] chars = forename1.ToCharArray();
    for (int i = 2 ; i > 0 ; i--) {
        fn+= chars[chars.Length - i];
    }
    return fn;
}

Random rnd = new Random(); // Create a random number
int num = rnd.Next(1000,10000); // Assign random number to variable num, which will be used in the ID
string number = num.ToString();

System.Console.WriteLine("Enter your firstname");
string? forename = Console.ReadLine();
while (forename.Length < 2) {
    System.Console.WriteLine("Name too short");
    forename = Console.ReadLine();
}
System.Console.WriteLine("Enter your lastname");
string? surname = Console.ReadLine();
while (surname.Length < 3) {
    System.Console.WriteLine("Name too short");
    surname = Console.ReadLine();
}

string memberID = getSurname(surname) + getForename(forename) + number;

System.Console.WriteLine("Your member ID is " + memberID);
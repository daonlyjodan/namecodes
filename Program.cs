using C = System.Console;
class Program
{
    public static void Main() {

        C.WriteLine("Enter a username");
        string? user = C.ReadLine();
        C.WriteLine("Enter a password");
        string? pw = C.ReadLine();
        while (string.IsNullOrEmpty(pw) == true || pw.Length < 8)
        {
            C.WriteLine("Invalid Password entered. Please try again");
            pw = C.ReadLine();
        }
        Admin();
    }
    public static void Admin(string user, string pw) {
        if (!File.Exists("textfile.txt")) {
            File.Create("textfile.txt");
        }
        C.WriteLine("Would you like to open your text file?");
        C.WriteLine("Enter your username");
        string? userinput = C.ReadLine();
        C.WriteLine("Enter your password");
        string? userpw = C.ReadLine();
        if (userinput == user && userpw == pw) {
            File.ReadAllText("textfile.txt");
        }
    }
}

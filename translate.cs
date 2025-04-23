Dictionary<string,string>  translate = new Dictionary<string,string>
{
    {"apple","manzana"},
    {"cat","gato"},
    {"food", "alimento"},
    {"moon","luna"},
    {"paint","pintar"},
    {"school","escuela"},
    {"water","agua"}
};

System.Console.WriteLine("Enter an English word");
string? english = Console.ReadLine();
while (string.IsNullOrEmpty(english)) {
    System.Console.WriteLine("Invalid word.");
    english = Console.ReadLine();
}

if (translate.TryGetValue(english, out string? spanish)) 
{
    System.Console.WriteLine("The word is " + spanish);
}
else
{
    System.Console.WriteLine("Word not known");
}
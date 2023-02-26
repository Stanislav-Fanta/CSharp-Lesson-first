Console.WriteLine("Введите свое имя: ");
string name = Console.ReadLine();
if(name.ToLower() == "маша") {                  //<ToLower()> команда, которая делает все символы маленькими
    Console.WriteLine($"Ура, привет {name}!");
} else {
    Console.WriteLine($"Привет, {name}.");
}

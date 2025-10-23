using CalculatorBasic.Interface;
using CalculatorBasic.Classes;
while (true) {
    ICalculatorBasic _calc = new calculator();
    Console.WriteLine("did you want App?");
    var answer = Console.ReadLine().Trim().ToLower(); 
    if  (answer == "yes")
    {
        //write programm
        Console.WriteLine(_calc.Addition(5, 5));
    }
    else
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}
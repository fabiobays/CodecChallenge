using CodecChallenge;

var X = 1;
var Y = 1;
var commands = "";

var size = Console.ReadLine();
commands = Console.ReadLine();

if (!String.IsNullOrEmpty(size) )
{
    X = Convert.ToInt32(size.Split('x')[0]);
    Y = Convert.ToInt32(size.Split('x')[1]);    
}
else
{
    Console.WriteLine("Please enter the Plateau Size (XxY)");
    Console.ReadKey();
    return;
}

if (!String.IsNullOrEmpty(commands))
{

    Plateau plateau = new Plateau(X, Y);
    Robot robot = new Robot();
    robot.Move(commands, plateau);
    Console.WriteLine($"{robot.X},{robot.Y},{robot.Facing}");
    Console.ReadKey();        
}
else
{
   Console.WriteLine("Error: Commands sequence is required!");
   Console.ReadKey();
}



    



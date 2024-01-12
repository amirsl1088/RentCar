using Rentcar;

while (true)
{
    try
    {
        Run();
    }catch(Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}
static void Run()
{
    Console.WriteLine("choose option:\n1.add car\n2.show cars\n3.rent car");
    var option = int.Parse(Console.ReadLine()!);
    switch (option)
    {
        case 1:
            {
                Console.WriteLine("enter car name");
                var carName = Console.ReadLine()!;
                Console.WriteLine("1.foriegn car  2.persian car");
                var type = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter rent price");
                var price = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter car model");
                var carModel = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter car speed");
                var speed = int.Parse(Console.ReadLine()!);
                Main.AddCar(carName, speed, carModel, price, type);
                break;
            }
        case 2:
            {
                foreach(var car in Main.GetCars())
                {
                    Console.WriteLine($"carname={car.Name}, carspeed={car.Speed}, carmodel={car.Model}, rentprice={car.Price}");
                }
                break;
            }
        case 3:
            {
                Console.WriteLine("enter car name");
                var carName = Console.ReadLine()!;
                Console.WriteLine("how many day you want car");
                var rentDays = int.Parse(Console.ReadLine()!);
                Main.RentCar(carName, rentDays);
                break;
            }
       
    }
}
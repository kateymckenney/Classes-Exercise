namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myTruck = new Car();
            myTruck.Make = "Ford";
            myTruck.Model = "F-250";
            myTruck.Year = 1963;

            Console.WriteLine($"We took the {myTruck.Year} {myTruck.Model} to the {myTruck.Make} car show last weekend.");
            
        }
    }
}

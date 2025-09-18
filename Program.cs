namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("KTM", "DUKE 360", 69);
            v.display();
            Vehicle c = new Car("MAHENDRA", "THAR", 699, 5, "Petrol");
            c.display();
        }
    }
}

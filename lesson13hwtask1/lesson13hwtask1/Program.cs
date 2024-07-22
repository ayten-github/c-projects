namespace lesson13hwtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room("England", 200, 4);
            Room r2=new Room("Italy", 150, 2);
            Hotel h1 = new Hotel("Country");
            h1.AddRoom(r1);
            h1.AddRoom(r2);
            try
            {
                h1.MakeReservation(1);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAviableExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }
}

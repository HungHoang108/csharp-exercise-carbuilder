using System.Diagnostics;

partial class Program
{
    static void Main(string[] args)
    {
        var MiniVan1 = new Minivan("Slilding door", 2000);
        MiniVan1.transmissionType();
        MiniVan1.numberOfDoor();

        var Porsche911 = new SportCar(true, 2111);
        Porsche911.transmissionType();
        Porsche911.numberOfDoor();
    }
}
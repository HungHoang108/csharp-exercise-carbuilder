
public class SportCar : Car
{
    public SportCar(bool openAirDriving, int productionYear) : base(productionYear)
    {
        this.openAirDriving = openAirDriving;
    }
    bool openAirDriving { get; set; } = true;
    public override void numberOfDoor()
    {
        System.Console.WriteLine("Sport car usually has 2 doors");
    }
}

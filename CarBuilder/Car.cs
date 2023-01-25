
public abstract class Car
{
    public int weight { get; set; }
    public int height { get; set; }

    public int length { get; set; }

    public int productionYear { get; set; }

    public string? color { get; set; }

    public Car( int productionYear)
    {
        this.productionYear = productionYear;
    }
    public virtual void numberOfDoor()
    {
        System.Console.WriteLine("4 doors");
    }
    public void transmissionType()
    {
        if (productionYear < 2005)
        {
            System.Console.WriteLine($"The transmission may be {(transmission)1}");
        }
        else
        {
            System.Console.WriteLine($"The transmission may be {(transmission)0}");
        }
    }
}

public enum transmission
{
    automatic,
    manual
}

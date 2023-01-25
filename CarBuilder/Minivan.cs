
    public class Minivan : Car
    {
    public Minivan( string doorType, int productionYear) : base( productionYear)
    {
        this.doorType = doorType;
    }
    public string doorType { get; set; }
    }

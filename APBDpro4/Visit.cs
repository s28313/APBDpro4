namespace APBDpro4;

public class Visit
{
    private string date{ get; set; }
    private Animal animal { get; set; }
    private string description { get; set; }
    private double price { get; set; }

    public Visit(string date, Animal animal, string description, double price)
    {
        this.date = date;
        this.animal = animal;
        this.description = description;
        this.price = price;
    }
}
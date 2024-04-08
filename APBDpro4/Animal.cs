namespace APBDpro4;

public class Animal
{
    private int id{ get; set; }
    private string name{ get; set; }
    private string category{ get; set; }
    private double mass{ get; set; }
    private string furColor{ get; set; }

    public Animal(int id, string name, string category, double mass, string furColor)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.mass = mass;
        this.furColor = furColor;
    }
    
    
}
namespace APBDpro4;

public class DataBase
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal{Id = 1, Name = "Puszek", Category = "Pies", Mass = 15, FurColor = "Czarny"},
        new Animal{Id = 2, Name =  "Kotlet", Category =  "Chomik", Mass =  0.2, FurColor =  "Brazowy"},
        new Animal{Id = 3, Name =  "Bebok", Category =  "Koza", Mass =  35, FurColor =  "Biały"},
        new Animal{Id = 4, Name = "Rex", Category = "Pies", Mass = 25, FurColor = "Brązowy"},
        new Animal{Id = 5, Name = "Mittens", Category = "Kot", Mass = 15, FurColor = "Czarny"},
        new Animal{Id = 6, Name = "Felicja", Category = "Koń", Mass = 450, FurColor = "Szary"},
        new Animal{Id = 7, Name = "Whiskers", Category = "Kot", Mass = 12, FurColor = "Biały i szary"}
    };

    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit{Id = 1, Date = "03-03-2024", AnimalId = 1, Description = "Pchły", Price = 124.0},
        new Visit{Id = 2, Date = "05-03-2024", AnimalId = 1, Description = "Wymiana kleszczy", Price = 100.0},
        new Visit{Id = 3, Date = "08-03-2024", AnimalId = 1, Description = "Badanie ogólne", Price = 150.0},

        new Visit{Id = 4, Date = "07-03-2024", AnimalId = 2, Description = "Wizyta kontrolna", Price = 50.0},
        new Visit{Id = 5, Date = "09-03-2024", AnimalId = 2, Description = "Badanie krwi", Price = 80.0},
        new Visit{Id = 6, Date = "12-03-2024", AnimalId = 2, Description = "Leczenie zęba", Price = 120.0},

        new Visit{Id = 7, Date = "10-03-2024", AnimalId = 3, Description = "Wizyta kontrolna", Price = 70.0},
        new Visit{Id = 8, Date = "14-03-2024", AnimalId = 3, Description = "Badanie krwi", Price = 90.0},
        new Visit{Id = 9, Date = "17-03-2024", AnimalId = 3, Description = "Szczepienie", Price = 100.0},

        new Visit{Id = 10, Date = "20-03-2024", AnimalId = 4, Description = "Wymiana kleszczy", Price = 110.0},
        new Visit{Id = 11, Date = "22-03-2024", AnimalId = 4, Description = "Badanie ogólne", Price = 150.0},
        new Visit{Id = 12, Date = "25-03-2024", AnimalId = 4, Description = "Leczenie ran", Price = 200.0},

        new Visit{Id = 13, Date = "28-03-2024", AnimalId = 5, Description = "Badanie ogólne", Price = 120.0},
        new Visit{Id = 14, Date = "30-03-2024", AnimalId = 5, Description = "Szczepienie", Price = 100.0},
        new Visit{Id = 15, Date = "02-04-2024", AnimalId = 5, Description = "Wizyta kontrolna", Price = 80.0},

        new Visit{Id = 16, Date = "05-04-2024", AnimalId = 6, Description = "Badanie krwi", Price = 150.0},
        new Visit{Id = 17, Date = "07-04-2024", AnimalId = 6, Description = "Wymiana kleszczy", Price = 100.0},
        new Visit{Id = 18, Date = "10-04-2024", AnimalId = 6, Description = "Leczenie ran", Price = 200.0},

        new Visit{Id = 19, Date = "12-04-2024", AnimalId = 7, Description = "Szczepienie", Price = 100.0},
        new Visit{Id = 20, Date = "15-04-2024", AnimalId = 7, Description = "Badanie ogólne", Price = 120.0},
        new Visit{Id = 21, Date = "18-04-2024", AnimalId = 7, Description = "Wymiana kleszczy", Price = 110.0}
    };
}
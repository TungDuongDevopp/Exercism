public enum Allergen
{
    Eggs = 1<<0,
    Peanuts = 1<<1,
    Shellfish= 1<<2,
    Strawberries = 1<<3,
    Tomatoes= 1<<4,
    Chocolate = 1<<5,
    Pollen= 1<<6,
    Cats = 1<<7
}

public class Allergies
{ 
    private int mask;
    public Allergies(int mask)
    { this.mask = mask%256;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (mask & (int)allergen) != 0;
    }

    public Allergen[] List()
    {
          var result = new List<Allergen>();

    foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
    {
        if (IsAllergicTo(allergen))
        {
            result.Add(allergen);
        }
    }

    return result.ToArray();
    }
}
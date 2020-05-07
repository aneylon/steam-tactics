using System.Collections.Generic;

public class Armor : Equipment
{
    public int ArmourRating { get; set; }
    public List<ArmorTrait> ArmorTraits { get; set; }
}

public enum ArmorTrait
{

}

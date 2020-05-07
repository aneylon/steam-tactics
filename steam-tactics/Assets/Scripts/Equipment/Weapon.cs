using System.Collections.Generic;

public class Weapon : Equipment
{
    public int RangeType { get; set; }
    public int ShortRange { get; set; }
    public int LongRange { get; set; }
    public List<WeaponTrait> WeaponTraits;
}

public enum WeaponTrait
{

}

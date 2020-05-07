using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int Movement { get; set; }
    public int Strength { get; set; }
    public int Toughness { get; set; }
    public int MeeleWeaponSkill { get; set; }
    public int RangedWeaponSkill { get; set; }
    public int HitPoints { get; set; }
    public int Leadership { get; set; }
    public int Courage { get; set; }
    public int Intelegence { get; set; }
    public int Initiative { get; set; }
    public int Attacks { get; set; }
    public int Willpower { get; set; }

    public List<Skill> Skills;
    public List<Equipment> Inventory;
    public List<Status> Statuses;
    public List<Trait> Traits;
}

public enum Trait
{
    Fear,
    Hatred,
    Frenzy,
    Stupid
}

public enum Status
{
    Ready,
    Standing,
    Active,
    Engaged,
    Prone,
    Pinned,
    SeriouslyInjured,
    Hidden,
    KnockedDown,
    Stunned,
    OutOfAction,
    Posiened,
    PartialCover,
    FullCover
}
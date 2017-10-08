using UnityEngine;
using System.Collections;

public class UnitClass{
    private string unitClassName;

    //Stats
    private int health;
    private int range;
    private int movement;
    private int damage;

    public string UnitClassName
    {
        get { return unitClassName; }
        set { unitClassName = value; }
    }
    
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Range
    {
        get { return range; }
        set { range = value; }
    }

    public int Movement
    {
        get { return movement; }
        set { movement = value; }
    }

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    public Weapons Type { get; private set; } = Weapons.Knife0;

    protected Weapon(Weapons weapon)
    {
        Type = weapon;
    }

    public virtual int CalculateScoreChange()
    {
        return 1;
    }
}

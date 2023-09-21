using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife3 : Weapon
{
    public Knife3() : base(Weapons.Knife3)
    {
    }

    public override int CalculateScoreChange()
    {
        return RollHelper.Roll(new List<(int outcome, float percent)>
        {
            
            (3, 0.5f),
            (2, 1f)

        });
    }
}

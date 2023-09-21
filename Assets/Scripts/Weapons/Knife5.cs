using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife5 : Weapon
{
    public Knife5() : base(Weapons.Knife5)
    {
    }

    public override int CalculateScoreChange()
    {
        return RollHelper.Roll(new List<(int outcome, float percent)>
        {
            
            (4, 0.65f),
            (3, 1f)

        });
    }
}

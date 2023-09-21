using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife4 : Weapon
{
    public Knife4() : base(Weapons.Knife4)
    {
    }

    public override int CalculateScoreChange()
    {
        return RollHelper.Roll(new List<(int outcome, float percent)>
        {
            (4, 0.25f),
            (3, 0.75f),
            (2, 1f)

        });
    }
}

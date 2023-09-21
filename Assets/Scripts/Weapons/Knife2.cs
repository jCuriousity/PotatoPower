using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife2 : Weapon
{
    public Knife2() : base(Weapons.Knife2)
    {
    }

    public override int CalculateScoreChange()
    {
        return RollHelper.Roll(new List<(int outcome, float percent)>
        {
            (3, 0.1f),
            (2, 0.75f),
            (1, 1f)

        });
    }
}

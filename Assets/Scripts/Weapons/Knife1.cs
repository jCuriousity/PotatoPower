using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife1 : Weapon
{
    public Knife1() : base(Weapons.Knife1)
    {
    }

    public override int CalculateScoreChange()
    {
        return RollHelper.Roll(new List<(int outcome, float percent)>
        {
            
            (2, 0.5f),
            (1, 1.0f)
            
        });
    }
}

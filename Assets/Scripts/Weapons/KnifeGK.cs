using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeGK : Weapon
{
    public KnifeGK() : base(Weapons.KnifeGK)
    {
    }

    // Start is called before the first frame update
    public override int CalculateScoreChange()
    {
        return RollHelper.Roll(new List<(int outcome, float percent)>
        {

            
            (4, 1f)

        });
    }
}

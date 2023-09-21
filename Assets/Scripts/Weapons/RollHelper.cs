using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class RollHelper
{
    public static int Roll(List<(int outcome, float percent)> outcomes)
    {
        var roll = Random.Range(0.0f, 1.0f);
        Debug.Log(roll);
        foreach (var outcome in outcomes)
        {
            if (roll <= outcome.percent)
            {
                Debug.Log(outcome);
                return outcome.outcome;
            }
        }
        return 0;
    }
}

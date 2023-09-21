using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnMoldyPotatoClicked : OnPlainPotatoClicked


{
    private GlobalGameData gameData = GlobalGameData.Instance;
    public override void CustomPointerDown()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var mold = transform.GetChild(i);

            Destroy(mold.gameObject);
        }
        
        scoreHandler.ScoreChange(-1);

        if (gameData.boughtWeapon == Weapons.KnifeGK)
        {
            scoreHandler.ScoreChange(1);
        }
        
    }
}

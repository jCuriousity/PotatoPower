using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGkPotatoClicked : OnPlainPotatoClicked
{
    // Start is called before the first frame update

    private GlobalGameData gameData = GlobalGameData.Instance;
    public override void CustomPointerDown()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var mold = transform.GetChild(i);

            Destroy(mold.gameObject);
        }

        scoreHandler.ScoreChange(gameData.weapon.CalculateScoreChange());

        gameData.boughtWeapon =  Weapons.KnifeGK;
        gameData.weapon = new KnifeGK();
        gameData.gameSpeed = 3.5f;
        gameData.ccBGcheck = 1;
        gameData.BGcheck = 1;







    }
}

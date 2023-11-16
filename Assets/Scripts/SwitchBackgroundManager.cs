using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchBackgroundManager : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    private GlobalGameData gameData = GlobalGameData.Instance;
   

    

    private void Update()
    {
        SwitchBG();
    }

    

    // Update is called once per frame
    public void SwitchBG()
    {



        switch (gameData.BGcheck)
        {
            case 1:
                background1.SetActive(true);
                background2.SetActive(false);
                background3.SetActive(false);
                break;
            case 2:
                background1.SetActive(false);
                background2.SetActive(true);
                background3.SetActive(false);
                break;
            case 3:
                background1.SetActive(false);
                background2.SetActive(false);
                background3.SetActive(true);
                break;

        }
    }

    public void CCSwitchBG()
    {
        if (gameData.ccBGcheck == 3)
        {
            gameData.ccBGcheck = 1;
        }
        else
        {
            gameData.ccBGcheck += 1;
        }

        switch (gameData.ccBGcheck)
        {
            case 1:
                background1.SetActive(true);
                background2.SetActive(false);
                background3.SetActive(false);
                break;
            case 2:
                background1.SetActive(false);
                background2.SetActive(true);
                background3.SetActive(false);
                break;
            case 3:
                background1.SetActive(false);
                background2.SetActive(false);
                background3.SetActive(true);
                break;

        }
    }
}

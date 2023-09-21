using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class WiiShop : MonoBehaviour
{
    // Start is called before the first frame update
    private GlobalGameData gameData = GlobalGameData.Instance;
    public Text Points;
    [Header("Knifes to buy")]
    public Text knife1Text;
    public Text knife2Text;
    public Text knife3Text;
    public Text knife4Text;
    public Text knife5Text;

    private void Start()
    {
        UpdateText();
    }

    private void UpdateText()
    {
        switch (gameData.boughtWeapon)
        {
            case Weapons.KnifeGK:
                goto case Weapons.Knife5;
            
            case Weapons.Knife5:
                knife5Text.text = "Owned";
                goto case Weapons.Knife4;
            case Weapons.Knife4:
                knife4Text.text = "Owned";
                goto case Weapons.Knife3;


            case Weapons.Knife3:
                knife3Text.text = "Owned";
                goto case Weapons.Knife2;



            case Weapons.Knife2:
                knife2Text.text = "Owned";
                goto case Weapons.Knife1;


            case Weapons.Knife1:
                knife1Text.text = "Owned";
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        Points.text = gameData.score.ToString();
    }

    public void Knife1()
    {
        if (gameData.score > 49 && gameData.boughtWeapon < Weapons.Knife1)
        {
            gameData.boughtWeapon = Weapons.Knife1;
            gameData.weapon = new Knife1();
            gameData.score -= 50;
            UpdateText();
        }
    }

    public void Knife2()
    {
        if (gameData.score > 99 && gameData.boughtWeapon < Weapons.Knife2)
        {
            gameData.boughtWeapon = Weapons.Knife2;
            gameData.weapon = new Knife2();
            gameData.score -= 100;
            UpdateText();
        }
    }

    public void Knife3()
    {
        if (gameData.score > 199 && gameData.boughtWeapon < Weapons.Knife3)
        {
            gameData.boughtWeapon = Weapons.Knife3;
            gameData.weapon = new Knife3();
            gameData.score -= 200;
            UpdateText();
        }
    }

    public void Knife4()
    {
        if (gameData.score > 499 && gameData.boughtWeapon < Weapons.Knife4)
        {
            gameData.boughtWeapon = Weapons.Knife4;
            gameData.weapon = new Knife4();
            gameData.score -= 500;
            UpdateText();
        }
    }

    public void Knife5()
    {
        if (gameData.score > 999 && gameData.boughtWeapon < Weapons.Knife5)
        {
            gameData.boughtWeapon = Weapons.Knife5;
            gameData.weapon = new Knife5();
            gameData.score -= 1000;
            UpdateText();
        }
    }

    public void NONONONONONONONONONONONONOSUSUSUSUSUSUSUSUSUSUSUSUSUSUSUSUSUSUS()
    {
        gameData.score = 10000;
    }

    
}

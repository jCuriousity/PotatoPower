using UnityEngine;
using UnityEngine.UI;


public class WiiShop : MonoBehaviour
{
    // Start is called before the first frame update
    private GlobalGameData gameData = GlobalGameData.Instance;
    public Text Points;
    public GameObject AfterLastKnife;
    public Text YouMightve;
    [Header("Knifes to buy")]
    public Text knife1Text;
    public Text knife2Text;
    public Text knife3Text;
    public Text knife4Text;
    public Text knife5Text;

    private void Start()
    {
        UpdateText();
        AfterLastKnife.SetActive(false);

        if (gameData.boughtWeapon == Weapons.Knife5)
        {
            AfterLastKnife.SetActive(true);
        }
        else if (gameData.boughtWeapon == Weapons.KnifeGK)
        {
            AfterLastKnife.SetActive(true);
            YouMightve.text = "You found the glowing Katana Potato!";

        }
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
            gameData.gameSpeed = 1.25f;
            gameData.BGcheck = 2;
            gameData.ccBGcheck = 2;
            UpdateText();
        }
    }

    public void Knife2()
    {
        if (gameData.score > 124 && gameData.boughtWeapon < Weapons.Knife2)
        {
            gameData.boughtWeapon = Weapons.Knife2;
            gameData.weapon = new Knife2();
            gameData.score -= 125;
            gameData.gameSpeed = 1.75f;
            gameData.BGcheck = 3;
            gameData.ccBGcheck = 3;
            UpdateText();
        }
    }

    public void Knife3()
    {
        if (gameData.score > 274 && gameData.boughtWeapon < Weapons.Knife3)
        {
            gameData.boughtWeapon = Weapons.Knife3;
            gameData.weapon = new Knife3();
            gameData.score -= 275;
            gameData.gameSpeed = 2.0f;
            gameData.BGcheck = 1;
            gameData.ccBGcheck = 1;
            UpdateText();
        }
    }

    public void Knife4()
    {
        if (gameData.score > 549 && gameData.boughtWeapon < Weapons.Knife4)
        {
            gameData.boughtWeapon = Weapons.Knife4;
            gameData.weapon = new Knife4();
            gameData.score -= 550;
            gameData.gameSpeed = 2.5f;
            gameData.BGcheck = 2;
            gameData.ccBGcheck = 2;
            UpdateText();
        }
    }

    public void Knife5()
    {
        if (gameData.score > 1199 && gameData.boughtWeapon < Weapons.Knife5)
        {
            gameData.boughtWeapon = Weapons.Knife5;
            gameData.weapon = new Knife5();
            gameData.score -= 1200;
            gameData.gameSpeed = 3.0f;
            AfterLastKnife.SetActive(true);
            gameData.BGcheck = 3;
            gameData.ccBGcheck = 3;
            UpdateText();
        }
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum Weapons
{
    Knife0,
    Knife1,
    Knife2,
    Knife3,
    Knife4,
    Knife5,
    KnifeGK,
}

public class GlobalGameData
{
    private static GlobalGameData _instance;
    public static GlobalGameData Instance { get => _instance ??= new GlobalGameData(); }

    public int score = 0;
    public Weapons boughtWeapon = Weapons.Knife0;
    public Weapon weapon = new Knife0();

    public bool firstTime = true;

    public int ccScore = 0;

    public string PlayerName;
}

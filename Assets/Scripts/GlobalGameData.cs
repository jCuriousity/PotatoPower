using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
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
    private Weapon[] weapons =
    {
        new Knife0(),
        new Knife1(),
        new Knife2(),
        new Knife3(),
        new Knife4(),
        new Knife5(),
        new KnifeGK(),
    };

    private static GlobalGameData _instance;
    public static GlobalGameData Instance { get => _instance ??= new GlobalGameData(); }

    public bool firstTime = true;

    public float gameSpeed = 1.0f;
    public int score
    {
        get => PlayerPrefs.GetInt("score", 0);
        set => PlayerPrefs.SetInt("score", value);
    }
    public Weapons boughtWeapon
    {
        get => (Weapons)Enum.Parse(typeof(Weapons), PlayerPrefs.GetString("weapon", nameof(Weapons.Knife0)));
        set => PlayerPrefs.SetString("weapon", Enum.GetName(typeof(Weapons), value));
    }
    private Weapon _weapon;
    public Weapon weapon
    {
        get => _weapon ?? weapons.First(v => v.Type == boughtWeapon);
        set => _weapon = value;
    }

    public int BGcheck
    {
        get => PlayerPrefs.GetInt("BGcheck", 0);
        set => PlayerPrefs.SetInt("BGcheck", value);
    }

    public int ccBGcheck
    {
        get => PlayerPrefs.GetInt("ccBGcheck", 0);
        set => PlayerPrefs.SetInt("ccBGcheck", value);
    }

    public int ccScore
    {
        get => PlayerPrefs.GetInt("cc_score", 0);
        set => PlayerPrefs.SetInt("cc_score", value);
    }

    public string PlayerName;

    
}


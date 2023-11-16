using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotatos : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Game Objects")]
    public GameObject plainPotato;
    public GameObject moldyPotato;
    public GameObject GKPotato;
    public GameObject purplePotato;
    public GameObject yellowPotato;
    //public GameObject superPotato;
    [Header("Potato Delays")]
    public float potatoDelay = 1, moldyDelay = 3, gkDelay = 1000, purpleDelay = 5, yellowDelay;
    [Header("Potato Speeds")]
    public float potatoSpeed = 2;
    public float moldySpeed = 3;
    public float gkSpeed = 1;
    public float purpleSpeed = 0.5f;
    public float yellowSpeed = 0.5f;
    private GlobalGameData gameData;
    void Start()
    {
        InvokeRepeating(nameof(SpawnPotato), potatoDelay, 1 / potatoSpeed);
        InvokeRepeating(nameof(SpawnMoldy), moldyDelay, 1 / moldySpeed);
        InvokeRepeating(nameof(SpawnGKPotato), gkDelay, 1 / gkSpeed);
        InvokeRepeating(nameof(SpawnPurple), purpleDelay, 1 / purpleSpeed);
        InvokeRepeating(nameof(SpawnYellow), yellowDelay, 1 / yellowSpeed);


        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPotato()
    {
        Instantiate(plainPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 10f, 0), Quaternion.identity);
    }

    void SpawnMoldy()
    {
        Instantiate(moldyPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 10f, 0), Quaternion.identity);
    }

    void SpawnPurple()
    {
        Instantiate(purplePotato, new Vector3((Random.Range(-7.5f, 7.5f)), 10f, 0), Quaternion.identity);
    }

    void SpawnYellow()
    {
        Instantiate(yellowPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 10f, 0), Quaternion.identity);
    }

    void SpawnGKPotato()
    {
        if (Random.Range(1, 1000) < 1 && gameData.boughtWeapon == Weapons.Knife5)
        {
            Instantiate(GKPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 10f, 0), Quaternion.identity);
            
        }
    }
    /*void SpawnSuperPotato()
    {
        if (Random.Range(1, 100) < 50)
        {
            Instantiate(superPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 10f, 0), Quaternion.identity);
        }
    }*/


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotatos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject plainPotato;
    public GameObject moldyPotato;
    public GameObject GKPotato;
    public float potatoDelay = 1, moldyDelay = 3, gkDelay = 1000;
    public float potatoSpeed = 2;
    public float moldySpeed = 3;
    public float gkSpeed = 1;
    void Start()
    {
        InvokeRepeating(nameof(SpawnPotato), potatoDelay, 1 / potatoSpeed);
        InvokeRepeating(nameof(SpawnMoldy), moldyDelay, 1 / moldySpeed);
        InvokeRepeating(nameof(SpawnGKPotato), gkDelay, 1 / gkSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPotato()
    {
        Instantiate(plainPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 6f, 0), Quaternion.identity);
    }

    void SpawnMoldy()
    {
        Instantiate(moldyPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 6f, 0), Quaternion.identity);
    }

    void SpawnGKPotato()
    {
        if (Random.Range(1, 100) < 10)
        {
            Instantiate(GKPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 6f, 0), Quaternion.identity);
        }
    }


}

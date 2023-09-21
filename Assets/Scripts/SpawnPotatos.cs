using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotatos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject plainPotato;
    public GameObject moldyPotato;
    public GameObject GKPotato;
    public int potatoDelay = 1, moldyDelay = 3, gkDelay = 1000;
    public int potatoSpeed = 2;
    public int moldySpeed = 3;
    public int gkSpeed = 4;
    void Start()
    {
        InvokeRepeating(nameof(SpawnPotato), potatoDelay, potatoSpeed);
        InvokeRepeating(nameof(SpawnMoldy), moldyDelay, moldySpeed);
        InvokeRepeating(nameof(SpawnGKPotato), gkDelay, gkSpeed);
        
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
        Instantiate(GKPotato, new Vector3((Random.Range(-7.5f, 7.5f)), 6f, 0), Quaternion.identity);
    }


}

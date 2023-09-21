using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetTimeScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1()
    {
        
        Time.timeScale = 1.0f;

    }
    public void Level2()
    {
        
        Time.timeScale = 2.0f;
    }

    public void Level31()
    {
        
        Time.timeScale = 3.1f;
    }

    public void Level21()
    {
        
        Time.timeScale = 5f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoClickHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreHandler scoreHandler;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGoodPotatoClicked()
    {
        scoreHandler.ScoreChange(1);
    }
}

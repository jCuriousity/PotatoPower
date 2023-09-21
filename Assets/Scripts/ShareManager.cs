using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShareManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GlobalGameData gameData = GlobalGameData.Instance;
    public Text PlayerName;
    public Text ccPoints;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName.text = PlayerPrefs.GetString("playerName");
        ccPoints.text = gameData.ccScore.ToString();
    }
}

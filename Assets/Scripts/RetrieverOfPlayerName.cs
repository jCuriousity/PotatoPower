using UnityEngine;
using UnityEngine.UI;

public class RetrieverOfPlayerName : MonoBehaviour
{
    public InputField playerName;
    public Text PlayerName;
    private GlobalGameData gameData = GlobalGameData.Instance;
    private bool RRCheck = false;

    public void Dodah()
    {
        string PlayerName = playerName.text;
        PlayerPrefs.SetString("playerName", PlayerName);
        
    }

    public void Awake()
    {
        playerName.text = PlayerPrefs.GetString("playerName");
        RRCheck = false;
    }

    public void Update()
    {
        if (playerName.text == "jeb_" && !RRCheck)
        {
            Application.OpenURL("https://youtu.be/dQw4w9WgXcQ?si=Z0Bz9P_bJiSqZiSC");
            RRCheck = true;
        }
    }
}

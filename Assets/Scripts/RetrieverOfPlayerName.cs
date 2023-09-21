using UnityEngine;
using UnityEngine.UI;

public class RetrieverOfPlayerName : MonoBehaviour
{
    public InputField playerName;
    public Text PlayerName;
    private GlobalGameData gameData = GlobalGameData.Instance;

    public void Dodah()
    {
        string PlayerName = playerName.text;
        PlayerPrefs.SetString("playerName", PlayerName);
        
    }

    public void Awake()
    {
        playerName.text = PlayerPrefs.GetString("playerName");
    }

    public void Update()
    {
        
    }
}

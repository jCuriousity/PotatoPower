using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ScoreHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public string targetScene = "Chef Challenge";
    [SerializeField]
    private GlobalGameData gameData = GlobalGameData.Instance;
    public int score => gameData.score;
    


    public OpenScenes startScene;
    
    
    void Start()
    {
        if (Time.timeScale < 3)
        {
            Time.timeScale = 1.0f + 0.00009f * gameData.score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameData.score.ToString();
        

}

    public void ScoreChange(int changeAmount)
    {  

        
        
        

        gameData.score += changeAmount;
        scoreText.text = gameData.score.ToString();
        if (gameData.score < 0)
        {
                gameData.score = 0;
        }
        
        
        

    }

    
}


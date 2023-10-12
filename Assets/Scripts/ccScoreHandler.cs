using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ccScoreHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    [SerializeField]
    private GlobalGameData gameData = GlobalGameData.Instance;
    public int score => gameData.ccScore;
    
    public OpenScenes startScene;
    
    
    void Start()
    {
        if (Time.timeScale < 3)
        {
            Time.timeScale = 1.0f + 0.00005f * gameData.score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameData.ccScore.ToString();
    }

    public void ScoreChange()
    {

        gameData.ccScore += 1;
        
        scoreText.text = gameData.ccScore.ToString();
        

             
    }

    public void NegScoreChange()
    {

        gameData.ccScore -= 1;
        scoreText.text = gameData.ccScore.ToString();
    }

    
}


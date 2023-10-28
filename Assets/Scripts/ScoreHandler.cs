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
    public Text feedbackDisplay;
    public List<string> firstNames = new List<string>() { "Jerimy", "Jackson", "Vidya", "Kanha", "Julie", "Sammy", "Sasparilla", "Alexander", "Erik", "Mice", "Bellatrix", "Steve", "Bo", "Sus", "Ninja", "Vedant", "Trisha", "Shifts", "Thadius", "Bartholowmew", };
    public List<string> lastNames = new List<string>() { "deFrenchFry", "PotatoStein", "Tatergan II", "deYams", "Starcher", "SalidBalad", "noSmallPotatoes", "GraveyPants", "Butterup", "Spudzer", "deHesi-Tater", "Peeler", "SweetFry", "Rootquist", "Tateron II", "Mashmalow", "Irelandish", "Cellulost", "Eyedon", "ToeSmash", };

    public int score => gameData.score;


    


    public OpenScenes startScene;


    void Start()
    {
        if (Time.timeScale < 3)
        {
            Time.timeScale = 1.0f + 0.00006f * gameData.score;
        }

        var firstNames = new List<string>() { "Jeremy", "Jackson", "Vidya", "Kanha", "Julie", "Sammy", "Sasparilla", "Alexander", "Erik", "Mice", "Bellatrix", "Steve", "Bo", "Sus", "Ninja", "Vedant", "Trisha", "Shifts", "Thadius", "Bart", };
        var lastNames = new List<string>() { "deFrenchFry", "PotatoStein", "Tatergan II", "deYams", "Starcher", "SalidBalad", "noSmallPotatoes", "GraveyPants", "Butterup", "Spudzer", "deHesi-Tater", "Peeler", "SweetFry", "Rootquist", "Tateron II", "Mash-mallow", "Irelandish", "Cellulost", "Eyedon", "ToeSmash", "SquishTater" };
        scoreText.text = gameData.score.ToString();
        feedbackDisplay.text = "Redeem points in the shop!";
    }
        
        



    public void ScoreChange(int changeAmount)
    {  

        
        
        

        gameData.score += changeAmount;
        scoreText.text = gameData.score.ToString();
        if (gameData.score < 0)
        {
                gameData.score = 0;
        }

        feedbackDisplay.text = "You chopped " + firstNames[Random.Range(0, 19)] + " " + lastNames[Random.Range(0, 20)] + "!";




        
        
        

    }

    
}


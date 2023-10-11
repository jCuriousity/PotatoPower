using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class OpenScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public string levelToOpen = "Level 1";
    public GameObject rYaSure;
    private GlobalGameData gameData = GlobalGameData.Instance;
    void Start()
    {
        rYaSure.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenLevel1Scene()
    {
        Time.timeScale = 1.0f + 0.00001f * gameData.score; 
        SceneManager.LoadScene(levelToOpen);
        
    }
    public void OpenHomeScene()
    {
        SceneManager.LoadScene(levelToOpen);
        rYaSure.SetActive(false);
        

    }
    public void HomeButtonCheck()
    {
        Time.timeScale = 0f;
        rYaSure.SetActive(true);
    }

    public void ChoseNo()
    {
        Time.timeScale = 1f;
        rYaSure.SetActive(false);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OpenShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void OpenShopDetails()
    {
        SceneManager.LoadScene("Shop Details");
    }

    public void OpenGameProper()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void STARTforStartScene()
    {
        if (gameData.firstTime)
        {
            gameData.firstTime = false;
            SceneManager.LoadScene("Tutorial");
        }
        else
        {
            SceneManager.LoadScene("Level 1");
        }
    }

    public void OpenTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OpenBridge()
    {
        SceneManager.LoadScene("ChefChallengeStart");
    }

    public void StartChefChallenge()
    {
        SceneManager.LoadScene("Chef Challenge");
    }

    public void RickRoll()
    {
        Application.OpenURL("https://youtu.be/dQw4w9WgXcQ?si=Z0Bz9P_bJiSqZiSC");
    }

    public void OpenStartScene()
    {
        SceneManager.LoadScene("Start Scene");
    }

    public void OpenShareThing()
    {
        SceneManager.LoadScene("ShareScene");
    }

}

using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //Creating an instance allows me to call functions from this 
    //script in another script.
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    int starScore = 0;
    int hiScore = 0;


    private void Awake()
    {
        instance = this;
    }


    public void ResetScore()
    {
        starScore = 0;
    }


    public void AddPoint()
    {
        starScore += 1;

        //Update UI
        scoreText.text = "score: " + starScore.ToString();

        //Set highscore if it beats current value stored
        if (hiScore < starScore)
        {
        PlayerPrefs.SetInt("hiScore", starScore);
        }
    }

    void Start()
    {
        //Get value of highscore from saved data
        hiScore = PlayerPrefs.GetInt("hiScore", 0);

        //Set both UI text with correct values
        scoreText.text = "score: " + starScore.ToString();
        highscoreText.text = "highscore: " + hiScore.ToString();
    }

    
    void Update()
    {
        
    }
}

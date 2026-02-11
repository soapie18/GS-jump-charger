using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
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

        scoreText.text = "score: " + starScore.ToString();

        if (hiScore < starScore)
        {
        PlayerPrefs.SetInt("hiScore", starScore);
        }
    }

    void Start()
    {
        //Get val of highscore from saved data
        hiScore = PlayerPrefs.GetInt("hiScore", 0);
        //Set both ui texts with correct values
        scoreText.text = "score: " + starScore.ToString();
        highscoreText.text = "highscore: " + hiScore.ToString();
    }

    
    void Update()
    {
        
    }
}

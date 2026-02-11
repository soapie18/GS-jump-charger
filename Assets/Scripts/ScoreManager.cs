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
    }

    void Start()
    {
        scoreText.text = "score: " + starScore.ToString();
        highscoreText.text = "highscore: " + hiScore.ToString();
    }

    
    void Update()
    {
        
    }
}

using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    int starScore = 0;


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
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}

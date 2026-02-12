using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class WallTrigger : MonoBehaviour
{

    //Answers to event called out by player when hitting a wall
    void HitRegister()
    {
        SceneManager.LoadScene("SampleScene");

        ScoreManager.instance.ResetScore();
    }



}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class WallTrigger : MonoBehaviour
{


    void HitRegister()
    {
        SceneManager.LoadScene("SampleScene");

        ScoreManager.instance.ResetScore();
    }



}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class WallTrigger : MonoBehaviour
{


    void HitRegister()
    {
        print("Wall recieved Message");

        SceneManager.LoadScene("SampleScene");

    }



}

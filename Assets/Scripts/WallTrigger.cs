using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class WallTrigger : MonoBehaviour
{
 

    private void OnTriggerEnter2D(Collider2D other)
    {

        SceneManager.LoadScene("SampleScene");

    }



}

using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Events;


public class CollectibleStar : MonoBehaviour
{

    int starScore = 0;

    int IncreaseScore(int score)
    {
        score += 1;

        return score;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Star"))
        {
            starScore = IncreaseScore(starScore);

            Destroy(other.gameObject);

            print("Score: " + starScore);

        }
    }
   


    private void Start()
    {
      
    }

    void FixedUpdate()
    {
        print(starScore);
    }
}

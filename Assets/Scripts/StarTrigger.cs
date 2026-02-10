using UnityEngine;

public class StarTrigger : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    Color originalColour;
    float startPosition;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColour = spriteRenderer.color;
        startPosition = transform.position.y;
    }
  

    void HitRegister()
    {
        ScoreManager.instance.AddPoint();


        float timeSinceHit = 0;

        while (timeSinceHit < 1)
        {
            timeSinceHit += Time.deltaTime;
            startPosition += 0.5f;
        }

        if(timeSinceHit >= 1)
        {
            Destroy(gameObject);
        }
      
    }

    void Update()
    {
        
    }
}

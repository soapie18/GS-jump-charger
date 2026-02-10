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
        print("Star Recieved Message");

        float timeSinceHit = 0;

        while (timeSinceHit < 1)
        {
            timeSinceHit += Time.deltaTime;
            startPosition += 0.05f;
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

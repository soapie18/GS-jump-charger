using UnityEngine;

public class StarTrigger : MonoBehaviour
{

    SpriteRenderer spriteRenderer;

    //Colour32s to allow fade out on hit
    Color startColour = new Color32(241, 239, 228, 255);
    Color hitColour = new Color32(241, 239, 228, 0);

    //Not currently in use - no time to fix bugs it causes
    Vector3 startPosition;
    float newY;
    Vector3 hitPosition;

    bool hit = false;
    float timeSinceHit = 0;

    void LerpSpriteColour(Color32 a, Color32 b, float time)
    {
        spriteRenderer.color = Color.Lerp(a, b, time);
    }

    //Not currently in use
    void LerpPosition(Vector3 a, Vector3 b, float time)
    {
        transform.position = Vector3.Lerp(a, b, time);
    }

    //Answers to event sent out by player on hit of star. Communicates 
    //with score manager script to increase the score.
    bool HitRegister()
    {
        ScoreManager.instance.AddPoint();

        hit = true;
        return hit;
    }


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        //startPosition = transform.position;  
        //newY = transform.position.y + 1; 
    }

    void Update()
    {
        //HitRegister makes hit = true. Once its been called, the following code may trigger
        if (hit == true)
        {
            timeSinceHit += Time.deltaTime;

            //hitPosition = new Vector3(transform.position.x, newY, transform.position.z);

            LerpSpriteColour(startColour, hitColour, timeSinceHit);
           
        }
        //Resetting timer used by lerp function and making hit  = false to avoid repeating the 
        //code above unintentionally. Destroys the star after its had time to fade out.
        if (timeSinceHit >= 1)
        {
            timeSinceHit = 0;  

            hit = false;

            Destroy(gameObject);
        }
    }
}

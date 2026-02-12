using UnityEngine;

public class StarTrigger : MonoBehaviour
{

    SpriteRenderer spriteRenderer;

    Color startColour = new Color32(241, 239, 228, 255);
    Color hitColour = new Color32(241, 239, 228, 0);

    Vector3 startPosition;
    float newY;
    Vector3 hitPosition;

    bool hit = false;
    float timeSinceHit = 0;

    void LerpSpriteColour(Color32 a, Color32 b, float time)
    {
        spriteRenderer.color = Color.Lerp(a, b, time);
    }

    void LerpPosition(Vector3 a, Vector3 b, float time)
    {
        transform.position = Vector3.Lerp(a, b, time);
    }

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
        if (hit == true)
        {
            timeSinceHit += Time.deltaTime;

            //hitPosition = new Vector3(transform.position.x, newY, transform.position.z);

            LerpSpriteColour(startColour, hitColour, timeSinceHit);
           
        }
        if (timeSinceHit >= 1)
        {
            timeSinceHit = 0;  

            hit = false;

            Destroy(gameObject);
        }
    }
}

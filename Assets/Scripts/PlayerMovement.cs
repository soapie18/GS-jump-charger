using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float jumpCharge = 0;
    public Rigidbody2D playerRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            public float initialTime = Time.time;
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            float newTime = Time.time;
            float elapsedTime = newTime - initialTime;
            jumpCharge = elapsedTime;

            playerRb.linearVelocity = Vector2.up * jumpCharge;
            
        }
    }
}

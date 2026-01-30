using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float jumpCharge = 3;
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
            //float initialTime = Time.time;s
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
           
            playerRb.linearVelocity = Vector2.up * jumpCharge;
        }
    }
}

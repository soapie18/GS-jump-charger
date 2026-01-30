using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float jumpCharge = 0;
    public Rigidbody2D playerRb;

    float initialTime;
    float newTime;
    float elapsedTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            initialTime = Time.time;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            newTime = Time.time;
            elapsedTime = newTime - initialTime;
            print(elapsedTime);

            jumpCharge = elapsedTime * 10;

            playerRb.linearVelocity = Vector2.up * jumpCharge;

        }
    }
}

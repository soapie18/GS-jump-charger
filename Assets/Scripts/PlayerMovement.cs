using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject floor;
    public Rigidbody2D playerRb;

    float jumpCharge = 3;
    public float maxCharge = 15;

    float initialTime;
    float newTime;
    float elapsedTime;


    void GroundCheck()
    {
        
    }

    void CalculateCharge()
    {
        newTime = Time.time;
        elapsedTime = newTime - initialTime;
    }
   
    void SetJumpCharge()
    {
        jumpCharge += elapsedTime * 10;

        if (jumpCharge > maxCharge)
        {
            jumpCharge = maxCharge;
        }
       
    }

    void ExecuteJump()
    {
        playerRb.linearVelocity = Vector2.up * jumpCharge;
    }



    void Start()
    {

    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            initialTime = Time.time;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CalculateCharge();
           
            SetJumpCharge();

            ExecuteJump();

            jumpCharge = 3;

        }
    }
}

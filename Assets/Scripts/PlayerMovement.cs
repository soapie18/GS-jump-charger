using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //References
    public Rigidbody2D playerRb;
    public SpriteRenderer playerSprite;

    //Variables
    float jumpCharge = 3;
    float minCharge = 3;
    public float maxCharge = 15;

    float incrementTime;
    float elapsedTime;

    public bool floorContact = false;
    bool isCharging = false;

    //Tracks collision with floor
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            floorContact = true;

        }
    }

    //Tracks leaving collision area on floor
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            floorContact = false;
        }
    }


    //For use throughout for checking whether jump is allowed
    bool GroundCheck()
    {
        return floorContact;

    }

    //The following 3 functions are responsible for figuring out how high the player will jump
    void StartIncrement()
    {
        incrementTime += Time.deltaTime;
    }

    void CalculateCharge()
    {

        elapsedTime = incrementTime;

    }

    //This one also caps the charge the player can build to a max value
    void SetJumpCharge()
    {

        jumpCharge += elapsedTime * 10;

        if (jumpCharge > maxCharge)
        {
            jumpCharge = maxCharge;
        }

    }

    //Takes calculated force and applies it to player
    void ExecuteJump()
    {
        if (GroundCheck())
        {
            incrementTime = 0;
            playerRb.linearVelocity = Vector2.up * jumpCharge;
        }
    }

    //Lerping colour based on charge amount/time
    void SetBallColour()
    {
        if (isCharging)
        {
            playerSprite.color = Color.Lerp(Color.yellow, Color.red, (incrementTime-0.1f));
        }
        else
        {
            playerSprite.color = Color.yellow;
        }
    }
 

    void Start()
    {
        floorContact = true;
        SetBallColour();
    }


    //In update I am wrapping everything under the key presses in a ground check as
    //all of this is only allowed to happen when the player is in contact with the 
    //floor
    void Update()
    {

        if (GroundCheck())
        {
            //If the key is pressed (not using GetKeyDown because that is only the frame
            //the key is pressed on) then start the clock and lerp the colour
            if (Input.GetKey(KeyCode.Space))
            {
                StartIncrement();

                isCharging = true;

                SetBallColour();

            }
            //If the key is released this frame, set the colour back to yellow and 
            //execute a jump based on how long the key was held
            if (Input.GetKeyUp(KeyCode.Space))
            {
                isCharging = false;

                SetBallColour();    

                CalculateCharge();

                SetJumpCharge();

                ExecuteJump();

            }

        }
        else
        {
            jumpCharge = minCharge;
        }
    }
}

using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D playerRb;
    public SpriteRenderer playerSprite;

    float jumpCharge = 3;
    float minCharge = 3;
    public float maxCharge = 15;

    float incrementTime;
    float elapsedTime;

    public bool floorContact = false;
    bool isCharging = false;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            floorContact = true;

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            floorContact = false;
        }
    }


    bool GroundCheck()
    {
        return floorContact;

    }

    void StartIncrement()
    {
        incrementTime += Time.deltaTime;
    }

    void CalculateCharge()
    {

        elapsedTime = incrementTime;

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
        if (GroundCheck())
        {
            incrementTime = 0;
            playerRb.linearVelocity = Vector2.up * jumpCharge;
        }
    }

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



    void Update()
    {

        if (GroundCheck())
        {

            if (Input.GetKey(KeyCode.Space))
            {
                StartIncrement();

                isCharging = true;

                SetBallColour();

            }
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

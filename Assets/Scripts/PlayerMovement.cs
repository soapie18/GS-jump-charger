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

  



    void Start()
    {
        floorContact = true;
    }



    void Update()
    {
        print(GroundCheck());

        if (GroundCheck())
        {

            if (Input.GetKey(KeyCode.Space))
            {
                incrementTime += Time.deltaTime;
                playerSprite.color = new Color(1, 0 ,0);

            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                playerSprite.color = Color.yellow;

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

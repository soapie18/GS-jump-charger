using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    float deadZone = -11;

    //Smoothly moves walls left, same rate for all machines because using Time.deltaTime
    void UpdateMovement()
    {

        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }

    //For optimisation, walls passing a certain point will be deleted
    void Purge()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }

    void Update()
    {
        UpdateMovement();

        Purge();

    }
}

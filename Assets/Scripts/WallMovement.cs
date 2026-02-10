using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    float deadZone = -11;

    void UpdateMovement()
    {

        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }

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

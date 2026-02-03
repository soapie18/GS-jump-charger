using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}

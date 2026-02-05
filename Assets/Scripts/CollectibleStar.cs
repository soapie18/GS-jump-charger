using UnityEngine;

public class CollectibleStar : MonoBehaviour
{
    void DestroyStar()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyStar();
    }

    void Update()
    {
        
    }
}

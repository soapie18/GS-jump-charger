using Unity.VisualScripting;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{

    public bool inContact;


    void Start()
    {

    }


    void Update()
    {
       

       
    }

    void OnTriggerStay(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inContact = true;
        }
        else
        {
            inContact = false;
        }

    }
}

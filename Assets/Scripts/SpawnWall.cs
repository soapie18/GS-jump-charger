using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject wall;

    float timePassed;
    public float spawnRate;


    void SpawnInstance()
    {
        Instantiate(wall, transform.position, transform.rotation);
    }
    void Start()
    {
        SpawnInstance();
    }

    void Update()
    {
        if(timePassed < spawnRate)
        {
            timePassed += Time.deltaTime;
        }
        else
        {
            SpawnInstance();
            timePassed = 0;
        }
    }
}

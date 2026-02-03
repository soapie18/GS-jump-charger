using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject wall;

    float timePassed;
    public float spawnRate;

    public float spawnOffset = 5;


    void SpawnInstance()
    {
        float maxHeight = transform.position.y;
        float minHeight = transform.position.y - spawnOffset; 

        Instantiate(wall, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0), transform.rotation);
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
